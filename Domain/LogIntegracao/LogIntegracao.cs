using System;

namespace Integrador.Domain.LogIntegracao
{
    public class LogIntegracao
    {
        public string user { get; set; }
        public string up { get; set; }
        public string Uri { get; set; }
        public DateTime DataHora { get; set; } = DateTime.Now;
        public string DadosEnviados { get; set; }
        public int Codigo { get; set; }
        public string Mensagem { get; set; }
        

    }
}
