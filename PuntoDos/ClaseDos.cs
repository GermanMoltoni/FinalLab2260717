using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDos
{
    public class ClaseDos
    {
        public static int numero;
        static ClaseDos(){
            numero = 0;
        }
        public ClaseDos() { }
        public ClaseDos(int num):this()
        {
            numero = num;
        }
    }
}
