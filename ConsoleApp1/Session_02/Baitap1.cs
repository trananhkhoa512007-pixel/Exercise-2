using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_02
{
    internal class Baitap1
    {
        static void Main(string[] args)
        {
            //bai1
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"{c}");
            //bai2
            Console.Write("Nhap a: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int e = int.Parse(Console.ReadLine());
            int temp = d;
            d = e;
            e = temp;
            Console.WriteLine($" {d} {e}");
            //bai3
            float f = float.Parse(Console.ReadLine());
            float g = float.Parse(Console.ReadLine());
            float h = f * g;
            Console.WriteLine($"{h}");
            //bai4
            Console.Write("Nhap so feet: ");
            double feet = double.Parse(Console.ReadLine());
            double meters = feet * 0.3048;
            Console.WriteLine(feet + " feet = " + meters + " met");
            //bai5
            Console.WriteLine("1. Tu Celsius sang Fahrenheit");
            Console.WriteLine("2. Tu Fahrenheit sang Celsius");
            string choice = Console.ReadLine();
            Console.Write("Nhap gia tri nhiet do: ");
            double q = double.Parse(Console.ReadLine());
            if (choice == "1")
            {
                double fahrenheit = (q * 9 / 5) + 32;
                Console.WriteLine($"{q}°C = {fahrenheit:F2}°F");
            }
            else
            {
                double celsius = (q - 32) * 5 / 9;
                Console.WriteLine($"{q}°F = {celsius:F2}°C");
            }
            //bai6
            Console.WriteLine("1. int:     " + sizeof(int) + " bytes");
            Console.WriteLine("2. long:    " + sizeof(long) + " bytes");
            Console.WriteLine("3. float:   " + sizeof(float) + " bytes");
            Console.WriteLine("4. double:  " + sizeof(double) + " bytes");
            Console.WriteLine("5. decimal: " + sizeof(decimal) + " bytes");
            Console.WriteLine("6. char:    " + sizeof(char) + " bytes");
            Console.WriteLine("7. bool:    " + sizeof(bool) + " byte");
            //bai7
            Console.Write("Nhap mot ky tu: ");
            char character = Console.ReadKey().KeyChar;
            int w = (int)character;
            Console.WriteLine($"\nMa ASCII cua '{character}' la: {w}");
            //bai8
            double pi = 3.14;
            Console.Write("Nhap ban kinh r: ");
            double r = double.Parse(Console.ReadLine());
            double area = pi * r * r;
            Console.WriteLine($"Dien tich la: {area:F2}");
            //bai9
            Console.Write("Nhap canh: ");
            double t = double.Parse(Console.ReadLine());
            double ad = t * t;
            Console.WriteLine($"Dien tich la: {ad:F2}");
            //bai10
            Console.Write("Nhap tong so ngay: ");
            double s = double.Parse(Console.ReadLine());
            {

                TimeSpan ts = TimeSpan.FromDays(s);
                int years = (int)(s / 365);
                int weeks = (int)((s % 365) / 7);
                int days = (int)((s % 365) % 7);
                Console.WriteLine($"{s} ngay tuong duong voi:");
                Console.WriteLine($"So nam: {years}");
                Console.WriteLine($"So tuan: {weeks}");
                Console.WriteLine($"So ngay le: {days}");
            }
        }
    }
}
