using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da conta - ");
            Console.Write("Numero: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Titular:" );
            string titularConta = Console.ReadLine();
            Console.Write("Saldo inicial: R$");
            double saldoInicialConta = double.Parse(Console.ReadLine());
            Console.Write("Limite de saque: R$");
            double limiteSaqueConta = double.Parse(Console.ReadLine());
            Conta conta = new Conta(numeroConta,titularConta,saldoInicialConta,limiteSaqueConta);
            Console.WriteLine("CONTA: ");

            Console.WriteLine("Valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine());
            try
            {
                conta.Sacar(valorSaque);
            }catch(SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Novo saldo: " +conta.Saldo);

            Console.ReadLine();
        }
    }
}
