using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            var nome = "Notebook Gamer";
            var marca = "Dell";
            var preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + "custa" + preco + ".");
            /* A Interpolação funciona para não precisar se perder na concatenação
             * colocando os índices {0}, {1} e {2} e depois da 'virugla' as variáveis 
             * que deverão substituir os números.
             */
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);
            /* Colocando o '$' na frente do texto entre as aspas, também funciona para
             * concatenar, mas, deverá ser posto a variável marca, etc, entre chaves {}.
             */
            Console.WriteLine($"A marca {marca} é legal!");
            Console.WriteLine($"1 + 1 = {1 + 1}!");
        }
    }
}
