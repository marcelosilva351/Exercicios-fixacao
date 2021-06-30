using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao
{
    class Conta
    {
        public int Numero { get; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public double LimiteDeSaque { get; private set; }

        public Conta(int numero, string titular, double saldo,  double limiteDeSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteDeSaque = limiteDeSaque;
        }

        public void Sacar(double valorSaque)
        {
            if(valorSaque > Saldo)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente");
            }
            if (valorSaque > LimiteDeSaque)
            {
                throw new ArgumentOutOfRangeException("Tentativa de saque maior que o limite de saque");
            }

            Saldo -= valorSaque;
        }

        public void Depositar(double valorDeposito)
        {
            
            Saldo += valorDeposito;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
