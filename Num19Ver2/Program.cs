//Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    Console.Write("Введите пятизначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int one = num / 10000;
    int two = (num / 1000) % 10;
    int three = (num / 100) % 10;
    int four = (num / 10) % 10;
    int five = num % 10;
    if (num > 9999 && num < 100000)
    {
        if (one == five && two == four) 
        Console.WriteLine(num + " - Палиндром!");
        else
        {
            Console.WriteLine("Не палиндром.");
        }
    }
    else
    {
        Console.WriteLine("Число не пятизначное!");
    }