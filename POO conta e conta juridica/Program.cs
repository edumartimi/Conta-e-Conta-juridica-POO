using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace POO_conta_e_conta_juridica
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta_juridica conta = new Conta_juridica(8010, "LaraCroft", 100.0, 500.0);
            Console.WriteLine(conta.Saldo);
        }
    }

}
