using System;
using System.Globalization;

namespace POO_conta_e_conta_juridica
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        //Utilização do protected para alteração de valores entre classes
        public double Saldo { get; protected set; }
        //Criação do construtor padrão e construtor com parâmetros
        public Conta() { }
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero; Titular = titular; Saldo = saldo;
        }

        public void Saque(double saldoTotal)
        {
            Saldo -= saldoTotal;
        }

        public void Deposito(double saldoTotal)
        {
            Saldo += saldoTotal;

        }
    }
}
