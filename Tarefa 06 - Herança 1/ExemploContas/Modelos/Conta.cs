using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploContas.Modelos
{
    abstract class Conta
    {
        public string Correntista { get; set; }
        public int Num { get; set; }
        public abstract double SaldoDisponivel { get; }
        // como o saldodisponivel é apenas para leitura usamos apenas o get
        public double saldo;
        
        public virtual void Creditar(double valor)
        {
            this.saldo += valor;
        }

        public virtual void Debitar(double valor)
        {
            if ((SaldoDisponivel - valor) < 0)
                throw new Exception($"Saldo insuficiente na conta {this.Num} para debitar {valor}");
            // throw new exception ---> exceçoes para indicar erros em tempo de execução. Usamos para reportar um erro por mensg sem ser no program por isso é uma exceção.
        }
    }
}
