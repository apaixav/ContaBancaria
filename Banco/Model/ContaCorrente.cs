using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    public class ContaCorrente : Conta
    {
        private decimal limite;
        public ContaCorrente(int id, int agencia, int tipo, string titular, decimal saldo, decimal limite)
            : base(id, agencia, tipo, titular, saldo)
        {
            this.limite = limite;
        }

        public decimal GetLimite() 
        {           
            return this.limite; 
        }
        public void SetLimite(decimal limite)
        {
            this.limite=limite;
        }
        public override bool Sacar(decimal valor)
        {
            if (this.GetSaldo() + this.limite < valor)
            {
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }

            this.SetSaldo(this.GetSaldo() - valor);
            return true;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Limite da Conta: {this.limite}");
        }
    }
}
