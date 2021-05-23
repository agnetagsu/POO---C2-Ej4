using System;

namespace POO___C2_Ej4
{
    class PruebaPersona
    {
        static void Main(string[] args)
        {
            Persona pers1 = new Persona("Cristina");
            Persona pers2 = new Persona("Carmen");

            pers1.Saludar();
            pers2.Saludar();
        }
    }
}
