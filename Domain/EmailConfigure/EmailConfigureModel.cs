using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Domain.EmailConfigure
{
    public class EmailConfigureModel : IEmailConfigureModel
    {
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

    }
}
