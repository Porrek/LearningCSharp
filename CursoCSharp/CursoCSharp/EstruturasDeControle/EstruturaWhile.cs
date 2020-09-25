using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random(); // 'Random' é uma classe de valor aleatório.

            int numeroSecreto = random.Next(1, 16); 
            // 'next' irá gerar um valor dentro de um parametro, no caso entre 1 e 15, pois o 16 nao entra.
            bool numeroEncontrato = false;
            // a variavel começa com 'false' pois no caso, quando alguém acertar, será validado como true.
            int tentativasRestantes = 5;
            int tentativasAtuais = 0;

            while (tentativasRestantes > 0 && !numeroEncontrato)
            {
                Console.WriteLine("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativasAtuais++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrato = true;
                    var corAnterior = Console.BackgroundColor;
                    //Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parabéns! Numero encontrado em {0} tentativas", 
                        tentativasAtuais, Console.BackgroundColor = ConsoleColor.Green);                    
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {

                    var corAnterior = Console.BackgroundColor;
                    //Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Menor... Tente Novamente!", 
                        Console.BackgroundColor = ConsoleColor.Red);
                    Console.BackgroundColor = corAnterior;                    
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("Maior... Tente Novamente");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
            }
        }
    }
}
