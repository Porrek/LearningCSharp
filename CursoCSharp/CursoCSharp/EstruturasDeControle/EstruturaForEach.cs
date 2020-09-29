using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Opa!";

            /*neste caso, o foreach percorrerá toda a palavra e cada repetição/letra será atribuida para a 
              vaíável 'letra'*/
            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" }; //estrutura de um array.

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
        }
    }
}
