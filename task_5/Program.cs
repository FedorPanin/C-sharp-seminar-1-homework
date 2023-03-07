// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
int min = 2;
while (min <= num)
{
    Console.Write(min + " ");
    min = min + 2;
}