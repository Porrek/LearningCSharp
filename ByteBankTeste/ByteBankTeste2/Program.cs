using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankTeste2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.titular = "Bruno";
            Console.WriteLine("Saldo atual Bruno " + contaCorrente.saldo);

            bool resultadoSaque = contaCorrente.Sacar(500);
            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaCorrente.saldo);            

            contaCorrente.Depositar(500);
            Console.WriteLine("Saldo do Deposito " + contaCorrente.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            bool resultadoTransferencia = contaCorrente.Transferir(200, contaDaGabriela);

            contaDaGabriela.titular = "Gabriela";

            contaCorrente.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno " + contaCorrente.saldo);
            Console.WriteLine("Saldo da Gabriela " + contaDaGabriela.saldo);

            Console.WriteLine("Resultado Transferencia " + resultadoTransferencia);

        }
    }
}
