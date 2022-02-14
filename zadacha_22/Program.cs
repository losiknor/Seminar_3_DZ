// № 22 Найти расстояние между точками в пространстве 2D/3D
int x1 = new Random().Next(-100, 100);
int y1 = new Random().Next(-100, 100);
int x2 = new Random().Next(-100, 100);
int y2 = new Random().Next(-100, 100);
Console.WriteLine("Заданы две точки с координатами (" + x1 + ";" + y1 + ") и (" + x2 + ";" + y2 + ")");
Console.WriteLine("Расстояние между данными точками:  " + Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2)));
// про 3D подумаю позже