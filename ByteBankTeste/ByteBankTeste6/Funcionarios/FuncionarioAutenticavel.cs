using ByteBankTeste6.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankTeste6.Funcionarios
{
    public class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
