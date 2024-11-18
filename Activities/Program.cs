using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static double CelsiusToFarenheit(double temperature)
        {
            return (1.8 * temperature) + 32;
        }

        public static void Main()
        {
            const string PrimerMissatge = "Introdueix la temperatura en Celsius (Cº): ";
            const string MissatgeResultat = "La teva temperatura en Farenheit és";
            const string MissatgeError = "Format incorrecte";

            double numUser;

            Console.Write(PrimerMissatge);
            try
            {
                numUser = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{MissatgeResultat} {CelsiusToFarenheit(numUser)}");
            }
            catch (FormatException)
            {
                Console.WriteLine(MissatgeError);
            }
        }
    }
}