namespace Integrador.Domain.EmailConfigure
{
    public interface IEmailConfigureModel
    {
        string GetEmail();
        int GetEntradaPorta();
        string GetEntradaServer();
        int GetId();
        string GetSenha();
        int GetSmtpPorta();
        string GetSmtpServer();
        bool GetSslEntradaHabilitado();
        bool GetSslSaidaHabilitado();
    }
}