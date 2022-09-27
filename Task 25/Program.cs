Console.Clear();
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write($"Число А в степени B = {Math.Pow(A,B)}");