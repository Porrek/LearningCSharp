using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}", numero);

            for(int i = 1; i <= 50; i++)
            {
                Console.WriteLine("{0} é o número que queremos? ");
                if(i == numero)
                {
                    Console.WriteLine("Sim!");
                    break; //o 'break' só está associado ao "switch" ou laços de repetição.
                }
                else
                {
                    Console.WriteLine("Não!");
                }
            }

        }
    }
}
