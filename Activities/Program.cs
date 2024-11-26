using System;
using System.Runtime.CompilerServices;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static bool IsOverZero(int number)
        {
            return number > 0;
        }

        public static double[] SortArrayAscendent(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        double aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }
            return array;
        }

        public static void PrintArray(double[] array)
        {
            const string Message = "Your temperatures are: ";

            Console.Write(Message);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static bool SearchNumber(double[] array, double numberToFind)
        {
            bool found = false;
            int i = 0;

            while ((i < array.Length) && (!found)) 
            { 
                if (array[i] == numberToFind) found = true;
                i++;
            }

            return found;
        }

        public static void Main()
        {
            // Constants and variables
            const string WelcomeMessage = "How many temperatures do you want to store? ";
            const string IntroduceNumbersMessage = "Now, write the temperature in the position {0}: ";
            const string FindNumberMessage = "Which number do you want to find? ";

            const string FoundNumberMessage = "The number {0} is in the array.";
            const string NotFoundNumberMessage = "The number {0} is not in the array.";

            const string FormatExceptionMessage = "Incorrect format. Try again";
            const string OverflowExceptionMessage = "Too long value. Try again";
            const string GeneralExceptionMessage = "Not known exception. Try again";

            int numUser = 0;
            double temperature = 0, numToFind = 0;

            //Main program
            do
            {
                try
                {
                    Console.Write(WelcomeMessage);
                    numUser = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine(FormatExceptionMessage);
                }
                catch (OverflowException)
                {
                    Console.WriteLine(OverflowExceptionMessage);
                }
                catch (Exception)
                {
                    Console.WriteLine(GeneralExceptionMessage);
                }
            } while (!IsOverZero(numUser));
            
            double[] arrayTemperatures = new double[numUser];

            for (int i = 0; i < arrayTemperatures.Length; i++)
            {
                bool isValid = false;
                do
                {
                    try
                    {
                        Console.Write(IntroduceNumbersMessage, i + 1);
                        temperature = Convert.ToDouble(Console.ReadLine());
                        isValid = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(FormatExceptionMessage);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(GeneralExceptionMessage);
                    }
                } while (!isValid);
                arrayTemperatures[i] = temperature;
            }

            arrayTemperatures = SortArrayAscendent(arrayTemperatures);
            PrintArray(arrayTemperatures);
             
            bool isInputValid = false;
            do
            {
              
                try
                {
                    Console.Write(FindNumberMessage);
                    numToFind = Convert.ToDouble(Console.ReadLine());
                    isInputValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine(FormatExceptionMessage);
                }
                catch (Exception)
                {
                    Console.WriteLine(GeneralExceptionMessage);
                }
            } while (!isInputValid);

            Console.WriteLine();

            bool isNumberFound = SearchNumber(arrayTemperatures, numToFind);
            if (isNumberFound) {
                Console.WriteLine(FoundNumberMessage, numToFind);
            } else
            {
                Console.WriteLine(NotFoundNumberMessage, numToFind);
            }



        }
    }
}