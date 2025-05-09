using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reformix.Models
{
    internal class Calculo
    {
        public Calculo() { }

        public DateTime Data { get; set; }
        public string Ambiente { get; set; }
        public string Operacao { get; set; }
        public string MaterialNecessario { get; set; }
    }
}
