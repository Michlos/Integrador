using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Domain.Email
{
    public class EmailModel
    {
        public int Id { get; set; }
        public string Remetente { get; set; }
        public string Assunto { get; set; }
        public DateTimeOffset DataDeRecebimento { get; set; }
        public string ConteudoTxt { get; set; }
        public string ConteudoHtml { get; set; }
    }
}
