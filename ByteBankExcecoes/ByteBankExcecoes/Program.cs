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
            try
            {
                Metodo();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Aconteceu um erro!");
            }

            Console.ReadLine();
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultador da divisão de 10 por" + divisor + "é" + resultado);
            }
            catch(DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Não é Possível fazer uma divisão por 0!");
            }
        }

        private static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);

            return numero / divisor;
        }
    }
}
