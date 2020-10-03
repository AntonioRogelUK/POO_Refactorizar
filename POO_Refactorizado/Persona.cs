using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Refactorizado
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;

        public string Nombre { get { return nombre; } }
        public DateTime FechaNacimiento { get { return fechaNacimiento; } }
        public int Edad { get { return CalcularEdad(); } }

        public Persona(string nombre, DateTime fechaNacimiento)
        {
            if (nombre.Length > 1)
            {
                this.nombre = $"{nombre.Substring(0, 1).ToUpper()}{nombre.Substring(1).ToLower()}";
            }
            else
            {
                this.nombre = nombre.ToUpper();
            }

            this.fechaNacimiento = fechaNacimiento;
        }

        private int CalcularEdad()
        {
            int EdadPersona = DateTime.Now.Year - fechaNacimiento.Year;
            if (DateTime.Now.Month == fechaNacimiento.Month)
            {
                if (DateTime.Now.Day < fechaNacimiento.Day)
                {
                    EdadPersona--;
                }
            }
            else if (DateTime.Now.Month < fechaNacimiento.Month)
            {
                EdadPersona--;
            }
            return EdadPersona;
        }

        public void Imprime()
        {
            Console.WriteLine($"{Nombre} tiene {Edad} años, su fecha de nacimiento es {fechaNacimiento.ToString("dd/MM/yyyy")}");
        }
    }
}