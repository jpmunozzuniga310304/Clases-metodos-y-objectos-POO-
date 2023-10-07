using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases__metodos_y_objectos__POO_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona objPersona = new Persona();
            objPersona.crearPersona("Marko Robles", 20, "01-01-2000");

            Console.WriteLine("Nombre: " + objPersona.Nombre + " Edad: " + objPersona.Edad + " Fecha Nacimiento: " + objPersona.FechaNacimiento );
            Console.ReadLine();

        }
    }
}
