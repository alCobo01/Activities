# T2- Activitats
## Exercici 1
```c#
//PRE: El valor que rebri serà un enter
public static bool IsNatural(int numUser)
{
    return numUser > 0; 
}
//CON: Retornarà un booleà depenent si és narutal o no.
```

## Exercici 2
```c#
//PRE:

//CON:
```

## Exercici 3
```c#
//PRE: El valor que rebri serà un enter
public static bool IsNegative(int numUser)
{
    return numUser < 0;
}
//CON: Retornarà un booleà depenent si és negatiu o no.
```

## Exercici 4 - Ampliat amb sobrecàrrega
```c#
//PRE: El valor que rebri serà un enter
using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static bool IsInRange(int numUser, int minRangeUser, int maxRangeUser)
        {
            return numUser > minRangeUser && numUser < maxRangeUser;
        }

        public static bool IsInRange(int numUser)
        {
             return numUser > 0 && numUser < 100;
        }

        public static void Main()
        {
            const string PrimerMissatge = "Introdueix un valor: ";
            const string SegonMissatge = "Introdueix el mínim del rang: ";
            const string TercerMissatge = "Introdueix el màxim del rang: ";
            const string MissatgeIsInRange = "El valor està dins del rang.";
            const string MissatgeNotInRange = "El valor no està dins del rang.";
            const string MissatgeError = "Format incorrecte";

            int numUser, minRangeUser, maxRangeUser;
  
            Console.Write(PrimerMissatge);
            try
            {
                numUser = Convert.ToInt32(Console.ReadLine());
                Console.Write(SegonMissatge);
                minRangeUser = Convert.ToInt32(Console.ReadLine()); 
                Console.Write(TercerMissatge);
                maxRangeUser = Convert.ToInt32(Console.ReadLine());
                if (IsInRange(numUser, minRangeUser, maxRangeUser)) {
                    Console.WriteLine(MissatgeIsInRange);
                } else
                {
                    Console.WriteLine(MissatgeNotInRange);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(MissatgeError);
            }
        }
    }
}
//CON: Retornarà un booleà depenent si és positiu i menor que 100, o no.
```


## Exercici 5
```c#
//PRE: El usuari introduirà un enter 
using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static bool IsNatural(int numUser)
        {
            if (numUser < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void Main()
        {
            const string PrimerMissatge = "Introdueix un valor: ";
            const string MissatgeNatural = "El valor introduït és natural.";
            const string MissatgeNoNatural = "El valor introduït no és natural. Torna a introduïr un altre nombre: ";
            const string MissatgeIntents = "Has superat el nombre d'intents.";
            const string MissatgeError = "Format incorrecte";

            int numUser, attempts = 0;
            bool isValid = false;


            Console.Write(PrimerMissatge);
            try
            {
                while (attempts < 3 && !isValid)
                {
                    numUser = Convert.ToInt32(Console.ReadLine());
                    if (IsNatural(numUser))
                    {
                        Console.WriteLine(MissatgeNatural);
                        isValid = true;
                    }
                    else if (attempts < 2)
                    {
                        Console.Write(MissatgeNoNatural);
                    }
                    attempts++;
                }
                if (attempts == 3)
                {
                    Console.WriteLine(MissatgeIntents);
                }
            }
            catch (Exception) { 
                Console.WriteLine(MissatgeError);
            }
        }
    }
}
//CON: El programa retornarà si és natural o no, amb tres intents per fer-ho.
``` 

## Exercici 6
```c#
//PRE: El usuari introduirà un nombre enter.
using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static int AbsolutNumber(int numUser)
        {
            return Math.Abs(numUser);
        }

        public static void Main()
        {
            const string PrimerMissatge = "Introdueix un valor: ";
            const string MissatgeError = "Format incorrecte";

            int numUser;

            Console.Write(PrimerMissatge);
            try
            {
                numUser = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"El valor absolut de {numUser} és {AbsolutNumber(numUser)}");
            }
            catch (Exception)
            {
                Console.WriteLine(MissatgeError);
            }
        }
    }
}
//CON: El programa retornarà el valor absolut del número introduït.
```

## Exercici 7
```c#
//PRE: El mètode rebrà una string
using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static string ChangeToLowerOrUpperCase(string userInput)
        {
            return userInput == userInput.ToLower() ? userInput.ToUpper() : userInput.ToLower();
        }

        public static void Main()
        {
            const string PrimerMissatge = "Introdueix una frase: ";
            const string MissatgeError = "Format incorrecte";

            string userInput;

            Console.Write(PrimerMissatge);
            try
            {
                userInput = Console.ReadLine();
                Console.WriteLine($"El teu text transformat és: {ChangeToLowerOrUpperCase(userInput)}");

            }
            catch (Exception)
            {
                Console.WriteLine(MissatgeError);
            }
        }
    }
}
//CON: Retornarà la versió en majúscules o minuscules depenen de l'input.
```

## Exercici 8
```c#
using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static void ExchangeNumbers(ref int numOneUser, ref int numTwoUser)
        {
            int rem = numOneUser;
            numOneUser = numTwoUser;
            numTwoUser = rem;
        }

        public static void Main()
        {
            const string PrimerMissatge = "Introdueix el primer valor: ";
            const string SegonMissatge = "Introdueix el segon valor: ";
            const string MissatgeFinal = "Els teus valors intercanviats són: {0} i {1}";
            const string MissatgeError = "Format incorrecte";

            int numOneUser, numTwoUser;

            Console.Write(PrimerMissatge);
            try
            {
                numOneUser = Convert.ToInt32(Console.ReadLine());
                Console.Write(SegonMissatge);
                numTwoUser = Convert.ToInt32(Console.ReadLine());
                ExchangeNumbers(ref numOneUser, ref numTwoUser);
                Console.WriteLine(MissatgeFinal, numOneUser, numTwoUser);
            }
            catch (FormatException)
            {
                Console.WriteLine(MissatgeError);
            }
        }
    }
}
```

## Exercici 9
```c#
//PRE:
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
//CON:
```

## Exercici 10
```c#
//PRE:
//CON:
```

## Exercici 11
```c#
//PRE:
//CON:
```

## Exercici 12
```c#
//PRE:
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
//CON:
```

## Exercici 13
```c#
//PRE:
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
//CON:
```

## Exercici 14
```c#
//PRE:
//CON:
```

## Exercici 15
```c#
//PRE:
//CON:
```

## Exercici 16
```c#
//PRE:
//CON:
```

## Exercici 17
```c#
//PRE:
using System;

namespace ActivitatsPrimerTema
{
    public class Program
    {
        public static int[] StoreNumbersInUndefinedArray()
        {
            const string PrimerMissatge = "Quants valors vols introduïr? ";
            const string MissatgeError = "Format incorrecte";
            int numUser;

            Console.Write(PrimerMissatge);
            try
            {
                do
                {
                    numUser = Convert.ToInt32(Console.ReadLine());
                } while (numUser < 0);
                int[] userNumbers = new int[numUser];
                for (int i = 0; i < userNumbers.Length; i++)
                {
                    userNumbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                return userNumbers;
            }
            catch (Exception)
            {
                Console.WriteLine(MissatgeError);
            }
        }

        public static void PrintArray(int array)
        {
            foreach (int i in StoreNumbersInUndefinedArray()) 
            { 
                Console.WriteLine(i); 
            }

        }

        public static void Main()
        {
            const string MissatgeError = "Format incorrecte";

            StoreNumbersInUndefinedArray();

        }
    }
}
//CON:
```

## Exercici 18
### Clases d'equivàlencia
- Edat vàlida: Entre 0 i 120
- Edat invàlida: fora del rang

### Casos extrems
- 0 i 120 -> Depenent de com esté fet el programa entrarà al rang o no.
- -1, 121 -> Estàn al límit de l'interval
- 132, -32 -> Per provar

### Test per cada cas de prova
| Nom cas de prova | Descripció | Entrada | Accions | Resultat esperat | Resultat obtingut |
|---|---|---|---|---|---|
| Límit del rang | Comprovar els límits del rang establert | 0 | Crida al metòde amb 0 com argument |  |   |
| Límit del rang | Comprovar els límits del rang establert | 120 | Crida al metòde amb 120 com argument | |   |
| Límit del rang per fora | Comprovar els límits del rang establert | -1, 121 | Crida al metòde amb -1 & 121 com argument | |   |    
| Fora del rang | Comprovar la condició del rang | 132, -32 | Crida al metòde amb 132 & -32 com argument |   |   |

## Exercici 19
### Clases d'equivàlencia
- Edat valida: 0-120

- 50% descompte
  - 0-12
- 25% descompte
  - 13-17
- 0% descompte
  - 18-64
- 30% descompte
  - 65-120

### Tests ver validar descompte
- 50% descompte
    - 2, 5
- 25% descompte
    - 16, 17
- 0% descompte
    - 18, 54
- 30% descompte
    - 68, 100

### Casos límit
12-13, 17-18, 64-65 són tots casos límits per cada rang de descomptes.