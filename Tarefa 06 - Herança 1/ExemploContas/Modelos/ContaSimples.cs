using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploContas.Modelos
{
    class ContaSimples : Conta
    {
        

        public override void Debitar(double valor)
        {
            base.Debitar(valor);
            this.saldo -= valor;
        }

        public override void Creditar(double valor)
        {
            base.Creditar(valor);
        }

        public override double SaldoDisponivel => this.saldo;

      
    }
}
