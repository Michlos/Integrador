using System;

namespace Integrador.Domain.Email
{
    public interface IEmailModel
    {
        string GetAssunto();
        string GetConteudoHtml();
        string GetConteudoTxt();
        DateTimeOffset GetDataDeRecebimento();
        int GetId();
        string GetRemetente();
    }
}