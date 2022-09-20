int[] IntToArray(int N)
{
    int c = N;
    int count = 0;
    while (c > 0)
    {
        c = c/10;
        count ++;

    }

    int[] array = new int[count];
    for (int i = 1; i <= count; i++)
    {
        array[count-i] = N % 10;
        N = N /10;
    }
    return array;
}

Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = IntToArray(a);
Console.WriteLine(string.Join(" ", arr));
Console.WriteLine("Второй элемент массива = " + arr[1]);