using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
namespace PuntoTres
{
    public class ProdImpuesto:IGuardar
    {
        public string nombre;
        public ProdImpuesto() { }
        private ProdImpuesto(string nombreProducto):this()
        {
            this.nombre = nombreProducto;
        }
        public static explicit operator ProdImpuesto(string nombre) {
            return new ProdImpuesto(nombre);
        }
        bool IGuardar.Serializar()
        {
            try{

                XmlTextWriter writer = new XmlTextWriter("archivo.xml", System.Text.Encoding.UTF8);
            
                XmlSerializer serial = new XmlSerializer(typeof(ProdImpuesto));
                serial.Serialize(writer, this);
                return true;
            }
            catch(Exception e){
                return false;
            }
            

        }
    }
}
