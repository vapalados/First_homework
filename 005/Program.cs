// Программа, которая будет выдавать название дня недели по заданному номеру
Console.Write("Введите день недели: ");
string username = Console.ReadLine();

if(username.ToLower() == "1")
{
    Console.WriteLine("Понедельник");
}
if(username.ToLower() == "2")
{
    Console.WriteLine("Вторник");
}
if(username.ToLower() == "3")
{
    Console.WriteLine("Среда");
}
if(username.ToLower() == "4")
{
    Console.WriteLine("Четверг");
}
if(username.ToLower() == "5")
{
    Console.WriteLine("Пятница");
}
if(username.ToLower() == "6")
{
    Console.WriteLine("Суббота");
}
if(username.ToLower() == "7")
{
    Console.WriteLine("Воскресенье");
}
else 
{
    Console.Write("В неделе всего 7 дней");
}