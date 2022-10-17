Console.Clear();

Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine());

void SwapNumbers()
{
    int s = new int();
    s = M;
    M = N;
    N = s;
}

int Sum = 0;

if(M > N) SwapNumbers();

for (int i = M; i < N+1; i++)
{
    Sum += i;
}

Console.Write(Sum);