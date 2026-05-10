using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Session_04
{
    internal class Baitap3
    {
        static void Main(string[] args)
        {
          
    {
        Console.Write("Nhập số thứ nhất: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int b = int.Parse(Console.ReadLine());
        int tong = a + b;
        int hieu = a - b;
        int nhan = a * b;
        int chia = a / b;

        Console.WriteLine($"{tong}");
        Console.WriteLine($"{hieu}");
        Console.WriteLine($"{nhan}");
        Console.WriteLine($"{chia}");
    }


//2 

{
    Console.WriteLine("Giá trị của x = y^2 + 2y + 1 (với y từ -5 đến +5):");
    Console.WriteLine("-------------------------------------------------");

    for (int y = -5; y <= 5; y++)
    {
        int x = (y * y) + (2 * y) + 1;
        Console.WriteLine($"Với y = {y,2}, x = {x}");
    }
}
//3
    {
        Console.Write("Nhập khoảng cách (tính bằng mét): ");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập thời gian (Giờ): ");
        double hours = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập thời gian (Phút): ");
        double minutes = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập thời gian (Giây): ");
        double seconds = Convert.ToDouble(Console.ReadLine());

     
        double timeInHours = hours + (minutes / 60.0f) + (seconds / 3600.0f);

  
        double distanceInKm = distance / 1000.0f;
        double distanceInMiles = distance / 1609.34f;

    
        double speedKmPerHr = distanceInKm / timeInHours;
        double speedMilesPerHr = distanceInMiles / timeInHours;

        Console.WriteLine("\n--- Kết quả ---");
        Console.WriteLine($"Vận tốc (km/h): {Math.Round(speedKmPerHr, 5)}");
        Console.WriteLine($"Vận tốc (miles/h): {Math.Round(speedMilesPerHr, 5)}");
    }

//4
{
    Console.Write("Nhập bán kính (r) của hình cầu: ");
    double radius = Convert.ToDouble(Console.ReadLine());
    double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
    double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    Console.WriteLine("\n--- Kết quả ---");
    Console.WriteLine($"Diện tích bề mặt: {surfaceArea}");
    Console.WriteLine($"Thể tích: {volume}");
}
    

//5

    {
        Console.Write("Nhập vào một ký tự: ");
        char inputChar = Convert.ToChar(Console.ReadLine());


        char lowerChar = Char.ToLower(inputChar);

        if (Char.IsDigit(inputChar))
        {
            Console.WriteLine("Ký tự bạn vừa nhập là một chữ số (Digit).");
        }
        else if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
        {
            Console.WriteLine("Ký tự bạn vừa nhập là một nguyên âm (Vowel).");
        }
        else if (Char.IsLetter(inputChar))
        {
            Console.WriteLine("Ký tự bạn vừa nhập là một phụ âm (Consonant).");
        }
        else
        {
            Console.WriteLine("Ký tự bạn vừa nhập là một ký hiệu khác (Symbol).");
        }
    }
        }
    }
}
