using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    public class ContaPoupanca : Conta
    {
        private int aniversario;

        public ContaPoupanca(int id, int agencia, int tipo, string titular, decimal saldo,int aniversario) 
            : base(id, agencia, tipo, titular, saldo)
        {

            this.aniversario = aniversario;
        }

        public int GetAniversario()
        {
            return aniversario;
        }

        public void SetAniversario(int aniversario)
        {
            this.aniversario = aniversario;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Aniversário da Conta: dia {this.aniversario}");
        }
    }
}
