using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //para Constructor 1
            Contacto contacto1 = new Contacto();

            contacto1.Nombre = "Jose";
            contacto1.Celular = "(644) 1 23 45 67 ";
            contacto1.Correo = "joseelmasguapo@hotmail.com";
            //Fin del Constructor 1

            Console.WriteLine("Contacto 1: ");
            Console.WriteLine("Nombre: " + contacto1.Nombre);
            Console.WriteLine("Celular: " + contacto1.Celular);
            Console.WriteLine("Correo: " + contacto1.Correo);
            Console.WriteLine("Direccion: " + contacto1.Direccion);


            //para Constructor 2
            Contacto contacto2 = new Contacto("Juan", "juan@correo.com");
            //Fin del constructor 2

            Console.WriteLine("Contacto 2: ");
            Console.WriteLine("Nombre: " + contacto2.Nombre);
            Console.WriteLine("Celular: " + contacto2.Celular);
            Console.WriteLine("Correo: " + contacto2.Correo);
            Console.WriteLine("Direccion: " + contacto2.Direccion);


            Console.Read();
        } 
    }
}
