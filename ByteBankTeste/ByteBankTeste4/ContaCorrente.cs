using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankTeste4
{
    public class ContaCorrente
    {
        private Cliente _titular;
        public Cliente Titular { get; set; }

        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100;
        /* Todos os Objetos privados precisam ser setados com underline na frente.         * 
         * O método utilizado para ser possível utilizar o saldo, que está como 'private'
         * é chamado de encapsulamento.
         */


        public double Saldo 
        {
            get
            {
                return _saldo
            }
            set
            {
                if (value < 0)
            }

        //public void DefinirSaldo(double saldo)
        //{
        //    if (saldo < 0)
        //    {
        //        return;
        //    }

        //    this.saldo = saldo; // 'this.' serve p/ referencia para o objeto que está chamando.
        //}

        //public double ObterSaldo()
        //{
        //    return saldo;
        //}

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }            
            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
