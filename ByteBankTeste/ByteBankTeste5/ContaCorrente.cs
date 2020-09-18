using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankTeste5
{
    public class ContaCorrente
    {
        private Cliente _titular;
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        /* static é uma propriedade que pertence a classe, 
         * todos os objetos compartilham essa informação.
         * O set estando como 'private' não deixa com que se mude o valor das propriedades.
         */
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100;
        public double Saldo { get; set; }


        /* O Construtor abaixo gera uma dependencia, pois agora fica prioritário apontar os valores
         * para as variáveis 'agencia' e 'numero' quando se instancia a classe ContaCorrente.
         */
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        }

        public ContaCorrente()
        {

        }

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
