using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_universidade
{
    public abstract class Avaliacao : IAValiavel
    {
        public double Nota { get; set; }

        public abstract double CalcularNotaFinal();
    }
}
