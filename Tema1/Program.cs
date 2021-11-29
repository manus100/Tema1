using System;
using System.Linq;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array ;

            Console.WriteLine("1.Write a program that reads from the console three numbers of type int and prints their sum.");
            Console.WriteLine("Suma numerelor este: {0}", Sum(ReadNumbers(3, false)));


            Console.WriteLine("2.Write a program that reads five numbers from the console and prints the greatest of them.");
            Console.WriteLine($"Numarul cel mai mare este: {ReadNumbers(5, false).Max()}");

            Console.WriteLine("3.Write a program that reads from the console the radius \" r \" of a circle and prints its perimeter and area.");
            double pi = 3.14;
            double radius = ReadRadius();

            Console.WriteLine("Aria este: {0}", CalculateArea(radius, pi));
            Console.WriteLine("Perimetrul este: {0}", CalculatePerimeter(radius, pi));

            Console.WriteLine("4. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist that are divisible with 5. such that the remainder of their division by 5 is 0.");
            array = ReadNumbers(2, false);
            Console.WriteLine("In intervalul {0} - {1} sunt {2} numere divizibile cu 5 ", array[0], array[array.Length - 1], DivisibleBy5(array));

            Console.WriteLine("5.Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements and with conditional statements.");
            Array.Clear(array, 0, array.Length);
            array = ReadNumbers(2, false);
            Console.WriteLine($"Numarul cel mai mare este (fara conditional statement): {array.Max()}");
            Console.WriteLine($"Numarul cel mai mare este (cu conditional statement): {GetMax(array)}");

            Console.WriteLine("6.Write a program that reads five integer numbers and prints their sum.If an invalid number is entered the program should prompt the user to enter another number(only once)");
            Console.WriteLine("Suma numerelor este: {0}", Sum(ReadNumbers(5, true)));

            Console.WriteLine("7.Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.");
            PrintXNumbers(ReadOneNumber());

            Console.WriteLine("8. Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.");
            PrintNumbersNotDivisible(ReadOneNumber());

            Console.WriteLine("9.Write a program that reads from the console a series of 5 integers and prints the smallest and largest of them");
            Array.Clear(array, 0, array.Length);
            array = ReadNumbers(5, false);
            Console.WriteLine($"Numarul cel mai mare este: {array.Max()}");
            Console.WriteLine($"Numarul cel mai mic este: {array.Min()}");
            // sau cu functie care parcurge array-ul
            //Console.WriteLine($"Numarul cel mai mare este: {GetMax(array)}");
            // Console.WriteLine($"Numarul cel mai mare este: {GetMin(array)}");

            Console.WriteLine("10.Write program that outputs a triangle made of stars with variable size, depending on an input parameter.Look at the examples to get an idea.The input comes as a string number, which needs to be parsed to a number.The output is a series of lines printed on the console, forming a triangle of variable size.");
            PrintTriange(ReadOneNumber());

            Console.WriteLine("11. Write a program that converts a given number from decimal to binary notation (numeral system).");
            ConvertDecimalToBinary(ReadOneNumber());

            Console.WriteLine("12. Write a program that by a given integer N prints the numbers from 1 to N in random order");
            PrintRandomNumbers(ReadOneNumber());

            Console.WriteLine("13.A program which iterates the integers from 1 to 50 For multiples of three print Fizz instead of the number and for the multiples of five print Buzz. For numbers which are multiples of both three and five print FizzBuzz.");
            FizzBuzz();

            Console.WriteLine("14. A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.");
            PrintCompanyInfo();

        }


        static int[] ReadNumbers(int nb, bool validate)
        {
            int[] array = new int[nb];
            int intInput;
            string inputstr;
            for (int i = 0; i < nb; i++)
            {
                Console.WriteLine("Introduceti nr. {0}: ", i + 1);
                inputstr = Console.ReadLine();
                if (validate)
                {
                    if (!int.TryParse(inputstr, out intInput))
                    {
                        Console.WriteLine("Introduceti un numar intreg: ");
                        inputstr = Console.ReadLine();
                        if (int.TryParse(inputstr, out intInput))
                        {
                            array[i] = int.Parse(inputstr);
                        }
                        continue;
                    }
                }

                array[i] = int.Parse(inputstr);
            }
            return array;
        }

        //static int[] ReadNumbers(int nb)
        //{
        //    int[] array = new int[nb];
        //    for (int i = 0; i < nb; i++)
        //    {
        //        Console.WriteLine("Introduceti nr. {0}: ", i + 1);
        //        array[i] = int.Parse(Console.ReadLine());
        //    }
        //    return array;
        //}



        static int Sum(int[] arr)
        {
            int suma = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                suma += arr[i];
            }
            return suma;
        }

        static double ReadRadius()
        {

            Console.WriteLine("Introduceti raza (R): ");
            return double.Parse(Console.ReadLine());
        }

        static double CalculateArea(double radius, double pi)
        {
            return radius * radius * pi;
        }

        static double CalculatePerimeter(double radius, double pi)
        {
            return 2 * radius * pi;
        }

        static int DivisibleBy5(int[] arr)
        {
            int numbers = 0;
            for (int i = arr[0]; i <= arr[arr.Length-1]; i++)
            {
                if (i % 5 == 0)
                    numbers += 1;    
            }
            return numbers;
        }

        static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }
            return max;
        }

        static int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
            }
            return min;
        }

        //static int[] ReadXNumbers()
        //{
        //    Console.WriteLine("Introduceti N: ");
        //    int[] array = new int[int.Parse(Console.ReadLine())];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine("Introduceti nr. {0}: ", i + 1);
        //        array[i] = int.Parse(Console.ReadLine());
        //    }
        //    return array;
        //}

        static void PrintXNumbers(int nb)
        {
            Console.WriteLine("Numerele de la 1 la {0} sunt: ", nb);
            for (int i = 1; i <= nb; i++)
            {
                Console.WriteLine(i);
            }
        }


        static void PrintNumbersNotDivisible(int nb)
        {
            Console.WriteLine("Numerele nedivizibile cu 3 si 7 simultan sunt: ");
            for (int i = 1; i <= nb; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)     // sau i % 21
                    continue;
                else
                    Console.WriteLine(i);
            }
        }

        static int ReadOneNumber()
        {
            int nb = 0;
            Console.WriteLine("Introduceti un numar: ");
            nb = int.Parse(Console.ReadLine());
            return nb;
        }
        static void PrintTriange(int x)
        {
           
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                Console.Write("*");
                }
               Console.WriteLine();
            }

            for (int i = x-1; i >= 1; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
           
        }

        static void ConvertDecimalToBinary(int x)
        {
            int i;
            int[] arr = new int[10];
            // Console.Write("Enter the number to convert: ");    
            //x = int.Parse(Console.ReadLine());     

            Console.Write("Numarul {0} convertit in binar este: ", x);
            for (i = 0; x > 0; i++)      
                {      
                 arr[i] = x % 2;      
                 x = x / 2;    
                }
            
            for(i=i-1 ;i >= 0 ;i--)      
               {      
                Console.Write(arr[i]);      
               }

            Console.WriteLine();
               
        }

        static void PrintRandomNumbers(int x)
        {
            Random rndnb = new Random();
            int j, randomNumber;
           
            int[] arr = new int[x];

            for (int i = 1; i <= arr.Length; i++)
            {
                arr[i-1] = i;
            }

            foreach (int i in arr)
            {
                randomNumber = rndnb.Next(1, x);
                j = arr[i-1];
                arr[i-1] = arr[randomNumber];
                arr[randomNumber] = j;
            }

            foreach (int i in arr) Console.WriteLine(arr[i-1]);
          }

        static void FizzBuzz()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);

            }
        }
  
        static void PrintCompanyInfo()
        {
            Console.Write("Introduceti numele companiei: ");
            string Name = Console.ReadLine();

            Console.Write("Introduceti adresa companiei: ");
            string Address = Console.ReadLine();

            Console.Write("Introduceti numarul de telefon: ");
            long phone = long.Parse(Console.ReadLine());

            Console.Write("Introduceti faxul: ");
            long fax = long.Parse(Console.ReadLine());

            Console.Write("Introduceti adresa web: ");
            string webSite = Console.ReadLine();

            Console.Write("Introduceti numele managerului: ");
            string lastName = Console.ReadLine();

            Console.Write("Introduceti prenumele managerului: ");
            string firstName = Console.ReadLine();

            Console.Write("Introduceti telefonul managerului: ");
            long phoneManager = long.Parse(Console.ReadLine());

            Console.WriteLine("Numele companiei: {0}", Name);
            Console.WriteLine("Adresa: {0}", Address);
            Console.WriteLine("Tel. {0}", phone);
            Console.WriteLine("Fax. {0}", fax);
            Console.WriteLine("Web-site: {0}", webSite);
            Console.WriteLine($"Manager: {lastName}  {firstName}, telefon: {phoneManager}");
        }

    }
}


