using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_04
{
    internal class Baitap4
    {
        static void Main(string[] args)
  
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //ex_01();
            //ex_02();
            //ex_03();
            //ex_04();
            //ex_05();
            //ex_06();
            //ex_07();
            //ex_08();
            //ex_09();
            //ex_10();


        }
        //1. Write a C# Sharp program to check whether a given number is even or odd.
        static void ex_01()
        {
            Console.WriteLine("nhap 1 so");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} la so chan");
            }
            else
            {
                Console.WriteLine($"{a} la so le");

            }
        }
        //2. Write a C# Sharp program to find the largest of three numbers.
        static void ex_02()
        {
            Console.WriteLine("nhap 1 so");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap 1 so");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap 1 so");
            int c = int.Parse(Console.ReadLine());
            int max = a;
            if (max > b && max > c)
            {
                Console.WriteLine($"{max}");
            }
            else if (b > max && b > c)
            {
                Console.WriteLine($"{b}");
            }
            else
                Console.WriteLine($"{c}");
        }
        //3.Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies
        static void ex_03()
        {
            Console.Write("Input the value for X coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the value for Y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) lies in the First quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) lies in the Second quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) lies in the Third quadrant.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) lies in the Fourth quadrant.");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) is at the Origin.");
            }
            else
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) lies on an Axis.");
            }
        }
        //4.Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        static void ex_04()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            if (x == y && y == z)
            {
                Console.WriteLine($"This is an Equilateral triangle.");
            }
            else if (x == y || y == z || x == z)
            {
                Console.WriteLine("This is an Isosceles triangle.");
            }
            else
            {
                Console.WriteLine("This is a Scalene triangle.");
            }
        }
        //5.Write a program to read 10 numbers and find their average and sum
        static void ex_05()
        {

            int count = 10;
            double sum = 0;

            Console.WriteLine($"Please enter {count} numbers:");


            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Number {i}: ");
                double currentNumber = Convert.ToDouble(Console.ReadLine());
                sum += currentNumber;
            }
            double average = sum / count;
            Console.WriteLine($"Total Sum: {sum}");
            Console.WriteLine($"Average:   {average}");

        }
        //6.Write a program to display the multiplication table of a given integer
        static void ex_06()
        {
            Console.Write("Nhap vao 1 so");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{x} x {i} = {x * i}");
            }
        }
        //7.Write a program to display a pattern like triangles with a number.
        static void ex_07()
        {

            int rows = 4;
            Console.WriteLine("Mẫu 1:");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n-------------------\n");


            Console.WriteLine("Mẫu 2:");
            int count2 = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count2 + " ");
                    count2++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n-------------------\n");


            Console.WriteLine("Mẫu 3:");
            int count3 = 1;
            for (int i = 1; i <= rows; i++)
            {

                for (int space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");
                }


                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count3 + " ");
                    count3++;
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        //8.Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
        static void ex_08()
        {

            Console.Write("Nhập số lượng số hạng (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0.0;

            Console.WriteLine("\nChuỗi Harmonic:");

            for (int i = 1; i <= n; i++)
            {
                if (i < n)
                {

                    Console.Write($"1/{i} + ");
                }
                else
                {
                    Console.Write($"1/{i}");
                }
                sum += 1.0 / i;
            }


            Console.WriteLine($"\n\nTổng của chuỗi {n} số hạng là: {sum:F4}");

        }
        //9.Write a program to find the ‘perfect’ numbers within a given number range.
        static void ex_09()
        {
            Console.WriteLine("Nhập số cần kiểm ");
            int n = int.Parse(Console.ReadLine());
            int tong_uoc = 1;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.Write($"{i} + ");
                    tong_uoc += i;
                }
            }
            Console.WriteLine($" = {tong_uoc}");
            if (tong_uoc == n)
            {
                Console.WriteLine($"{n} là số hoàn hảo");
            }
            else
            {
                Console.WriteLine($"{n} không là số hoàn hảo");
            }
        }
        //10.Write a program to determine whether a given number is prime or not.

        static void ex_10()
        {
            Console.WriteLine("Nhập số cần kiểm ");
            int so = int.Parse(Console.ReadLine());
            if (so < 2)
                Console.WriteLine($"{so} không phải là số nguyên tố");
            else
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(so); i++)
                {
                    if (so % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    Console.WriteLine($"{so} là số nguyên tố");
                else
                    Console.WriteLine($"{so} không là số nguyên tố");
            }

        }
    }
    }

