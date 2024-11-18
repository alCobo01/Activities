using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static int CountNumbers(int number, ref int even, ref int odd)
        {
            int count = 0, shift = 0;
            while (number > 0)
            {
                shift = number % 10;
                number = number / 10;
                count++;
                if (shift % 2 == 0)
                {
                    even += shift;
                }
                else
                {
                    odd += shift;
                }
            }
            return count;
        }

        public static void Main()
        {
            const string PrimerMissatge = "Introdueix el valor: ";
            const string MissatgeFinal = "Els teus valor té {0} xifres.";
            const string MissatgeFinal2 = "La suma dels parells és {0} i la suma dels senars és {1}";

            const string MissatgeError = "Format incorrecte";

            int numUser, even = 0, odd = 0;

            Console.Write(PrimerMissatge);
            try
            {
                numUser = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(MissatgeFinal, CountNumbers(numUser, ref even, ref odd));
                Console.WriteLine(MissatgeFinal2, even, odd);
            }
            catch (FormatException)
            {
                Console.WriteLine(MissatgeError);
            }
        }
    }
}