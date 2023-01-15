int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int x3 = Convert.ToInt32(Console.ReadLine());
int x4 = Convert.ToInt32(Console.ReadLine());
if (x3 > x2 || x1 > x4)
    Console.WriteLine("пустое множество");
if (x1 > x3)
    x3 = x1;
if (x2 > x4)
    x2 = x4;
if (x2 == x3)
    Console.WriteLine(x2);
else
{
    Console.Write($"{x3} ");
    Console.WriteLine(x2);
}