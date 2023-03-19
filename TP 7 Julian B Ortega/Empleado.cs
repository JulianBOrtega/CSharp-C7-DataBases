using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_7_Julian_B_Ortega
{
    class Empleado
    {
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public int Edad { get; set; }
        public bool Casado { get; set; }
        public float Salario { get; set; }

        public Empleado(string nombre, int dni, int edad, bool casado, float salario)
        {
            Nombre = nombre;
            DNI = dni;
            Edad = edad;
            Casado = casado;
            Salario = salario;
        }
    }
}
