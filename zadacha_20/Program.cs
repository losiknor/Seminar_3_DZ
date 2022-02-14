// № 20 Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Задайте номер черверти от 1 до 4: ");
int number = int.Parse(Console.ReadLine());
if (number == 1)
    Console.WriteLine("Диапазоны для возможных координат: x>0 y>0");
else
{
    if (number == 2)
    Console.WriteLine("Диапазоны для возможных координат: x<0 y>0");
    else
    {
        if (number == 3)
           Console.WriteLine("Диапазоны для возможных координат: x<0 y<0");
        else
        {
            if (number == 4)
               Console.WriteLine("Диапазоны для возможных координат: x>0 y<0");
            else Console.WriteLine("Вы неправильно здали номер четверти, попробуйте ещё раз");
        }
    }
}



