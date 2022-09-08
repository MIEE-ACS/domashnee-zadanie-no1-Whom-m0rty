using System;

public class HomeWork1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("y = 3x^6 - 6x^2 - 7");
        Console.Write("Input x (double): ");
        string xStr = Console.ReadLine();
        bool isNumeric = double.TryParse(xStr, out double x); // Проверка ввел ли пользователь число
        if (isNumeric)
        {
            double y;
            y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;
            Console.WriteLine("y = " + Math.Round(y, 3));  // Вывод ответа
        }
        else
        {
            Console.WriteLine("Please, enter a number"); 
        }

        Console.ReadKey(); // Ожидание ввода для того, что бы консоль не закрывалась.
    }
}