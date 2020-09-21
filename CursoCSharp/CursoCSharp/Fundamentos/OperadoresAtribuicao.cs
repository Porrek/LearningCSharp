using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7; // substituiu o valor setado anteriormente.
            num1 += 10; // num1 = num1 + 10;
            num1 -= 3; // num1 = num1 - 3;
            num1 *= 5; // num1 = num1 * 5;
            num1 /= 2; // num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a; // atribuição por cópia.

            a++; // a = a + 1;
            b--; // b = b - b;

            Console.WriteLine($"{a} {b}");

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c; // atribuição por referência
            d.nome = "Maria";

            Console.WriteLine(c.nome);
        }
    }
}
