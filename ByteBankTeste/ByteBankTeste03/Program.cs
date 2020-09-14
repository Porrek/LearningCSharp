using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankTeste3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissão = "Desenvolvedora";
            //gabriela.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();

            // conta.titular = gabriela;
            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "434.562.878-20";
            conta.titular.profissao = "Desenvolvedora C#";


            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            /*neste exemplo abaixo o objeto é o mesmo,'Gabriela', sendo acessado de duas
             *maneiras diferentes.
             */
            // Console.WriteLine("Titular da Conta é " + gabriela.nome);
            Console.WriteLine("Titular da Conta é (outro acesso) " + conta.titular.nome);

        }
    }
}
