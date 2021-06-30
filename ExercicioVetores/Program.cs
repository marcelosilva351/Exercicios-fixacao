using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] quartos = new Quarto[9];

            Console.WriteLine("Quantos alunos vão se hospedar?");
            int quantidadeAlunos = int.Parse(Console.ReadLine());


            for (int i = 0; i < quantidadeAlunos; i++)
            {
                Console.WriteLine("Nome aluno: ");
                string alunoNome = Console.ReadLine();
                Console.WriteLine("Numero do quarto: 0 a 9");
                int numeroQuarto = int.Parse(Console.ReadLine());

                if (numeroQuarto > 9)
                {
                    Console.WriteLine("esse quarto não existe");
                    i--;
                    continue;

                }

                else if (quartos[numeroQuarto] != null)
                {
                    Console.WriteLine("Quarto ja está ocupado");
                    i--;
                    continue;
                }
             
                Aluno aluno = new Aluno(alunoNome);
                quartos[numeroQuarto] = new Quarto(numeroQuarto, aluno, true, DateTime.Now);
            }


            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < quartos.Length; i++)
            {
                if(quartos[i] != null)
                {
                    Console.WriteLine($"Aluno: {quartos[i].Aluno.Nome}, Quarto: {quartos[i].Numero}, Reservado em: {quartos[i].DataReserva}");
                }
            }


            Console.ReadLine();
        }
    }
}
