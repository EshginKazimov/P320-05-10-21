using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print();
            //Print();
            //Print();
            //Print();
            //Print();
            //Print();
            //Print();
            //Print();
            //Print();

            //Console.WriteLine(Sum(2, 3));

            //int sum = Sum(4, 5);
            //sum++;
            //sum += 5;
            //Console.WriteLine(sum);

            //Console.WriteLine(Difference(1));

            //PrintColor(ConsoleColor.Red, "Welcome P320!");
            //PrintColor(ConsoleColor.Cyan, "Bye P320!");

            //Print();

            //Console.WriteLine(Multiply(2, 3, 4));

            //PrintColor(ConsoleColor.Green, 5);
            //PrintColor(ConsoleColor.Green, "Welcome");

            //Console.WriteLine(Multiply(10.2, 10.1));

            //Console.WriteLine(Multiply(2, 4));

            //int[] numbers = { 4, 3, 4, 1, 8, 9, 4, 3 };
            //Console.WriteLine(Multiply(numbers));

            //Console.WriteLine(Multiply(0, 1, 2, 3, 5, 6, 7, 8));

            int[] resultArray = CheckArray(0, 2, 3, 4, -2, -1);
            foreach (int number in resultArray)
            {
                Console.Write(number + " ");
            }
        }

        static void Print()
        {
            Console.WriteLine("Input your name:");
            string name = Console.ReadLine();

            if (name == "Orkhan")
            {
                Console.WriteLine($"Bye {name}");
                return;
            }

            //Console.WriteLine("Welcome " + name);
            Console.WriteLine($"Welcome {name}");
        }

        static int Sum(int a, int b)
        {
            //int sum = a + b;

            //return sum;

            return a + b;

            //Console.WriteLine("asfafasfasf");
        }

        static int Difference(int a = 10, int b = 5)
        {
            return a - b;
        }

        static void PrintColor(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static void PrintColor(ConsoleColor color, int number)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(number);
            Console.ResetColor();
        }

        //Overload methods - parametr saylari ve tipleri ferqli olan
        //static int Multiply(int a, int b = 10)
        //{
        //    return a * b;
        //}

        static int Multiply(int a = 10, int b = 5)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static int Multiply(int a, int b, int c = 10)
        {
            return a * b * c;
        }

        static int Multiply(params int[] numbers)
        {
            int multiply = 1;
            foreach (int number in numbers)
            {
                //if (number == 5)
                //{
                //    break;
                //}

                //if (number == 0)
                //{
                //    continue;
                //}

                if (number % 2 == 0)
                {
                    continue;
                }
                else if (number > 5)
                {
                    continue;
                }
                else if (number > 0)
                {

                }
                multiply *= number;
            }

            return multiply;
        }

        static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number + 1;
                }
                else if (number % 2 != 0)
                {
                    sum += number - 1;
                }
                
                if (number % 5 == 0)
                {
                    sum += number + 4;
                }
            }

            return sum;
        }

        static int[] CheckArray(params int[] numbers)
        {
            int[] result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    result[i] = numbers[i] * 2;
                }
                else if (numbers[i] < 0)
                {
                    result[i] = numbers[i] + 2;
                }
            }

            return result;
        }
    }

    //Butun tapshiriqlari ayri ayri methodlarda yazmaq
    //1. Int array-de musbet elementleri 2-ye vurub,
    //menfi elementleri +2 edib, yeni array duzeldib ekranda gostermek

    //2. 
}
