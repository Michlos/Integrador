using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Domain.Cliente
{
    public class ClienteModel : IClienteModel
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string nome { get; set; }
        public string codigo { get; set; }
        public string integracao { get; set; }
        public string tpDoc { get; set; }
        public string cgc { get; set; }
        public string fantasia { get; set; }
        public string fone { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public bool integrado { get; set; } = false;

    }
}
