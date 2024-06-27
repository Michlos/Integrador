using Integrador.Domain.Cliente;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Domain.ClienteOnBlox
{
    /// <summary>
    /// Classe utilizada somente para envio do Json para ONBlox
    /// Não guarda nada no banco de daos apenas utiliza para serializar
    /// Foi implementada por causa do CammelCase do ID que não rodou depois
    /// de retirado o CammelCase que veio errado na documentação
    /// do fornecedor
    /// </summary>
    public class ClienteOnBloxModel
    {
        //[JsonIgnore]
        public long id { get; set; }
        public string nome { get; set; }
        public string codigo { get; set; }
        public string integracao { get; set; }
        public string tpDoc { get; set; }
        public string cgc { get; set; }
        public string fantasia { get; set; }
        public string fone { get; set; }
        public int cep { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }

    }
}
