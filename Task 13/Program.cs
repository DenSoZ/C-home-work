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
int a = Convert.ToInt32(Console.ReadLine());
int c = a;
while (c > 0)
    {
    c = c/10;
    count ++;
}
if (count <= 2) 
{
    Console.Write("Третьей цифры нет");
}
else
{
    int[] arr = IntToArray(a, count);
    Console.WriteLine(string.Join(" ", arr));
    Console.WriteLine("Третья цифра = " + arr[2]);
}