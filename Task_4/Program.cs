// Показать треугольник Паскаля
Console.Clear();
Console.Write("Enter your number of rows: ");
int number=int.Parse(Console.ReadLine()??"0");
Console.WriteLine();
for (int y=0;y<number;y++)
{         
    int count=1;
    for (int q=0;q<number-y;q++)
    {
        Console.Write("   ");
    }
    for (int x=0;x<=y;x++)
    {
        Console.Write("   {0:d} ",count);
        count=count*(y - x)/(x + 1);
    }
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine();
