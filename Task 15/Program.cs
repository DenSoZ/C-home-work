void Holliday(int D)
{
    if (D%6 == 0 || D%7 == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.Write("Нет");
    }
}

Console.Write("Введите цифру дня недели: ");
int d = Convert.ToInt32(Console.ReadLine());
Holliday(d);