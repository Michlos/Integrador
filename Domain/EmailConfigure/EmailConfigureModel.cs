using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Domain.EmailConfigure
{
    [Table("EmailConfigure")]
    public class EmailConfigureModel : IEmailConfigureModel
    {
        //CONFIGURAÇÃO DE CONTA
        [Key]
        public int Id { get; set; }


        [Required, StringLength(50)]
        public string Email { get; set; }

        [Required, StringLength(12)]
        public string Senha { get; set; }

        [Required, StringLength(50)]
        public string SmtpServer { get; set; }

        [Required]
        public int SmtpPorta { get; set; }

        [Required]
        public bool SslSaidaHabilitado { get; set; }

        [Required, StringLength(50)]
        public string EntradaServer { get; set; }

        [Required]
        public int EntradaPorta { get; set; }

        [Required]
        public bool SslEntradaHabilitado { get; set; }


        //CONFIGURAÇÃO DE EXTRAÇÃO DE DADOS

        //"INBOX"
        [Required, StringLength(10)]
        public string CaixaDeEmail { get; set; }

        [Required, StringLength(300)]
        public string AssuntoEmail { get; set; }

        //"Totais gerais"
        [Required, StringLength(50)]
        public string InicioRelatorio { get; set; }

        //"<!-- Start report output -->"
        [Required, StringLength(50)]
        public string FinalRelatorio { get; set; }

        // "//tr//td"
        [Required, StringLength(10)]
        public string TagExtracao { get; set; }

        [Required, StringLength(200)]
        public string PastaTemporaria { get; set; }


    }
}
