namespace Integrador.Domain.EmailConfigure
{
    public interface IEmailConfigureModel
    {
        string CaixaDeEmail { get; set; }
        string Email { get; set; }
        int EntradaPorta { get; set; }
        string EntradaServer { get; set; }
        string FinalRelatorio { get; set; }
        int Id { get; set; }
        string InicioRelatorio { get; set; }
        string PastaTemporaria { get; set; }
        string Senha { get; set; }
        int SmtpPorta { get; set; }
        string SmtpServer { get; set; }
        bool SslEntradaHabilitado { get; set; }
        bool SslSaidaHabilitado { get; set; }
        string TagExtracao { get; set; }
        string AssuntoEmail { get; set; }
    }
}