using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMetodosAbstratos
{
    class PessoaFisica : Pessoa
    {
       public double GastosComSaude { get; set; }

       public PessoaFisica(string nome, double rendaAnual, double gastosComSaude) : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;

        }

        public override double CalculaImposto()
        {
            double imposto = 0;
            if(RendaAnual < 20000)
            {
                imposto = RendaAnual * 0.15;
            }
            else
            {

                imposto = RendaAnual * 0.25;
            }

            if(GastosComSaude > 0)
            {
                imposto = imposto - (GastosComSaude * 0.50);
            }

            return imposto;
        }

        public override string ToString()
        {
            return base.ToString() + $", Gastos com saude: {GastosComSaude}, imposto:{CalculaImposto()}";
        }
    }
}
