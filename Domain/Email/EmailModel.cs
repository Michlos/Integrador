using System;

namespace Integrador.Domain.Email
{
    public class EmailModel : IEmailModel
    {
        public int Id { get; set; }
        public string IdEmailBox { get; set; }
        public string Remetente { get; set; }
        public string Assunto { get; set; }
        public DateTimeOffset DataDeRecebimento { get; set; }
        public string ConteudoTxt { get; set; }
        public string ConteudoHtml { get; set; }
        public bool Integrado { get; set; }
    }
}
