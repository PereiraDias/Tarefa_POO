using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_veiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo carro1 = new Veiculo("LD-900-AB", "Toyota", "Lexus", 2021, 900);
            Veiculo carro2 = new Veiculo("LD-901-CD", "Hyundai", "Tucson", 2022, 550);
            Veiculo carro3 = new Veiculo("LD-902-EF", "Kia", "Niro", 2023, 120);
                   
            carro1.ActualizarQuilometragem(300);
            carro2.ActualizarQuilometragem(150);
            carro3.ActualizarQuilometragem(400);

            carro1.ApresentarDados();
            carro2.ApresentarDados();
            carro3.ApresentarDados();


            Console.ReadKey();
        }
        
    }
}
