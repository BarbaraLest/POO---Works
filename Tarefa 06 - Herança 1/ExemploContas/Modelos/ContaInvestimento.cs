using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploContas.Modelos
{
    class ContaInvestimento : Conta
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

       public double Investimento { get; set; }
       

        public double Rendimento(double investimento)
        {
            double rendimento;

            rendimento = investimento * 0.02;
            return rendimento;
        }
             

        public override double SaldoDisponivel => (this.saldo + Rendimento(Investimento));

       
    }
}

