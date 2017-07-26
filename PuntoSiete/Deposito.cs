using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoTres;
namespace PuntoSiete
{
    public class Deposito
    {
       
        public static bool GuardarXML(IGuardar productoAux) {

            return productoAux.Serializar();
        }

    }
}
