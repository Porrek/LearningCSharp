using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankTeste3
{
    class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;      

        /*toda função começa com a primeira letra maiuscula,
         * e toda função tem o verbo no infinitido.
         */

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }            
            this.saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
