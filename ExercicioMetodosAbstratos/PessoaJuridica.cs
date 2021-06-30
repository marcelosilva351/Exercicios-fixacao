using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMetodosAbstratos
{
    class PessoaJuridica : Pessoa
    {
        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroDeFuncionarios = numeroFuncionarios;
        }

        public override double CalculaImposto()
        {
            double imposto = RendaAnual * 0.16;
            if(NumeroDeFuncionarios >= 10)
            {
                imposto = RendaAnual * 0.14;
            }

            return imposto;
        }

        public override string ToString()
        {
            return base.ToString() + $", Quantidade de funcionarios: {NumeroDeFuncionarios}, Imposto: {CalculaImposto()}";
        }
    }
}
