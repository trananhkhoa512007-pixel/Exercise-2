using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_03
{
    internal class Baitap2
    {
        static void Main(string[] args)
        {
            /*1.Print Hello and Name
            Write a C# Sharp program to print Hello and your name in a separate line*/


            Console.WriteLine("Hello: Alexandra Abramov");

            /*2.Sum of Two Numbers
            Write a C# Sharp program to print the sum of two numbers.*/
            {
                int a = 5, b = 10;
                int sum = a + b;
                Console.WriteLine($"Tong cua a va b :{sum}");
            }

            /*3.Divide Two Numbers
            Write a C# Sharp program to print the result of dividing two numbers.*/
            {
                int c = 6, d = 3;
                int result = c / d;
                Console.WriteLine($"ket qua: {result}");
            }
            /*4. Specified Operations Results
            Write a C# Sharp program to print the results of the specified operations*/
            {
                double f = -1 + 4 * 6;
                double g = (35 + 5) % 7;
                double h = 14 + -4 * 6 / 11;
                double j = 2 + 15 / 6 * 1 - 7 % 2;
                Console.WriteLine($"{f}\n" + $"{g}\n" + $"{h}\n" + $"{j}");
            }
            /*5. Swap Two Numbers
            Write a C# Sharp program to swap two numbers.*/
            {
                int z = int.Parse(Console.ReadLine());
                int x = int.Parse(Console.ReadLine());
                int q = z;
                z = x;
                x = q;
                Console.WriteLine($"First Number :{z}\n" + $"Second Number :{x}\n");
            }
            /*6.Multiply Three Numbers
            Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.*/
            {
                int m = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                int p = int.Parse(Console.ReadLine());
                int r = m * n * p;
                Console.WriteLine($"{m} x {n} x {p} = {r}");
            }
            /*7. Arithmetic Operations
            Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing
            two numbers entered by the user.*/
            {
                int t = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int ar = t + y;
                int ad = t - y;
                int af = t * y;
                int ag = t / y;
                int aj = t % y;
                Console.WriteLine($"{t} + {y} = {ar}\n" + $"{t} - {y} = {ad}\n" + $"{t} * {y} = {af}\n" + $"{t} / {y} = {ag}\n" + $"{t} mod {y} = {aj}");
            }
            /*8.Multiplication Table
            Write a C# Sharp program that prints the multiplication table of a number as input.*/
            {
                int u = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{u} x {i} = {u * i}");
                }
            }
            /*9. Average of Four Numbers
            Write a C# Sharp program that takes four numbers as input to calculate and print the average.*/
            {
                Console.Write("Enter the First number: ");
                int we = int.Parse(Console.ReadLine());
                Console.Write("Enter the Second number: ");
                int wr = int.Parse(Console.ReadLine());
                Console.Write("Enter the Third number: ");
                int wy = int.Parse(Console.ReadLine());
                Console.Write("Enter the Four number: ");
                int wu = int.Parse(Console.ReadLine());
                int se = (we + wr + wy + wu) / 4;
                Console.WriteLine($"The average of {we} , {wr} , {wy} , {wu} is: {se}");
            }
            /*10.Specified Formula with Three Numbers
            Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.*/
            {
                Console.Write("Enter the First number: ");
                int xc = int.Parse(Console.ReadLine());
                Console.Write("Enter the Second number: ");
                int yc = int.Parse(Console.ReadLine());
                Console.Write("Enter the Third number: ");
                int zc = int.Parse(Console.ReadLine());
                Console.WriteLine($"Result of specified numbers {xc}, {yc} and {zc}, (x+y).z is {(xc + yc) * zc} and x.y + y.z is {xc * yc + yc * zc}");
            }
            /*11.Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You
            look older than 20".*/
            {
                Console.Write("Enter your age ");
                int tuoi = int.Parse(Console.ReadLine());
                Console.WriteLine($"You look older than {tuoi}");
            }
            /*12.Repeat Number in Rows
            Write a C# program that takes a number as input and displays it four times in a row (separated by blank
            spaces), and then four times in the next row, with no separation. You should do it twice: Use the
            console.Write and use {0}.*/
            {
                Console.Write("Enter a digit: ");
                int so = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} {0} {0} {0}", so);
                Console.WriteLine("{0}{0}{0}{0}", so);
                Console.WriteLine("{0} {0} {0} {0}", so);
                Console.WriteLine("{0}{0}{0}{0}", so);
            }
            /*13.Rectangle Pattern with Number
            Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows
            tall using that digit.*/
            {
                Console.Write("Enter a number: ");
                int bien = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}{0}{0}", bien);
                Console.WriteLine("{0} {0}", bien);
                Console.WriteLine("{0} {0}", bien);
                Console.WriteLine("{0} {0}", bien);
                Console.WriteLine("{0}{0}{0}", bien);
            }
            /*14.Celsius to Kelvin and Fahrenheit
            Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit*/
            {
                Console.Write("Enter the amount of celsius: ");
                double celsius = double.Parse(Console.ReadLine());
                double Kelvin = celsius + 273;
                double Fahrenheit = (celsius * 1.8) + 32;
                Console.WriteLine($"Kelvin = {Kelvin}");
                Console.WriteLine($"Fahrenheit = {Fahrenheit}");
            }
            /*15.Remove Character by Index
            Write a C# program that removes a specified character from a non-empty string using the index of a
            character.*/
            {
                string text = "w3resource";
                Console.WriteLine(text);


                Console.WriteLine(RemoveCharacter(text, 1));


                Console.WriteLine(RemoveCharacter(text, 9));


                Console.WriteLine(RemoveCharacter(text, 0));
                static string RemoveCharacter(string str, int index)
                {
                    return str.Remove(index, 1);
                }
            }
            /*16.Add First Character to Front and Back
            Write a C# program to create a string from a given string (length 1 or more) with the first character
            added at the front and back.*/
            {
                Console.Write("Input a string: ");
                string bn = Console.ReadLine();
                char firstChar = bn[0];
                string ss = firstChar + bn + firstChar;
                Console.WriteLine(ss);
            }
            /*17.Check Positive and Negative Pair
            Write a C# program to check a pair of integers and return true if one is negative and one is positive.*/
            {
                Console.Write("Input first integer: ");
                int si = int.Parse(Console.ReadLine());
                Console.Write("Input second integer: ");
                int sp = int.Parse(Console.ReadLine());
                if ((si > 0 && sp < 0) || (si < 0 && sp > 0))
                    Console.WriteLine("True");

                else
                    Console.WriteLine("False");
            }
            /*18.Sum or Triple Sum of Integers
            Write a C# program to compute the sum of two given integers. If two values are the same, return the
            triple of their sum.*/
            {
                Console.Write("Input first integer: ");
                int qw = int.Parse(Console.ReadLine());

                Console.Write("Input second integer: ");
                int qe = int.Parse(Console.ReadLine());
                int tong = qw + qe;
                if (qw == qe)
                {
                    Console.WriteLine(tong * 3);
                }
                else
                {
                    Console.WriteLine(tong);
                }
            }
            /*19.Absolute Difference or Double It
            Write a C# program to get the absolute value of the difference between two given numbers. Return
            double the absolute value of the difference if the first number is greater than the second number.*/
            {
                Console.Write("Input first  ");
                int cv = int.Parse(Console.ReadLine());
                Console.Write("Input second  ");
                int cb = int.Parse(Console.ReadLine());
                int cg = Math.Abs(cv - cb);
                if (cv > cb)
                {
                    Console.WriteLine(cg * 2);
                }
                else
                {
                    Console.WriteLine(cg);
                }

            }
            /*20.Check for 20 or Sum Equals 20
            Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20
            or if their sum is 20.*/
            {
                Console.Write("Input first  ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Input second  ");
                int n2 = int.Parse(Console.ReadLine());
                int n3 = n1 + n2;
                if (n1 == 20 || n2 == 20 || n3 == 20)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }

            }
        }
    }
}
   
        


    

