//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.WriteLine("Введите номер дня недели: ");
int dayweek = Convert.ToInt32(Console.ReadLine());
switch (dayweek)
{
    case 1:
        {
            Console.WriteLine($"День недели под номером {dayweek} - понедельник");
            break;
        }
    case 2:
        {
            Console.WriteLine($"День недели под номером {dayweek} - вторник");
            break;
        }
    case 3:
        {
            Console.WriteLine($"День недели под номером {dayweek} - среда");
            break;
        }
    case 4:
        {
            Console.WriteLine($"День недели под номером {dayweek} - четверг");
            break;
        }

    case 5:
        {
            Console.WriteLine($"День недели под номером {dayweek} - пятница");
            break;
        }


    case 6:
        {
            Console.WriteLine($"День недели под номером {dayweek} - суббота");
            break;
        }
    case 7:
        {
            Console.WriteLine($"День недели под номером {dayweek} - воскресенье");
            break;
        }
    default:
        {
            Console.WriteLine($"День недели под номером {dayweek} - не существует");
            break;
        }



}

