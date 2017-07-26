using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoSeis
{
    public class ClaseSeis
    {
        public int edad;
        public string nombre;
        public ClaseSeis(int num) {
            if(0 > num)
                throw new ExcepcionPropia("Es un numero Negativo");
            this.edad = num;
        }
        public ClaseSeis(int n,string nom) : this(n) {
            this.nombre = nom;

        }
        public ClaseSeis NuevaClase {
            get {
                try {
                    return new ClaseSeis(3);
                
                }
            
            }

        }
    }
}
