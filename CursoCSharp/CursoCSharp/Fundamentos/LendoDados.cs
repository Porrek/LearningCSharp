using System;
using System.Globalization; 
/*o 'System.Globalization' fará com que os valores digitados no campo "salario",
 * transformem o '.' em vírgula, para isso utilizamos a função:
 * 'CultureInfo.InvariantCulture'.
 */

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine()); //a função Parse transforma tudo em string.

            Console.Write("Qual é o seu salario? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            /*InvariantCulture irá pegar o '.' como separador, assim transformando o valor
             * do salário.
             */

            Console.WriteLine($"{nome} {idade} R${salario}"); //interpolação
        }
    }
}
