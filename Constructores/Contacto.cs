using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        //Los constructores siempre llevan el nombre de la clase
        public Contacto()
        {
            Nombre = "Sin nombre";
            Celular = "Sin celular";
            Telefono = "Sin telefono";
            Correo = "Sin correo";
            Direccion = "Sin direccion";

        }

        //Constructor con Parametros
        public Contacto(string nombre, string correo)
        {
            //Variable=Parametro
            Nombre = nombre;
            Correo = correo;
            Celular = "Sin celular";
            Telefono = "Sin telefono";
            Direccion = "Sin direccion";


        }

        //No se puede hacer otro constructor que tenga dos strings porque ya esta arriba, tienen que ser mas
        public Contacto(string nombre, string celular, string telefono, string correo, string direccion)
        {

        }



    }
}
