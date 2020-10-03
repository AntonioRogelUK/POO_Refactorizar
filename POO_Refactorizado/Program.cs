using System;

namespace POO_Refactorizado
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("juan", new DateTime(1980, 10, 19));
            Persona persona2 = new Persona("manuel", new DateTime(1983, 12, 22));
            Persona persona3 = new Persona("abraham", new DateTime(1992, 11, 01));
            Persona persona4 = new Persona("ramon", new DateTime(1988, 09, 15));
            Persona persona5 = new Persona("ricardo", new DateTime(1974, 04, 8));
            Persona persona6 = new Persona("hugo", new DateTime(1980, 4, 3));
            Persona persona7 = new Persona("jose", new DateTime(1983, 2, 1));
            Persona persona8 = new Persona("MIGUEL", new DateTime(1980, 2, 1));

            persona1.Imprime();
            persona2.Imprime();
            persona3.Imprime();
            persona4.Imprime();
            persona5.Imprime();
            persona6.Imprime();
            persona7.Imprime();
            persona8.Imprime();
        }
    }
}
