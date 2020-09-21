using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 7.0;
            var resultado = nota >= 7.0 ? "Aprovado" : "Reprovado"; // o símbolo "?" é um ternário
            Console.WriteLine(resultado);
        }
    }
}
