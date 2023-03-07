// является ли число четным

Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
int res = num % 2;
if (res == 0)
{
    Console.WriteLine("четное");
}
else
    Console.WriteLine("нечетное");