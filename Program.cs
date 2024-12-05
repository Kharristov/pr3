using System;

public class Program
{
    public static int DigitalRoot(int num)
    {
        while (num >= 10)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10; 
                num /= 10; 
            }
            num = sum;  
        }

        return num; 
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число для вычисления цифрового корня:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Цифровой корень: {DigitalRoot(num)}");
    }
}
