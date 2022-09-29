Console.WriteLine("Введите число ");
int day = Convert.ToInt32(Console.ReadLine());
day = Math.Abs(day);

if (day > 0 && day < 8)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine ("Выходной день");
    }
else 
{Console.WriteLine ("Будний день");
}
}