// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}




// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратн


// Console.WriteLine("Введите первое число");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if (firstNumber % secondNumber == 0)
// {
//     Console.WriteLine("кратное");
// }
// else
// {
//     Console.WriteLine($"НЕт, {firstNumber % secondNumber}" );
// }





//  Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98
// Random rand = new Random();
// int randomNumber = rand.Next(100, 1000);
// int leftDigit = randomNumber / 100;
// int rightDigit = randomNumber % 10;
// int result = leftDigit*10+rightDigit;
// Console.WriteLine(randomNumber + " -> " + result);

// int randomNumber = new Random().Next(10, 100);
// Console.WriteLine(randomNumber);
// // int left = randomNumber / 10;
// // int right = randomNumber % 10;
// if (randomNumber / 10 > randomNumber % 10)
// {
//     Console.WriteLine(randomNumber / 10);
// }
// else
// {
//     Console.WriteLine(randomNumber % 10);
// }


// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100 || number > 999)
// {
//     Console.WriteLine("Введено не трехзначное число");
//     return;
// } 
// Console.WriteLine(number%10);










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

