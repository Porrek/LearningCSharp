using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //{
            //    bomComportamento = true; 
            //}

            //bomComportamento = entrada == "S" || entrada == "s";
            bomComportamento = entrada.ToLower() == "s"; //ToLower converte de maiusc. p/ minusc.


            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de Honra!");
            }
            else
            {
                Console.WriteLine("Não Entrou no Quadro de Honra!");
            }
        }
    }
}
