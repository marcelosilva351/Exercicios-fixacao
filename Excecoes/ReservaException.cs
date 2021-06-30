using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    class ReservaException : ApplicationException
    {
        public ReservaException()
        {
        }

        public ReservaException(string message) : base(message)
        {
        }

        public ReservaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ReservaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
