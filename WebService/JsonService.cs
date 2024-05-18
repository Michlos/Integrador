using Integrador.Domain.Cliente;
using Integrador.Domain.EmailConfigure;
using Integrador.Domain.LogIntegracao;
using Integrador.Repository.EmailConfigure;
using Integrador.Services.EmailConfigure;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador.WebService
{
    public class JsonService
    {
        private static readonly HttpClient client = new HttpClient();
        private HttpResponseMessage ResponseMessage = new HttpResponseMessage();

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
                uf = clienteModel.uf

            };

            var json = JsonConvert.SerializeObject(cliEnviar);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            //SaveJsonToFile(json);

            try
            {
                ResponseMessage = await client.PostAsync("http://191.252.3.79:9001/onblox/api/cliente", data);

            }
            catch (Exception e)
            {

                throw new Exception($"Falha na integração. MessageError: {e.Message} InnerException: {e.InnerException}");
            }
            finally
            {
                SaveLogFile();
                ResponseMessage = null;
            }



        }

        private async void SaveLogFile()
        {
            LogIntegracao logIntegracao = new LogIntegracao()
            {
                Codigo = (int)ResponseMessage.StatusCode,
                Mensagem = ResponseMessage.ReasonPhrase
            };
            string json = JsonConvert.SerializeObject(logIntegracao, Formatting.Indented);

            try
            {
                using (StreamWriter file = File.AppendText(@"C:\INTEGRADOR\LogIntegrador.json"))
                {
                    await file.WriteAsync(json);

                }
            }
            catch (Exception e)
            {

                throw new Exception($"Erro ao salvar o arquivo de Log. MessageError: {e.Message} / InnerException: {e.InnerException}");
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
    }
}
