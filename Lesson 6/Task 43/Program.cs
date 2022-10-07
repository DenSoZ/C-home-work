Console.Clear();
string [] con = {"k1", "b1", "k2", "b2"};
double[] value = new double [4];
double FindX (double[] cons)
{
    double x = (cons[3] - cons[1])/(cons[0]-cons[2]);
    return x;
}
double FindY(double[] cons, double x)
{
    double y1, y2;
    y1 = cons[0] * x + cons[1];
    y2 = cons[2] * x + cons[3];
    if (y1 == y2)
    {
        return y1;
    } 
    else
    {
        return 0;
    }
}

for (int i = 0; i < 4; i++)
{
    Console.Write($"Введите {con[i]}: ");
    value[i] = Convert.ToInt32(Console.ReadLine());

}

if ((value[0] % value[2] == 0) && (value[1] % value[3] == 0 || value[3] % value[1] == 0))
{
    Console.Write("Прямые не пересекаются.");
}
else
{
    double x = FindX(value);
    double y = FindY(value, x);
    Console.Write($"Точка пересечения прямых: ({x},{y}) ");
}