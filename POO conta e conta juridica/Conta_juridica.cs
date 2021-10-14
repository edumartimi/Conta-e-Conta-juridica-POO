using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace POO_conta_e_conta_juridica
{
    class Conta_juridica:Conta
    {
        public double EmprestimoLimite { get; set; }

        //Criação do construtor padrão
        public Conta_juridica() { }

        public Conta_juridica(int numero, string titular, double saldo, double emprestimoLimite): base(numero, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }

        public void Emprestimo(double saldoTotal)
        {
            if (saldoTotal <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }


    }
}
