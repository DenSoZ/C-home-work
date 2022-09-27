Console.Clear();
Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
Random rnd = new Random();
for (int i = 0; i < N; i++)
{
    arr[i] = rnd.Next(-20,20);
}
Console.WriteLine("[" + string.Join(", ", arr)+ "]");
int min = arr[0], max = arr[0];

for (int i = 1; i < N; i ++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
    else
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
}
Console.Write($"Разница между минимальным и максимальным элементами = {max - min}");