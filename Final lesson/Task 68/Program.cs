Console.Clear();

int AckermannFunction(int m, int n) 
{
    if (m == 0) 
    {
        return n + 1;
    }
    else
    {
        if ((m > 0) && (n == 0)) 
        {
            return AckermannFunction(m - 1, 1);
        }
        else 
        {
            if ((m > 0) && (n > 0))
            {                
                return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
            }
            else
            {
                return m+1;
            }
        }
    }
}

Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine());

int A = AckermannFunction(M, N);
Console.Write(A);