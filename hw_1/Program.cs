Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999){
Console.WriteLine("Некорректное число");
} else {
    Console.WriteLine(num.ToString()[1]);
}

