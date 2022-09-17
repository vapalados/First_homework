//Программа, которая принимает на вход трёхзначное число и на выходе показываетпоследнюю цифру этого числа.
Console.WriteLine("Введите число: ");
string text = Console.ReadLine();
int y = text[text.Length - 1] - '0';

Console.Write("Последняя цифра числа: ");
Console.Write(y);