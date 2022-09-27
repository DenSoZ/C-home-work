Console.Clear();
int[] IntToArray(int N, int count)
{

    int[] array = new int[count];
    for (int i = 1; i <= count; i++)
    {
        array[count-i] = N % 10;
        N = N /10;
    }
    return array;
}
int count = 0;
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int c = N;
while (c > 0)
    {
    c = c/10;
    count ++;
}
int[] arr = IntToArray(N, count);
for (int i = 0; i < count; i++)
{
    c += arr[i];
}
Console.Write($"Сумма цифр = {c}");