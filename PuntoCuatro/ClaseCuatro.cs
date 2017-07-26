using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoCuatro
{
    public class ClaseCuatro
    {
        public double numero;

        public double Numero {

            set {
                if (value > 0)
                    this.numero = value;
                else
                    throw new Exception("Es un número negativo");
            }
        }
    }
}
