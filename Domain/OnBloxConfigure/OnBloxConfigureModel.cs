using System;

namespace Integrador.Domain.OnBloxConfigure
{
    public class OnBloxConfigureModel : IOnBloxConfigureModel
    {

        public int Id { get; set; }

        //DADOS DE CONEXÃO
        public string Usuario { get; set; }
        public string Senha { get; set; }

        //HORA DE EXECUÇÃO
        public TimeSpan HoraExecucao01 { get; set; }
        public TimeSpan HoraExecucao02 { get; set; }
        public TimeSpan HoraExecucao03 { get; set; }


        //INTEGRAÇÃO DE CLIENTES
        public long ClienteUlimoIdIntegrado { get; set; }
        public string ClienteAssuntoEmail { get; set; }
        public bool ClienteIntegra { get; set; }
        public string ClienteURIPost { get; set; }
        public int ClienteURIPorta { get; set; }

        //INTEGRAÇÃO DE BATELADA
        public string BateladaLocalArquivo { get; set; }
        public bool BateladaIntegra { get; set; }

    }
}
