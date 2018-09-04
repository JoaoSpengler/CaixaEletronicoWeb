using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Deposito
    {
        public int SaldoTotal { get; set; }

        public bool VerificaSaldo(int ValorSaque)//Esse método vai ser chamado pelo Saque
        {
            if (ValorSaque <= SaldoTotal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int AtualizaSaldo(int ValorSaque)//Esse método vai ser chamado pelo Saque
        {
            SaldoTotal -= ValorSaque;

            return SaldoTotal;
        }

        public int AcrescentaSaldo(int ValorDeposito)//Esse método vai ser chamado pelo Deposito
        {
            SaldoTotal += ValorDeposito;

            return SaldoTotal;
        }
    }
}