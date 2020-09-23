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
            Funcionario carlos = new Funcionario(1);

            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;

            Console.WriteLine("O {0} portador do CPF {1}, tem salário igual a: R$ {2}",carlos.Nome, carlos.CPF, carlos.Salario);

        }
    }
}
