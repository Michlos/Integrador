using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Domain.OnBloxConfigure
{
    public class OnBloxConfigureModel : IOnBloxConfigureModel
    {
        public int Id { get; set; }
        public string ClienteAssuntoEmail { get; set; }
        public string BateladaLocalArquivo { get; set; }
        public bool ClienteIntegra { get; set; }
        public bool BateladaIntegra { get; set; }
    }
}
