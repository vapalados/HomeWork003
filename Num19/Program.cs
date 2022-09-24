//Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int [] massiv = ConvIntToArr(number);
    int nachalo_massiva = 0;
    int konec_massiva = Convert.ToString(number).Length - 1;
    bool Pallindrom = true;
    while (nachalo_massiva < konec_massiva)
    {
        if (massiv[nachalo_massiva] == massiv[konec_massiva])
        {
            Pallindrom = true;
            nachalo_massiva++;
            konec_massiva--;
        }
        else
        {
            
            Pallindrom = false;
            Console.WriteLine("Не Палиндром!"); 
            break;   
        }
    }
    if (Pallindrom == true)
    {
        Console.WriteLine(number + " - Палиндром!");
    }
    static int[] ConvIntToArr(int originalnumber) 
    {
        int a = originalnumber;
        List<int> ar = new List<int>();
        while (a > 0) 
        {
            ar.Add(a % 10);
            a = a / 10;
        }
        return ar.ToArray();
     }