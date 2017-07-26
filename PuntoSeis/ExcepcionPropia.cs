using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoSeis
{
    class ExcepcionPropia:Exception
    {
        public ExcepcionPropia(string message) : base(message) { }
    }
}
