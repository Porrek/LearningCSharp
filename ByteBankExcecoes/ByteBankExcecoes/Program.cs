using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(86712345, 867);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente contaDaGabriela = new ContaCorrente(987441555, 987);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
