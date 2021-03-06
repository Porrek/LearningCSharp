﻿using ByteBankTeste6.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankTeste6.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando GERENTE DE CONTAS");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
