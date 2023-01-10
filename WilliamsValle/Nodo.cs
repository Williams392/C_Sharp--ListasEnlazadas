using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilliamsValle
{
    internal class Nodo
    {
        // Declarando La Estructura que va Acontener Nuestra Lista:

        private String dato;    // una Propiedad
        private Nodo sgte;   // Apuntador
        private Nodo ant;

        // Declarando una Funcion
        public String Dato
        {
            get { return dato; }  // get -> leer los Datos
            set { dato = value; } // set -> ingresar los Datos
        }

        public Nodo Sgte
        {
            get { return sgte; }
            set { sgte = value; }
        }

        public Nodo Ant
        {
            get { return ant; }
            set { ant = value; }
        }
    }
}
