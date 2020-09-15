using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro; // houve a conversão implicita de um 'int' em 'double'.
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota;
            Console.WriteLine("Nota truncada {0}", notaTruncada);
            /* a conversão do tipo explicita é conhecida como 'casting', onde no exemplo 
             * coloca-se o 'int' entre colchetes e o mesmo converterá a função 'nota', que é
             * um 'double', em um valor inteiro 'int' e atribui-lo-a a função 'notaTruncada'.
             */

            Console.Write("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString); 
            //'Convert' serve para conversão, e 'ToInt32' é a conversão em número Inteiro de 32 bits
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            //Console.WriteLine("Digite um número");
            //string palavra = Console.ReadLine();
            //int numero;
            //int.TryParse(palavra, out int numero);
            //Console.WriteLine("Resultado: {0}", numero);

            /*'TryParse' serve para tentativa de conversão, em palavras literais:
             * converta a função "palavra" e jogue (out) dentro do número que será setado.
             */

            Console.Write("Digite o primeiro numero:");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1: {0}", numero1);

            Console.Write("Digite o segundo numero:");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);
            /*este exemplo serve para mostrar como é possível colocar o Console.ReadLine dentro
             * do TryParse, e ainda declarar uma variável "int numero2" dentro da própria função.
             */
        }
    }
}
