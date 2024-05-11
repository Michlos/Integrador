using Integrador.Domain.Cliente;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.WebService
{
    public class JsonService
    {
        private static readonly HttpClient client = new HttpClient();

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
                uf = clienteModel.uf

            };
            var json = JsonConvert.SerializeObject(cliEnviar);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (var response = await client.PostAsync("http://192.252.3.79/onblox/api/cliente", data))
            {
                if (response.IsSuccessStatusCode)
                {

                    var result = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    var result = response.Content.ReadAsStringAsync();
                }
            }

            
        }
    }
}
