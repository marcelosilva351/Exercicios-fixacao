using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetores
{
    class Quarto
    {
        public int Numero { get; set; }
        public Aluno Aluno { get; set; }
        public bool Ocupado { get; set; }

        public DateTime DataReserva { get; set; }

        public Quarto(int numero, Aluno aluno, bool ocupado, DateTime dataReserva)
        {
            Numero = numero;
            Aluno = aluno;
            Ocupado = ocupado;
            DataReserva = dataReserva;
        }

        public override string ToString()
        {
            return $"Aluno: {Aluno}, Quarto: {Numero}, Reservado em: {DataReserva}";
        }
    }
}
