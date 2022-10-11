Console.Clear();

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m, n];

int[,] GenerateRandomArray (int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = rnd.Next(1,10);
        }
    }
    return array;
}

void ShowArray()
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
          Console.Write(randomArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void Average ()
{
    double[] average = new double[n];
    Console.WriteLine("Среднее арифметическое столбцов: ");
     for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
          average[i] += randomArray[j, i];
        }
        average[i] = Math.Round(average[i] / m , 2);
        Console.Write(average[i] + " ");
    }

}


GenerateRandomArray(randomArray);
ShowArray();
Average();