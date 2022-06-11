// // Задача №1 Найти число в квадрате

// // Console.Write("Введите следующее число:");
// // int number = Convert.ToInt32(Console.ReadLine()); // Вводим число 32 бита на число

// // int result = number * number;
// // Console.WriteLine(number + " в квадрате будет " + result);


// Задача №3 Является ли второе число квадратом первого?

// Console.WriteLine("Введите первое число:");
// int FirstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int SecondNumber = Convert.ToInt32(Console.ReadLine());

// int square = FirstNumber * FirstNumber;
// if (square == SecondNumber)
// {
//     Console.WriteLine("Да, является");
// }
// else
// {
//     Console.WriteLine("Нет, не является");
// }
// Console.WriteLine(square+"- квадрат первого числа");



// Задача №4 Найти все целые числа от N до -N

// Console.Write("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int min = -number;
// while (min <= number)
// {
//     Console.Write(min + " ");
//     min++;
// }


// Задача №4 Вывести последне чисо трехзначного числа

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    if (number < 1000)
    {
        int LastNumber = number % 10;
        Console.WriteLine("Последнее число: " + LastNumber);
    }
    else
    {
        Console.WriteLine("Вы ввели неверное число");
    }
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}
