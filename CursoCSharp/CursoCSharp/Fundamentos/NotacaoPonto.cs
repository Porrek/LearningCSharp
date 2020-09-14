using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            /* A Notação Ponto é utilizado para chamar novas funções dentro da variável.
             * Este código abaixo nada mais é do que: var saudcao = "OLÁ Mundo!";
             * O exemplo serve para explicar o encadeamento de várias chamadas/ operações
             * em uma única linha.
             */
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            /* Colocando o símbolo '?' ao lado da variável 'valorImportante', o valor "Length" será
             * acessado somente se "valorImportante" estiver definida, não podendo ser "null", ou seja
             * um valor nulo.
             * Para deixar o código mais seguro, toda variável nula, ou que deva retornar "null" 
             * de comço e depois armazenar outro valor, deve constar o símbolo '?'.
             */
            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
