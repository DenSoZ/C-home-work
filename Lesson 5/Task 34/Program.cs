Console.Clear();
Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
Random rnd = new Random();
for (int i = 0; i < N; i++)
{
    arr[i] = rnd.Next(100,999);
}
Console.WriteLine("[" + string.Join(", ", arr)+ "]");
int count = 0;
for (int i = 0; i < N; i++)
{
    if (arr[i]%2 == 0)
    {
        count++;
    }
}

Console.Write($"Количество четных элементов массива = {count}");