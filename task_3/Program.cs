// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
int max1 = num2;
if (max1 > num3)
{
    max1 = num2;
}
else
    max1 = num3;
if (max > max1)
{
    Console.WriteLine(max);
}
else
    max = max1;
    Console.WriteLine(max);