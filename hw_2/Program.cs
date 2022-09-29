Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (num > 999)
    {
        num /= 10;
    }
    Console.WriteLine(num);
    Console.WriteLine("Третья цифра " + num % 10);
}

