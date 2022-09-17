//Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число до которого нужно узнать все четные числа: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Имеем число {n}!");
    
    Console.Write($"Следующие числа являются четными: ");
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.Write($" {i}. ");