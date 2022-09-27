Console.Clear();
int count = 5;
int[] IntToArray(int N)
{

    int[] array = new int[count];
    for (int i = 1; i <= count; i++)
    {
        array[count-i] = N % 10;
        N = N /10;
    }
    return array;
}

int check = 0;
Console.Write("Введите пятизначное число: ");
int p = Convert.ToInt32(Console.ReadLine());
int[] arr = IntToArray(p);

for (int i = 0; i < 2; i++)
{
    if (arr[i] == arr[4-i])
    {
        check++;
    }
}
if (check == 2)
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}
