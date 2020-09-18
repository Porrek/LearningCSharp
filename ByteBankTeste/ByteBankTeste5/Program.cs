using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankTeste5
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 86712540);
            Console.WriteLine("Total de Contas Criadas: ",ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(847, 8672820);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            Console.WriteLine("Total de Contas Criadas: ", ContaCorrente.TotalDeContasCriadas);
        }
    }
}
