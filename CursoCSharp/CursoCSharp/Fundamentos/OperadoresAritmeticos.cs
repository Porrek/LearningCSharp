using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto; 
            // A Operação de multip. tem preferência de 
            Console.WriteLine("O Preço Final é {0}", totalComDesconto);


            // IMC
            double peso = 91.2;
            double altura = 1.82;
            // A Função Math.Pow serve para fazer o número elevado à potência, no caso o '2".
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}.");


            // Número Par/Impar
            int par = 24;
            int impar = 55;
            /* Quando se coloca '%' + número, refere-se a um módulo, ou seja,
             * quer dizer o resto da Operação (no caso baixo é um numero, divide pelo outro
             * e o resto é o que será imputado no console).
             */
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }

    }
}
