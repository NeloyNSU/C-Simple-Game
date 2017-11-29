using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool DisplayMenu = true;
            while (DisplayMenu)
            {
                DisplayMenu = MainMenu();
            }
        }

        private static  bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose Game option from menu \n");

            Console.WriteLine("Option-1: Print Number Game");
            Console.WriteLine("Option-2: Number Guessing Game");
            Console.WriteLine("Option-3: Prime Numbers Finding Game");
            Console.WriteLine("Option-4: Exit \n");

            String Choice = Console.ReadLine();

            if(Choice == "1")
            {
                Option1();
                return true;
            }

            else if (Choice == "2")
            {
                Option2();
                return true;

            }

            else if(Choice == "3")
            {
                Option3();
                return true;
            }

            else if (Choice == "4" )
            {
                return false;

            }

            else
            {
                return true;
            }
        }



        private static void Option1()
        {
            Console.Clear();

            Console.WriteLine("Enter a Number\n");
            int number = int.Parse(Console.ReadLine());
            int counter = 1;

            while(counter<number+1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
                
            }

            Console.Write("\n\n");
            Console.ReadLine();

        }

        private static void Option2()
        {
            Console.Clear();
            Console.WriteLine("Enter a number\n");


            Random number = new Random();
            int RandomNumber = number.Next(1, 11);

            int guess = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("\nGuess a Number Between 1 and 10\n");

                string Result = Console.ReadLine();
                guess++;

                if (Result == RandomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong!\n");
                }

            } while (incorrect);
            Console.WriteLine("Correct! It took {0} guessess.\n", guess);


            Console.ReadLine();

        }

        private static void Option3()
        {
            Console.Clear();
            Console.WriteLine("Enter a Number");

            int num = int.Parse(Console.ReadLine());

            PrimeNumbers(num);


            if (PrimeNumbers(num)==true)
            {
                Console.WriteLine("{0} is a Prime Number!\n", num);

            }

            else
            {
                Console.WriteLine("{0} is not a prime number!\n", num);
            }

            Console.ReadLine();

         }

        private static bool PrimeNumbers(int number)
        {
            
            bool prime = false;

            for (int i = 2; i < number/2; i++)
            {

                if (number % i == 0)
                {
                    prime = true;
                    break;
                }
            }

            return prime;

        }


    }
}
