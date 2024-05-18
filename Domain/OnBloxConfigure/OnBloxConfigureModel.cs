using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Domain.OnBloxConfigure
{
    public class OnBloxConfigureModel : IOnBloxConfigureModel
    {

        public int Id { get; set; }

        //DADOS DE CONEXÃO
        public string Usuario { get; set; }
        public string Senha { get; set; }

        //INTEGRAÇÃO DE CLIENTES
        public string ClienteAssuntoEmail { get; set; }
        public bool ClienteIntegra { get; set; }
        public string ClienteURIPost { get; set; }
        public int ClienteURIPorta { get; set; }

        //INTEGRAÇÃO DE BATELADA
        public string BateladaLocalArquivo { get; set; }
        public bool BateladaIntegra { get; set; }

    }
}
