using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie meu atendimento, nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            /* O Switch trata de números inteiros, diferente do 'if', que por sua vez trata
             * de elementos booleanos somente.*/
            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                /* o 'break' faz com que após a validação do 'switch', o sistema
                vá para a linha posterior.*/
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;

                case 3:
                    Console.WriteLine("Regular");
                    break;

                case 4:
                    Console.WriteLine("Bom");
                    break;

                case 5:
                    Console.WriteLine("Òtimo");
                    break;

                default: // O 'default', no exemplo, irá registrar respostas diferentes de 1-5.
                    Console.WriteLine("Nota Inválida");
                    break;
            }

            Console.WriteLine("Obrigado por responder, sua nota foi: {0}", nota);
        }

    }
}
