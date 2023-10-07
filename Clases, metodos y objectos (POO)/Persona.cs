using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Clases__metodos_y_objectos__POO_
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private string fechaNacimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public void crearPersona(string _nombre, int _edad, string _fechaNacimiento)
        {
            nombre = _nombre;
            this.edad = _edad;
            fechaNacimiento = _fechaNacimiento;
        }
    }
}
