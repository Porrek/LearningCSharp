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
            UsarSistema();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("833.222.048-39");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeContas camila = new GerenteDeContas("833.222.048-39");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
            sistemaInterno.Logar(parceiro, "123456");

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
