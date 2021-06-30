using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Console.Write("Numero de pagadores de impostos: ");
            int quantidadePagadores = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < quantidadePagadores; i++)
            {
                Console.Write("Nome: ");
                string nomePessoa = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());
                Console.WriteLine("Pessoa fisica ou juridica: (f/j)");
                string decisaoPessoaFisicaJuridica = Console.ReadLine().ToLower();

                if(decisaoPessoaFisicaJuridica == "f")
                {
                    Console.WriteLine("Digite os gastos com saude: ");
                    double gastosComSaude = double.Parse(Console.ReadLine());
                    pessoas.Add(new PessoaFisica(nomePessoa, rendaAnual, gastosComSaude));
                }
                else if(decisaoPessoaFisicaJuridica == "j")
                {
                    Console.WriteLine("Digite o numero de funcionarios: ");
                    int quantidadeFuncionarios = int.Parse(Console.ReadLine());
                    pessoas.Add(new PessoaJuridica(nomePessoa, rendaAnual, quantidadeFuncionarios));
                }
            }

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
         
            }
            Console.ReadLine();
        
        }



    }
}
