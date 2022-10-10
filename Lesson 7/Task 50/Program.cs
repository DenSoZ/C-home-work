Console.Clear();

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер числа: ");
int number = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m, n];

double[,] GenerateRandomArray (double[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = Math.Round(rnd.NextDouble() * 20 - 10, 2);
        }
    }
    return array;
}

void SearchNumber(int numberS)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            count++;
            if (count == numberS)
            {
                Console.Write($"Значение элемента: {randomArray[i,j]}");
            }
        }
    }
    if (count < numberS)
    {
        Console.Write("Такого числа в массиве нет.");
    }
}


GenerateRandomArray(randomArray);
for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
          Console.Write(randomArray[i,j] + " ");
        }
        Console.WriteLine();
    }
SearchNumber(number);