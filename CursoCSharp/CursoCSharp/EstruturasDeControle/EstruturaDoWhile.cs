using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;

            do //o 'do' será executado pelo menos uma vez, enquanto que somente o 'while' pode ser pulado.
            {
                Console.WriteLine("Qual o seu Nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo {0}", entrada);
                Console.WriteLine("Deseja Continuar? S/N");
                entrada = Console.ReadLine();
            }
                while (entrada.ToLower() == "s");
        }

    }
}
