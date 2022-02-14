// № 22 Найти расстояние между точками в пространстве 2D
int x1 = new Random().Next(-100, 100);
int y1 = new Random().Next(-100, 100);
int x2 = new Random().Next(-100, 100);
int y2 = new Random().Next(-100, 100);
Console.WriteLine("Заданы две точки с координатами (" + x1 + ";" + y1 + ") и (" + x2 + ";" + y2 + ")");
Console.WriteLine("Расстояние между данными точками:  " + Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2)));
// 3D 
int x3 = new Random().Next(-100, 100);
int y3 = new Random().Next(-100, 100);
int z3 = new Random().Next(-100, 100);
int x4 = new Random().Next(-100, 100);
int y4 = new Random().Next(-100, 100);
int z4 = new Random().Next(-100, 100);
Console.WriteLine("Заданы две точки с координатами (" + x3 + ";" + y3 + ";" + z3 +") и (" + x4 + ";" + y4 + ";" + z4 + ")");
Console.WriteLine("Расстояние между данными точками:  " + Math.Sqrt(Math.Pow(x4-x3, 2) + Math.Pow(y4-y3, 2) + Math.Pow(z4-z3, 2)));