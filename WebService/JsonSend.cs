using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Integrador.Domain.Cliente;
using Integrador.Domain.ClienteOnBlox;

using Newtonsoft.Json;

namespace Integrador.WebService
{
    public class JsonSend
    {
        private static readonly HttpClient client = new HttpClient();

        public JsonSend(string userName, string password)
        {
            var byteArray = Encoding.ASCII.GetBytes($"{userName}:{password}");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

        }
        public async Task SendClienteAsync(ClienteModel cliente, string url)
        {
            //ONBLOX
            //ClienteOnBloxModel cliEnviar = new ClienteOnBloxModel()
            //{

            //    //CONVERTE O CODIGO DO CLIENTE EM ID PARA INTEGRAR NO ONBLOX
            //    id = long.Parse(cliente.codigo),
            //    nome = cliente.nome,
            //    codigo = cliente.codigo,
            //    integracao = cliente.integracao,
            //    tpDoc = cliente.tpDoc,
            //    cgc = cliente.cgc,
            //    fantasia = cliente.fantasia,
            //    fone = cliente.fone,
            //    cep = cliente.cep,
            //    logradouro = cliente.logradouro,
            //    numero = cliente.numero,
            //    bairro = cliente.bairro,
            //    cidade = cliente.cidade,
            //    uf = cliente.uf
            //};

            ///TESTE LOCAL
            ClienteModel cliEnviar = new ClienteModel()
            {

                //CONVERTE O CODIGO DO CLIENTE EM ID PARA INTEGRAR NO ONBLOX
                Id = long.Parse(cliente.codigo),
                nome = cliente.nome,
                codigo = cliente.codigo,
                integracao = cliente.integracao,
                tpDoc = cliente.tpDoc,
                cgc = cliente.cgc,
                fantasia = cliente.fantasia,
                fone = cliente.fone,
                cep = cliente.cep,
                logradouro = cliente.logradouro,
                numero = cliente.numero,
                bairro = cliente.bairro,
                cidade = cliente.cidade,
                uf = cliente.uf
            };

            try
            {

                var json = JsonConvert.SerializeObject(cliEnviar);
                //SE NAO DER CERTO TENTA ESSE E DEPOIS SE VIRA NO RESTO DOS DADOS
                //var content = new StringContent(json);   
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);

                response.EnsureSuccessStatusCode();


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
