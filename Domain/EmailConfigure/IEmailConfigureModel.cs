namespace Integrador.Domain.EmailConfigure
{
    public interface IEmailConfigureModel
    {
        string Email { get; set; }
        int EntradaPorta { get; set; }
        string EntradaServer { get; set; }
        int Id { get; set; }
        string Senha { get; set; }
        int SmtpPorta { get; set; }
        string SmtpServer { get; set; }
        bool SslEntradaHabilitado { get; set; }
        bool SslSaidaHabilitado { get; set; }
    }
}