using System;

namespace Integrador.Domain.Email
{
    public interface IEmailModel
    {
        string Assunto { get; set; }
        string ConteudoHtml { get; set; }
        string ConteudoTxt { get; set; }
        DateTimeOffset DataDeRecebimento { get; set; }
        int Id { get; set; }
        bool Integrado {  get; set; }
        string Remetente { get; set; }
        string IdEmailBox { get; set; }
    }
}