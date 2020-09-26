using ByteBankTeste6.Funcionarios;
using ByteBankTeste6.Sistemas;
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
            //CalcularBonificacao();
            //Console.WriteLine();

            //GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            //Funcionario carlos = new Funcionario(2000, "546.879.157-20");

            //carlos.Nome = "Carlos";

            //carlos.AumentarSalario();
            //Console.WriteLine("Salário Carlos Com Aumento: " + carlos.Salario);

            //gerenciador.Registrar(carlos);

            //Diretor roberta = new Diretor(5000, "454.658.148-3");
            //roberta.Nome = "Roberta";

            //roberta.AumentarSalario();
            //Console.WriteLine("Salário Roberta Com Aumento: " + roberta.Salario);

            //gerenciador.Registrar(roberta);

            //Console.WriteLine("O {0} portador do CPF {1}, tem salário igual a: R$ {2}",carlos.Nome, carlos.CPF, carlos.Salario);
            //Console.WriteLine($"A Bonificação do {carlos.Nome} é de: R$ {carlos.GetBonificacao()}");

            //Console.WriteLine("O {0} portador do CPF {1}, tem salário igual a: R$ {2}",roberta.Nome, roberta.CPF, roberta.Salario);
            //Console.WriteLine($"A Bonificação do {roberta.Nome} é de: R$ {roberta.GetBonificacao()}");

            //Console.WriteLine("*****************************************");
            //Console.WriteLine("Total de Bonificações: R$ {0}", gerenciador.GetTotalBonificacao());

            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("833.222.048-39");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeContas camila = new GerenteDeContas("833.222.048-39");
            camila.Nome = "Camila";
            roberta.Senha = "abc";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("833.222.048-39");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("833.222.048-39");
            igor.Nome = "Igor";

            GerenteDeContas camila = new GerenteDeContas("833.222.048-39");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de Bonificações do Mês: " + gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}
