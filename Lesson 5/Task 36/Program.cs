Console.Clear();
Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
Random rnd = new Random();
for (int i = 0; i < N; i++)
{
    arr[i] = rnd.Next(1,10);
}
Console.WriteLine("[" + string.Join(", ", arr)+ "]");
int sum = 0;
for (int i = 1; i < N; i += 2)
{
    sum += arr[i];
}
Console.Write($"Сумма нечетных элементов = {sum}");