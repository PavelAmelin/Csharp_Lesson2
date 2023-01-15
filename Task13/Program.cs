int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
Console.WriteLine("третьей цифры нет");
else if (100 <= num & num < 1000)
Console.WriteLine(num % 10);
else
{
while (num >= 1000)
    num /= 10;        
Console.WriteLine(num % 10);
}
 

