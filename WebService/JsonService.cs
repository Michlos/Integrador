using Integrador.Domain.Cliente;
using Integrador.Domain.EmailConfigure;
using Integrador.Domain.LogIntegracao;
using Integrador.Domain.OnBloxConfigure;
using Integrador.Repository.Cliente;
using Integrador.Repository.EmailConfigure;
using Integrador.Repository.OnBloxConfigure;
using Integrador.Services;
using Integrador.Services.Cliente;
using Integrador.Services.EmailConfigure;
using Integrador.Services.OnBloxConfigure;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador.WebService
{
    public class JsonService
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private HttpResponseMessage ResponseMessage = new HttpResponseMessage();
        private readonly OnBloxService _onBloxConfigureService;
        private readonly EmailConfigureService _emailConfigureService;
        private OnBloxConfigureModel _onBloxConfigureModel;
        private EmailConfigureModel _emailConfigureModel;
        private readonly ClienteService _clienteService;

        public JsonService()
        {
            _onBloxConfigureService = new OnBloxService(new OnBloxConfigureRepository(new AppDbContext()));
            _clienteService = new ClienteService(new ClienteRepository(new AppDbContext()));
            _emailConfigureService = new EmailConfigureService(new EmailConfigureRepository(new AppDbContext()));
            _onBloxConfigureModel = _onBloxConfigureService.GetOnBloxConfigure();
            _emailConfigureModel = _emailConfigureService.GetEmailConfigure();

            //IGNORA A VALIDAÇÃO DO CERTIFICADO SSL
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, SslPolicyErrors) => true;
        }

        public async void SendData(ClienteModel clienteModel)
        {
            ClienteModel cliEnviar = new ClienteModel()
            {
                Id = clienteModel.Id,
                nome = clienteModel.nome,
                codigo = clienteModel.codigo,
                integracao = clienteModel.integracao,
                tpDoc = clienteModel.tpDoc,
                cgc = clienteModel.cgc,
                fantasia = clienteModel.fantasia,
                fone = clienteModel.fone,
                cep = clienteModel.cep,
                logradouro = clienteModel.logradouro,
                numero = clienteModel.numero,
                bairro = clienteModel.bairro,
                cidade = clienteModel.cidade,
                uf = clienteModel.uf,
                DataIntegracao = DateTime.Now

            };

            //DADOS A SER INTEGRADO
            var json = JsonConvert.SerializeObject(cliEnviar);
            var dataToSend = new StringContent(json, Encoding.UTF8, "application/json");
            SaveDataContent(dataToSend);

            //DADOS DE AUTENTICAÇÃO
            if (!string.IsNullOrEmpty(_onBloxConfigureModel.Usuario))
            {
                var byteArray = Encoding.ASCII.GetBytes($"{_onBloxConfigureModel.Usuario}:{_onBloxConfigureModel.Senha}");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            }

            SaveJsonToFile(json);

            try
            {
                //POSTANDO OS DADOS NA API
                var responseMessage = httpClient.PostAsync(_onBloxConfigureService.GetOnBloxConfigure().ClienteURIPost.ToString(),
                    dataToSend).GetAwaiter().GetResult();
                if (responseMessage != null)
                    ResponseMessage = responseMessage;


                //TESTE DE AUTENTICAÇÃO
                //var responseMessage = await httpClient.GetAsync(_onBloxConfigureModel.ClienteURIPost.ToString());

                //MARCAR O CLIENTE COMO INTEGRADO SE RESPOSTA FOR OK
                int statusRetorno = (int)responseMessage.StatusCode;
                if (statusRetorno == 200)
                {
                    clienteModel.DataIntegracao = DateTime.Now;
                    _clienteService.SetIntegrado(clienteModel);

                }


            }
            catch (Exception e)
            {

                throw new Exception($"Falha na integração. MessageError: {e.Message} InnerException: {e.InnerException}");
            }
            finally
            {
                SaveLogFile(json);
                //SaveJsonToFile();
                ResponseMessage = null;
            }



        }

        private async void SaveLogFile(string json)
        {
            LogIntegracao logIntegracao = new LogIntegracao()
            {
                Codigo = (int)ResponseMessage.StatusCode,
                DadosEnviados = json,
                Mensagem = ResponseMessage.ReasonPhrase
            };

            string logSerializado = JsonConvert.SerializeObject(logIntegracao, Formatting.Indented);
            StreamWriter file = null;
            try
            {
                file = File.AppendText($@"{_emailConfigureModel.PastaTemporaria}\LogIntegrador.json");
                await file.WriteAsync("\n" + logSerializado);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao salvar o arquivo de Log. MessageError: {e.Message} \n InnerException: {e.InnerException}");
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }

        public async void SaveJsonToFile(string json)
        {
            try
            {
                using (StreamWriter file = File.CreateText(@"C:\INTEGRADOR\arquivo.json"))
                {
                    await file.WriteAsync(json);

                }
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao salvar o arquivo JSON. MessageError: {e.Message} InnerException: {e.InnerException}");
            }
        }

        public async void SaveDataContent(StringContent data)
        {
            var content = await data.ReadAsStringAsync();
            try
            {
                string path = $@"{_emailConfigureModel.PastaTemporaria}\contentdata.txt";

                using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
                {
                    using (StreamWriter file = new StreamWriter(stream))
                    {
                        await file.WriteAsync(content);
                    }


                }
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao salvar os dados do httcontent: MessageError: {e.Message} InnerException: {e.InnerException}");
            }
        }
    }
}
