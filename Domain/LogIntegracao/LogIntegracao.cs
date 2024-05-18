using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Domain.LogIntegracao
{
    public class LogIntegracao
    {
        public DateTime DataHora { get; set; } = DateTime.Now;
        public int Codigo { get; set; }
        public string Mensagem { get; set; }

    }
}
