using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoUno;
using PuntoDos;
using PuntoTres;
using PuntoCuatro;
using PuntoSiete;
namespace FinalLab2Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Punto Uno");
            Console.WriteLine("Numeros A:4 B:5 C:3");
            Console.WriteLine(ClaseUno.VerificarNumero(4,5,3));
            Console.WriteLine("Numeros A:1 B:2 C:3");
            Console.WriteLine(ClaseUno.VerificarNumero(1, 2, 3));
            Console.WriteLine("Numeros A:1 B:0 C:3");
            Console.WriteLine(ClaseUno.VerificarNumero(1, 0, 3));
            Console.WriteLine("Punto Dos");
            ClaseDos c = new ClaseDos();
            Console.WriteLine("Inicia Atributo estatico:"+ClaseDos.numero);
            c = new ClaseDos(3);

            Console.WriteLine("Modifico numero con constructor de instancia:" + ClaseDos.numero);

            Console.WriteLine("Punto Tres");
            ProdImpuesto ProUno = (ProdImpuesto)"coca cola";
            Console.WriteLine("Nombre Producto: "+ProUno.nombre);
            Console.WriteLine("Punto Cuatro");
            ClaseCuatro c4 = new ClaseCuatro();
            c4.Numero = 5;
            Console.WriteLine("Numero: " + c4.numero);
            Console.WriteLine("Punto Cinco");

            try
            {
                ClaseCuatro c5 = new ClaseCuatro();
                c5.Numero = -5;


            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            
            }
            Console.WriteLine("Punto Siete");
            if (Deposito.GuardarXML((IGuardar)ProUno))
                Console.WriteLine("Se pudo serializar");
            else
                Console.WriteLine("Error al  serializar");

            Console.Read();

        }
    }
}
