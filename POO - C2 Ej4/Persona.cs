using System;
using System.Collections.Generic;
using System.Text;

namespace POO___C2_Ej4
{
    class Persona
    {
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetNombre (string elnombre)
        {
           this.nombre = elnombre; 
        }

        public void Saludar()
        {
            System.Console.WriteLine("Hola, soy {0}", this.nombre);
        }
    }
}
