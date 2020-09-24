using ByteBankTeste6.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankTeste6
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "454.658.148-3";
            roberta.Salario = 5000;

            gerenciador.Registrar(roberta);

            Console.WriteLine("O {0} portador do CPF {1}, tem salário igual a: R$ {2}",carlos.Nome, carlos.CPF, carlos.Salario);
            Console.WriteLine($"A Bonificação do {carlos.Nome} é de: R$ {carlos.GetBonificacao()}");

            Console.WriteLine("O {0} portador do CPF {1}, tem salário igual a: R$ {2}",roberta.Nome, roberta.CPF, roberta.Salario);
            Console.WriteLine($"A Bonificação do {roberta.Nome} é de: R$ {roberta.GetBonificacao()}");

            Console.WriteLine("*****************************************");
            Console.WriteLine("Total de Bonificações: R$ {0}", gerenciador.GetTotalBonificacao());

        }
    }
}
