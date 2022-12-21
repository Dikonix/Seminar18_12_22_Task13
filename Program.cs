Console.Write("Введите число: ");
string? number = Console.ReadLine();
if (number is not null)
{
    if (number.Length < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine(number[2]);
    }
}