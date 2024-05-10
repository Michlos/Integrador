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

        public async Task<string> SendData(ClienteModel clienteModel)
        {
            var json = JsonConvert.SerializeObject(clienteModel);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://192.168.0.5/onblox/api/cliente", data);

            string result = response.Content.ReadAsStringAsync().Result;


            if (response.IsSuccessStatusCode)
            {
                return "positivo";
            }
            else
            {
                return "negativo";
            }
        }
    }
}
