using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            // A função ToString transforma o valor número em uma String.
            Console.WriteLine(valor.ToString("F1")); 
            Console.WriteLine(valor.ToString("C")); // 'C' = a Currency
            Console.WriteLine(valor.ToString("P")); // 'P' = a Percentual
            Console.WriteLine(valor.ToString("#.##")); // '#.##' formata o número.

            CultureInfo cultura = new CultureInfo("pt-BR");// Uma nova info de Cultura.
            Console.WriteLine(valor.ToString("C0", cultura));
            /*'C0' = Currency sem nenhuma casa decimal
             * cultura =  pt-BR, a qual, faz com que a currency transforme-se em real 'R$'
             */

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // 'D' = Digito
        }
    }
}
