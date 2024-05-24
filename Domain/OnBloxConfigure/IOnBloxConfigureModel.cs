using System;

namespace Integrador.Domain.OnBloxConfigure
{
    public interface IOnBloxConfigureModel
    {
        bool BateladaIntegra { get; set; }
        string BateladaLocalArquivo { get; set; }
        string ClienteAssuntoEmail { get; set; }
        bool ClienteIntegra { get; set; }
        int ClienteURIPorta { get; set; }
        string ClienteURIPost { get; set; }
        int Id { get; set; }
        string Senha { get; set; }
        string Usuario { get; set; }
        TimeSpan HoraExecucao { get; set; }
        long ClienteUlimoIdIntegrado { get; set; }
    }
}