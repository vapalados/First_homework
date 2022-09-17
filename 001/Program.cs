 //Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число!");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число!");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
Console.WriteLine($"Имеем два числа {a} и {b}!");

if
(a > b)
{
     Console.WriteLine($"Максимальное число: {a} , минимальное число: {b}!");
}

else 
{
    Console.WriteLine($"Максимальное число: {b}, минимальное число: {a}!");
}