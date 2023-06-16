using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDeC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, numero4, media;

            Console.WriteLine("===============================");
            Console.WriteLine("|        Calcular Média       |");
            Console.WriteLine("===============================");
            Console.WriteLine("Digite o Número 1: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Número 2: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Número 3: ");
            numero3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Número 4: ");
            numero4 = Convert.ToInt32(Console.ReadLine());

            media = (numero1 + numero2 + numero3 + numero4)/4;

            Console.WriteLine("================================");
            Console.WriteLine(" |O Resultado da Média é:|" +media);
            Console.WriteLine("================================");
        }
    }
}
