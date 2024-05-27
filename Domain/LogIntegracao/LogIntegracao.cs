using System;

namespace Integrador.Domain.LogIntegracao
{
    public class LogIntegracao
    {
        public DateTime DataHora { get; set; } = DateTime.Now;
        public int Codigo { get; set; }
        public string Mensagem { get; set; }

    }
}
