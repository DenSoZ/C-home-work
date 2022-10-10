Console.Clear();

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

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


double[,] randomArray = new double[m, n];
GenerateRandomArray(randomArray);
for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
          Console.Write(randomArray[i,j] + " ");
        }
        Console.WriteLine();
    }