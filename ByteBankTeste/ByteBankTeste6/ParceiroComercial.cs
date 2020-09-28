using ByteBankTeste6.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankTeste6
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
