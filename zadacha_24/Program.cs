// № 24 Найти кубы чисел от 1 до N
// int number = new Random().Next(1, 10);
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Кубы чисел от 1 до " + number + " :");
for (int i = 1; i <= number; i++)
    Console.WriteLine(Math.Pow(i, 3));
