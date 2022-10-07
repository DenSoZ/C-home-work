Console.Clear();
Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
int count = 0;
for (int i = 0; i < N; i++)
{
    Console.Write($"Введите {i+1} элемент: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.Write($"Элементов больше нуля: {count}");