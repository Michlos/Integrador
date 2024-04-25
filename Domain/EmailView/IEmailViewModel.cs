using System;

namespace Integrador.Domain.EmailView
{
    public interface IEmailViewModel
    {
        string Assunto { get; set; }
        string ConteudoHtml { get; set; }
        string ConteudoTxt { get; set; }
        DateTimeOffset DataDeRecebimento { get; set; }
        int Id { get; set; }
        string Remetente { get; set; }
    }
}