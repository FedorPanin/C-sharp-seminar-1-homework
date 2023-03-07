// Напишите программму которая на вход принимает 2 числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 max = 7

Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num1 > num2)
{
    Console.WriteLine("максимальное число ");
    Console.WriteLine(max);
}
else
    max = num2;
    Console.WriteLine("максимальное число ");
    Console.WriteLine(max);
