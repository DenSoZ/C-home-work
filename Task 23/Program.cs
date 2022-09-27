Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < N+1; i++)
{
    Console.Write($"{Math.Pow(i,2)}");
    if (i < N)
    {
        Console.Write(", ");
    }
}