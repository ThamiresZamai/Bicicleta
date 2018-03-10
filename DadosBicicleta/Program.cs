using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bicicleta;

namespace DadosBicicleta
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicicleta.Bicicleta b = new Bicicleta.Bicicleta();
            Fabricante fa = new Fabricante();
            Cargo ca = new Cargo();

                Console.WriteLine("Insira o Id da Bicicleta: ");
                b.id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o modelo: ");
                b.Modelo = Console.ReadLine();
                b.DataFabricacao = DateTime.Now;
                Console.WriteLine("Insira o id do fabricante: ");
                fa.id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o nome do fabricante: ");
                fa.Nome = Console.ReadLine();
            b.Fabricante = fa;

                Console.WriteLine("Insira o id do cargo: ");
                ca.id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira a descrição do cargo: ");
                ca.Descricao = Console.ReadLine();
            fa.cargo = ca;

            Console.WriteLine(b.ToString());
            Console.ReadKey();
        }
    }
}
