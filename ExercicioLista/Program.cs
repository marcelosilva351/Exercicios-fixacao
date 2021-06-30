using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.WriteLine("Adicionar quantos funcionarios?");
            int quantidadeFuncionarios = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidadeFuncionarios; i++)
            {
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario: ");
                double salario = double.Parse(Console.ReadLine());

                funcionarios.Add(new Funcionario(id, nome, salario));
            }

            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }

            Console.Write("Id do funcionario que deseja aumentar o salario: ");
            int idAumentarSalario = int.Parse(Console.ReadLine());

            foreach (Funcionario funcionario in funcionarios )
            {
                if(funcionario.Id == idAumentarSalario)
                {
                    Console.WriteLine("Digite a porcentagem: ");
                    int porcentagem = int.Parse(Console.ReadLine());
                    funcionario.AumentarSalario(porcentagem);
                }
            }


            Console.WriteLine("Lista atualizada");

            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario) ;

            }
            Console.ReadLine();
        }
    }
}
