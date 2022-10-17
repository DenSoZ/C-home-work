Console.Clear();

void NaturalNumbersList(int n)
{
    if(n > 0)
    {
        Console.Write(n + " ");
        NaturalNumbersList(n-1);
    }
}



Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
NaturalNumbersList(N);