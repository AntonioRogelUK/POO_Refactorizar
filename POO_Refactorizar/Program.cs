using System;

namespace POO_Refactorizar
{
    class Program
    {
        static void Main(string[] args)
        {
            string NombrePersona1 = "Juan";
            DateTime fechaNacimientoPersona1 = new DateTime(1980, 10, 19);

            string NombrePersona2 = "manuel";
            DateTime fechaNacimientoPersona2 = new DateTime(1983, 12, 22);

            string NombrePersona3 = "abraham";
            DateTime fechaNacimientoPersona3 = new DateTime(1992, 11, 01);

            string NombrePersona4 = "ramon";
            DateTime fechaNacimientoPersona4 = new DateTime(1988, 09, 15);

            string NombrePersona5 = "ricardo";
            DateTime fechaNacimientoPersona5 = new DateTime(1974, 04, 08);

            string NombrePersona6 = "hugo";
            DateTime fechaNacimientoPersona6 = new DateTime(1980, 04, 03);

            string NombrePersona7 = "jose";
            DateTime fechaNacimientoPersona7 = new DateTime(1983, 02, 01);

            string NombrePersona8 = "MIGUEL";
            DateTime fechaNacimientoPersona8 = new DateTime(1980, 02, 01);


            NombrePersona1 = NombrePersona1.Substring(0, 1).ToUpper() + NombrePersona1.Substring(1);
            int EdadPersona1 = DateTime.Now.Year - fechaNacimientoPersona1.Year;

            if (DateTime.Now.Month == fechaNacimientoPersona1.Month)
            {
                if (DateTime.Now.Day < fechaNacimientoPersona1.Day)
                {
                    EdadPersona1--;
                }
            }
            else if (DateTime.Now.Month < fechaNacimientoPersona1.Month)
            {
                EdadPersona1--;
            }

            NombrePersona2 = NombrePersona2.Substring(0, 1).ToUpper() + NombrePersona2.Substring(1);
            int EdadPersona2 = DateTime.Now.Year - fechaNacimientoPersona2.Year;

            if (DateTime.Now.Month == fechaNacimientoPersona2.Month)
            {
                if (DateTime.Now.Day < fechaNacimientoPersona2.Day)
                {
                    EdadPersona2--;
                }
            }
            else if (DateTime.Now.Month < fechaNacimientoPersona2.Month)
            {
                EdadPersona2--;
            }

            NombrePersona3 = NombrePersona3.Substring(0, 1).ToUpper() + NombrePersona3.Substring(1);
            int EdadPersona3 = DateTime.Now.Year - fechaNacimientoPersona3.Year;

            if (DateTime.Now.Month == fechaNacimientoPersona3.Month)
            {
                if (DateTime.Now.Day < fechaNacimientoPersona3.Day)
                {
                    EdadPersona3--;
                }
            }
            else if (DateTime.Now.Month < fechaNacimientoPersona3.Month)
            {
                EdadPersona3--;
            }


            NombrePersona4 = NombrePersona4.Substring(0, 1).ToUpper() + NombrePersona4.Substring(1);
            int EdadPersona4 = DateTime.Now.Year - fechaNacimientoPersona4.Year;

            if (DateTime.Now.Month == fechaNacimientoPersona4.Month)
            {
                if (DateTime.Now.Day < fechaNacimientoPersona4.Day)
                {
                    EdadPersona4--;
                }
            }
            else if (DateTime.Now.Month < fechaNacimientoPersona4.Month)
            {
                EdadPersona4--;
            }

            NombrePersona5 = NombrePersona5.Substring(0, 1).ToUpper() + NombrePersona5.Substring(1);
            int EdadPersona5 = DateTime.Now.Year - fechaNacimientoPersona5.Year;

            if (DateTime.Now.Month == fechaNacimientoPersona5.Month)
            {
                if (DateTime.Now.Day < fechaNacimientoPersona5.Day)
                {
                    EdadPersona5--;
                }
            }
            else if (DateTime.Now.Month < fechaNacimientoPersona5.Month)
            {
                EdadPersona5--;
            }

            NombrePersona6 = NombrePersona6.Substring(0, 1).ToUpper() + NombrePersona6.Substring(1);
            int EdadPersona6 = DateTime.Now.Year - fechaNacimientoPersona6.Year;

            if (DateTime.Now.Month == fechaNacimientoPersona6.Month)
            {
                if (DateTime.Now.Day < fechaNacimientoPersona6.Day)
                {
                    EdadPersona6--;
                }
            }
            else if (DateTime.Now.Month < fechaNacimientoPersona6.Month)
            {
                EdadPersona6--;
            }

            NombrePersona7 = NombrePersona7.Substring(0, 1).ToUpper() + NombrePersona7.Substring(1);
            int EdadPersona7 = DateTime.Now.Year - fechaNacimientoPersona7.Year;

            if (DateTime.Now.Month == fechaNacimientoPersona7.Month)
            {
                if (DateTime.Now.Day < fechaNacimientoPersona7.Day)
                {
                    EdadPersona7--;
                }
            }
            else if (DateTime.Now.Month < fechaNacimientoPersona7.Month)
            {
                EdadPersona7--;
            }

            NombrePersona8 = NombrePersona8.Substring(0, 1).ToUpper() + NombrePersona8.Substring(1);
            int EdadPersona8 = DateTime.Now.Year - fechaNacimientoPersona8.Year;

            if (DateTime.Now.Month == fechaNacimientoPersona8.Month)
            {
                if (DateTime.Now.Day < fechaNacimientoPersona8.Day)
                {
                    EdadPersona8--;
                }
            }
            else if (DateTime.Now.Month < fechaNacimientoPersona8.Month)
            {
                EdadPersona8--;
            }

            Console.WriteLine($"{NombrePersona1} Tiene {EdadPersona1} años, su fecha de nacimiento es {fechaNacimientoPersona1:dd/MM/yyyy}");
            Console.WriteLine($"{NombrePersona2} Tiene {EdadPersona2} años, su fecha de nacimiento es {fechaNacimientoPersona2:dd/MM/yyyy}");
            Console.WriteLine($"{NombrePersona3} Tiene {EdadPersona3} años, su fecha de nacimiento es {fechaNacimientoPersona3:dd/MM/yyyy}");
            Console.WriteLine($"{NombrePersona4} Tiene {EdadPersona4} años, su fecha de nacimiento es {fechaNacimientoPersona4:dd/MM/yyyy}");
            Console.WriteLine($"{NombrePersona5} Tiene {EdadPersona5} años, su fecha de nacimiento es {fechaNacimientoPersona5:dd/MM/yyyy}");
            Console.WriteLine($"{NombrePersona6} Tiene {EdadPersona6} años, su fecha de nacimiento es {fechaNacimientoPersona6:dd/MM/yyyy}");
            Console.WriteLine($"{NombrePersona7} Tiene {EdadPersona7} años, su fecha de nacimiento es {fechaNacimientoPersona7:dd/MM/yyyy}");
            Console.WriteLine($"{NombrePersona8} Tiene {EdadPersona8} años, su fecha de nacimiento es {fechaNacimientoPersona8:dd/MM/yyyy}");

            Console.ReadKey();
        }
    }
}
