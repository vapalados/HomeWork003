//Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[number];
int i = 0;
int s = 1;
while (i < number)
{
    massiv[i]=s*s*s;
    i++;
    s++;
}
writearr(massiv, number);
void writearr(int[] mass, int size)
{
    int a = 0;
    while (a < size)
    {
        Console.WriteLine(mass[a]);
        a++;
    }
}