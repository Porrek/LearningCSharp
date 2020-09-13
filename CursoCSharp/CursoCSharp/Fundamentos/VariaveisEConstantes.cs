using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos Internos

            bool estaChovendo = false;

            //if para validar no caso de não estar chovendo
            //if (estaChovendo == false)
            //{
            //    Console.WriteLine("Está chovendo: Não ");
            //    return;
            //}

            /*caso o estaChovendo estiver 'false' não entrará no if
             *continuando a partir daqui.
             */
            //Console.WriteLine("Está chovendo: Sim");

            // forma resumida de teste boleano, 'if ternário'.
            //string teste = estaChovendo ? "sim" : "não";
            //Console.WriteLine("Está chovendo " + teste);

            byte idade = 45;
            Console.WriteLine("Idade é " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols é " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario é " + salario);

            int menorValorInt = int.MinValue; //Mais usado dos inteiros!
            Console.WriteLine("Salário é " + menorValorInt);

            uint populacaoBrasileira = 207_600_00;
            Console.WriteLine("População Brasileira é " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long é " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial é " + populacaoMundial);

            //para atribuir dentro do 'float' é preciso terminar com o 'f' no final.
            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador é " + precoComputador);

            double valorDeMercadoDaApple = 1_0_


        }
    }
}
