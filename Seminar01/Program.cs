Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    Console.WriteLine("Введено не трехзначное число");
    return;
} 
Console.WriteLine(number%10);










// // Вывод квадрата числа
// Console.Write("Введите число: ");
// // int number1 = int.Parse(Console.ReadLine());
// int number = Convert.ToInt32(Console.ReadLine());
// int sqr = number * number;
// Console.WriteLine(sqr);

// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 == number2 * number2)
// {
//     Console.WriteLine("Первое число является квадратом второго ");
// }
// else
// {
//     Console.WriteLine("Первое число НЕ является квадратом второго ");
// }

// Console.WriteLine("Введите номер дня недели: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day == 1)
// {
//     Console.WriteLine("Понедельник");
// } 
// else if(day == 2)
// {
//      Console.WriteLine("Вторник");
// }
// else if(day == 3)
// {
//      Console.WriteLine("Среда");
// }     
// else if(day == 4)
// {
//      Console.WriteLine("Четверг");
// }
// else if(day == 5)
// {
//      Console.WriteLine("Пятница");
// }
// else if(day == 6)
// {
//      Console.WriteLine("Суббота");
// }
// else if(day == 7)
// {
//      Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Нет такого дня недели");
// }

// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int index = -number;
// while (index <= number)
// {
//     Console.Write(index+" ");
//     index++;
// }

