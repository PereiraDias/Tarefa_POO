using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_universidade
{
    public class UnidadeCurricular
    {
        public string Nome { get; set; }

        public List<Estudante> Estudantes { get; set; }

        public List<Avaliacao> Avaliacoes { get; set; }

        public UnidadeCurricular()
        {
            Estudantes = new List<Estudante>();
            Avaliacoes = new List<Avaliacao>();
        }

        public void EmitirPauta()
        {
            Console.WriteLine("PAUTA DA UNIDADE CURRICULAR: " + Nome);
            Console.WriteLine("*************************************************");

            foreach (var estudante in Estudantes)
            {
                double notaFinal = 0;

                foreach (var avaliacao in Avaliacoes)
                {
                    notaFinal += avaliacao.CalcularNotaFinal();
                }

                Console.WriteLine($"{estudante.Nome} - Nota Final: {notaFinal:F2}");
            }
        }
    }
}
