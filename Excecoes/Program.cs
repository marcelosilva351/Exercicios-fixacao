using System;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero do quarto: ");
            int numeroQuarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Data de entrada: ");
            DateTime dataEntrada = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Data saida: ");
            DateTime dataSaida = DateTime.Parse(Console.ReadLine());

            try
            {
                Reserva reserva = new Reserva(numeroQuarto, dataEntrada, dataSaida);

                Console.WriteLine("Dados reserva: ");
                Console.WriteLine($"Quarto: {reserva.NumeroQuarto}, Data entrada: {reserva.DataEntrada.ToString("dd/MM/yyyy")}, Data saida: {reserva.DataSaida.ToString("dd/MM/yyyy")}");

                Console.WriteLine("Nova data de entrada: ");
                DateTime dataEntradaUpdate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Nova entrada de saida: ");
                DateTime dataSaidaUpdate = DateTime.Parse(Console.ReadLine());

                reserva.UpdateData(dataEntradaUpdate, dataSaidaUpdate);

                Console.WriteLine($"Quarto: {reserva.NumeroQuarto}, Data entrada: {reserva.DataEntrada.ToString("dd/MM/yyyy")}, Data saida: {reserva.DataSaida.ToString("dd/MM/yyyy")}");


            }
            catch (ReservaException e)
            {
                Console.WriteLine(e.Message) ;
            }catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
