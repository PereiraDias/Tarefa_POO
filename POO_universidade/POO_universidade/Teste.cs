using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_universidade
{
    public class Teste : Avaliacao
    {
        public override double CalcularNotaFinal()
        {
            return Nota;
        }
    }
}
