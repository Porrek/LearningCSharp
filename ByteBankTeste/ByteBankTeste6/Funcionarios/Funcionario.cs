using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankTeste6.Funcionarios
{
    public class Funcionario
    {
        /* 0 - funcionpario não definido
         * 1 - Diretor
         * 2 - Designer
         * 3 - Gerente de conta corrente
         * N - ...
        */ 
        private int _tipo;

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }


        public double ObterBonificacao()
        {
            if (_tipo == 1)
            {
                return Salario;
            }
            return Salario * 0.10;
        }

    }
}
