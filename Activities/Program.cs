using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static double MinutToSecond(int minuts)
        {
            return minuts * 60;
        }

        public static void Main()
        {
            const string PrimerMissatge = "Introdueix quants minuts vols passar a segons: ";
            const string MissatgeResultat = "{0} minuts són {1} segons";
            const string MissatgeError = "Format incorrecte";

            int numUser;

            Console.Write(PrimerMissatge);
            try
            {
                numUser = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(MissatgeResultat, numUser, MinutToSecond(numUser));
            }
            catch (FormatException)
            {
                Console.WriteLine(MissatgeError);
            }
        }
    }
}