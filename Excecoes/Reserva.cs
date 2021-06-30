using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    class Reserva
    {
        public int NumeroQuarto { get; private set; }

        private DateTime _dataEntrada;
        public DateTime DataEntrada
        {
            get
            {
                return _dataEntrada;
            }
            set
            {
                if(value < DateTime.Now)
                {
                    throw new ReservaException("Não é possivel uma data do passado");
                }
                _dataEntrada = value;

            }

        }

        private DateTime _dataSaida;
        public DateTime DataSaida
        {
            get
            {
                return _dataSaida;
            }
            set
            {
                if (value < DataEntrada)
                {
                    throw new ReservaException("Não é possivel uma data anterior a data de entrada");
                }

                _dataSaida = value;

            }

        }

        public Reserva(int numeroQuarto, DateTime dataEntrada, DateTime dataSaida)
        {
            NumeroQuarto = numeroQuarto;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }

        public void UpdateData(DateTime dataEntrada, DateTime dataSaida)
        {
            
            if(dataEntrada < DataEntrada)
            {
                throw new ArgumentException("Não é possivel alterar a data para uma data passada");
            }

            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }
    }
}
