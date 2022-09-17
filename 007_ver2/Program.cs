//Программа, которая принимает на вход трёхзначное число и на выходе показываетпоследнюю цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Имеем число {n}!");
int ost = n % 10;
Console.WriteLine($"Последняя цифра числа: {ost}!");