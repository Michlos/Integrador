using Integrador.Domain.Cliente;
using Integrador.Domain.ClienteOnBlox;
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
        private readonly OnBloxConfigureModel _onBloxConfigureModel;
        private readonly EmailConfigureModel _emailConfigureModel;
        private readonly ClienteService _clienteService;

        private HttpResponseMessage responseMsg = new HttpResponseMessage();
        //private Task<string> dataSended;
        private string jsonToSend;
        private string uriToSend;

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

        public void SendData(ClienteModel clienteModel)
        {

            //ONBLOX
            ClienteOnBloxModel cliEnviar = new ClienteOnBloxModel()
            {

                //CONVERTE O CODIGO DO CLIENTE EM ID PARA INTEGRAR NO ONBLOX
                id = long.Parse(clienteModel.codigo),
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
                uf = clienteModel.uf

            };


            //DADOS A SEREM INTEGRADOS
            

            uriToSend = _onBloxConfigureModel.ClienteURIPost.ToString();
            
            //COLOCANDO O JSON EM UM ARRAY
            var jsonArray = new List<ClienteOnBloxModel> { cliEnviar };

            //SERIALIZANDO JSON UTILIZANDO O ARRAY
            jsonToSend = JsonConvert.SerializeObject(jsonArray);
            
            //CONTEINERIZANDO DADOS A SEREM ENVIADOS
            var content = new StringContent(jsonToSend, Encoding.UTF8 , "application/json");

            //DADOS DE AUTENTICAÇÃO
            if (!string.IsNullOrEmpty(_onBloxConfigureModel.Usuario.Trim()))
            {
                var byteArray = Encoding.ASCII.GetBytes($"{_onBloxConfigureModel.Usuario}:{_onBloxConfigureModel.Senha}");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            }


            try
            {
                //TESTE DE AUTENTICAÇÃO
                //var responseMessageLogin = await httpClient.GetAsync(uriString);

                //POSTANDO OS DADOS NA API
                responseMsg = httpClient.PostAsync(uriToSend.ToString(), content).GetAwaiter().GetResult();
                if (responseMsg != null)
                    ResponseMessage = responseMsg;



                //MARCAR O CLIENTE COMO INTEGRADO SE RESPOSTA FOR OK
                int statusRetorno = (int)responseMsg.StatusCode;
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
               
                //GRAVANDO ARQUIVO JSON
                SaveJsonToFile(jsonToSend);

                //GERANDO LOG DE INTEGRAÇÃO
                SaveLogFile(jsonToSend, uriToSend);
                
                ResponseMessage = null;
            }



        }

        private async void SaveLogFile(string json, string uri)
        {
            LogIntegracao logIntegracao = new LogIntegracao()
            {
                Uri = uri,
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
                file?.Close();
            }
        }

        public async void SaveJsonToFile(string json)
        {
            try
            {
                using (StreamWriter file = File.CreateText($@"{_emailConfigureModel.PastaTemporaria}\arquivo.json"))
                {
                    await file.WriteAsync(json);

                }
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao salvar o arquivo JSON. MessageError: {e.Message} InnerException: {e.InnerException}");
            }
        }

       
    }
}
