using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static (int, int) SeparateIntOfDecimals(double numUser)
        {
            int count = 0;
            
            return (count, count);
        }

        public static void Main()
        {
            const string PrimerMissatge = "Introdueix el valor: ";
            const string MissatgeFinal = "El teu valor té {0} decimals i {1} enter";
            const string MissatgeFinal2 = "La suma dels parells és {0} i la suma dels senars és {1}";

            const string MissatgeError = "Format incorrecte";

            double numUser;

            Console.Write(PrimerMissatge);
            try
            {
                numUser = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(MissatgeFinal + SeparateIntOfDecimals(numUser));

            }
            catch (FormatException)
            {
                Console.WriteLine(MissatgeError);
            }
        }
    }
}