int a,b,c,max = 0;
Console.Write("Insert first number: ");
a = Convert.ToInt32 (Console.ReadLine());
Console.Write("Insert second number: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert third number: ");
c = Convert.ToInt32(Console.ReadLine());
max = a;
if ( max < b )
{
   max = b;
}
else
{
    if ( max < c )
    {
        max = c;
    }
}
Console.Write("Max = ");
Console.Write(max);