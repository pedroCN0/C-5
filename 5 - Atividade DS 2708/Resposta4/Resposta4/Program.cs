using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resposta4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Pessoa N = new Pessoa();
            Console.WriteLine("Digite o peso do individuo:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora, digite a altura do individuo:");
            b = double.Parse(Console.ReadLine());
            c = N.IMC(a, b);
            Console.WriteLine("O IMC do indivíduo é: {0}", c);
            Console.ReadKey();
        }
    }
}
