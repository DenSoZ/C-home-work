Console.Clear();
int[] arr = new int[8];
Random rnd = new Random();
for (int i = 0; i < 8; i++)
{
    arr[i] = rnd.Next(1,100);
}


Console.WriteLine("[" + string.Join(", ", arr)+ "]");