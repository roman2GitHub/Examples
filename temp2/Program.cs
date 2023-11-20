// Напишите Напишите программу, программу, программу, которая которая принимает принимает принимает на вход цифру, цифру,
// обозначающую обозначающую обозначающую день недели, недели, недели, и проверяет, проверяет, проверяет, проверяет,
// является ли этот день выходным выходным .
Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());

    switch(day)
    {
        case 1:
            Console.WriteLine("Понедельник");
            break;
        case 2:
            Console.WriteLine("Вторник");
            break;
        case 3:
            Console.WriteLine("Среда");
            break;
        case 4:
            Console.WriteLine("Четверг");
            break;
        case 5:
            Console.WriteLine("Пятница");
            break;
        case 6:
            Console.WriteLine("Суббота");
            break;
        case 7:
            Console.WriteLine("Воскресенье");
            break;
        default:
            System.Console.WriteLine("Введен неверный день недели");
            break;
    }