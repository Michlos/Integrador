namespace Integrador.Domain.OnBloxConfigure
{
    public interface IOnBloxConfigureModel
    {
        bool BateladaIntegra { get; set; }
        string BateladaLocalArquivo { get; set; }
        string ClienteAssuntoEmail { get; set; }
        bool ClienteIntegra { get; set; }
        int Id { get; set; }
    }
}