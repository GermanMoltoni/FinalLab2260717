using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoUno
{
    public class ClaseUno
    {
        public static Double VerificarNumero(Double A, Double B, Double C) { 
            if(A>B && A<C)
                return A;
            if(B>A && B<C)
                return B;
            return C;


        
        
        }

    }
}
