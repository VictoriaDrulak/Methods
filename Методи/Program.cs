using System;
//завдання 1 
/*class Calculator
{
    public static double Calculate(double first, double second, string operation)
    {
        switch (operation)
        {
            case "+":
                return first + second;
            case "-":
                return first - second;
            case "*":
                return first * second;
            case "/":
                if (second == 0)
                {
                    throw new ArgumentException("На нуль ділити не можна!");
                }
                return first / second;
            default:
                throw new ArgumentException("Невідома операція!");


        }
    }
    static void Main()
    {
        Console.WriteLine("Введiть перше число: ");
        double first = double.Parse(Console.ReadLine());
        Console.WriteLine("Введiть друге число: ");
        double second = double.Parse(Console.ReadLine());
        Console.WriteLine("Введiть операцiю калькулятора: ");
        string operation = Console.ReadLine();

        double result = Calculate(first, second, operation);
        Console.WriteLine($"Результат становить: {result}");
    }
}*/


//завдання 2 
/*class IsPrime
{
    public static bool DefPrime(int number)
    {
        if (number <= 0) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        { 
         if (number % i == 0) return false;
        }
        return true;
    }
    static void Main()
    {
        Console.WriteLine("Введiть число: ");
        int number = int.Parse(Console.ReadLine());
        if (DefPrime(number) == true)
        {
            Console.WriteLine("Число просте");
        }
        else
        {
            Console.WriteLine("Число не просте");
        }
    }
}*/

//завдання 3 конвертація валют
/*class Money
{
    public static double Conventer(double currency, double exchange_rate)
    {
        return currency * exchange_rate;
    }
    static void Main()
    {
        Console.WriteLine("Введiть кiлькiсть валюти: ");
        double currency = double.Parse(Console.ReadLine());
        Console.WriteLine("Введiть обмiнний курс: ");
        double exchange_rate = double.Parse(Console.ReadLine());

        double result = Conventer(currency, exchange_rate);
        Console.WriteLine($"Кiлькiсть валюти {currency} за курсом {exchange_rate} становить {result}");
    }
}*/

//завдання 4

/*class Array
{
    public static (int min, int max) MinMax(int[] array)
    {
        int min = array[0];
        int max = array[0];
        foreach (int number in array)
        { 
         if (number > max)
            {
                max = number;
            }
         if (number < min)
            {
                min = number;
            }
        }
        return (min, max);
    }
    static void Main()
    {
        int[] array = { 5, 2, 3, 1, 4 };
        Console.WriteLine($"Мiнiмальне та максимальне значення {MinMax(array)}");
    }
}*/

//завдання 5 
/*class ForString
{
    public static (int vowels, int consonants) CountVowels(string str)
    {
        int vowels = 0;
        int consonants = 0;
        string str_l = str.ToLower();

        for (int i = 0; i < str_l.Length; i++)
        {
            if (char.IsLetter(str_l[i]))
            {
                if ((str[i] == 'a')  (str[i] == 'o')  (str[i] == 'u')  (str[i] == 'e')  (str[i] == 'i'))
                {
                    vowels++;
                }
                else 
                {
                    consonants++;
                }
            }
        } 
        return (vowels, consonants);
    }
    static void Main()
    {
        Console.WriteLine("Введiть текст: ");
        string str = Console.ReadLine();
Console.WriteLine($"Кiлькiсть голосних та приголосних становить: {CountVowels(str)}");
    }
}*/
// завдання 6 
/*class GeometryCalculator
{
    public static double CircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
    public static double RectangArea(double width, double height)
    {
        return width * height;
    }
    public static double CubeVolume(double side)
    {
        return Math.Pow(side, 3);
    }
    public static double CylinderVoume(double radius_c, double height_c)
    {
        return Math.PI * Math.Pow(radius_c, 2) * height_c;
    }
    static void Main()
    {
        Console.WriteLine("Виберiть фігуру, площу або об'єм якої бажаєте знайти: \n 1 - площа кола, 2 - площа прямокутника, 3 - об'єм куба, 4 - об'єм цилiндра:");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Введiть радiус кола: ");
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"Площа кола становить: {CircleArea(radius)}");
                break;
            case 2:
                Console.WriteLine("Введiть ширину прямокутника: ");
                double witdth = double.Parse(Console.ReadLine());
                Console.WriteLine("Введiть висоту прямокутника: ");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"Площа прямокутника становить: {RectangArea(witdth, height)}");
                break;
            case 3:
                Console.WriteLine("Ввeдiть сторону куба: ");
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"Об'єм куба становить: {CubeVolume(side)}");
                break;
            case 4:
                Console.WriteLine("Введiть радiус цилiндра: ");
                double radius_c = double.Parse(Console.ReadLine());
                Console.WriteLine("Введiть висоту цилiндра: ");
                double height_c = double.Parse(Console.ReadLine());
                Console.WriteLine($"Об'єм цилiндра становить: {CylinderVoume(radius_c, height_c)}");
                break;

            default:
                Console.WriteLine("Невiрний вибiр");
                break;



        }
    }
}*/