// № 18 Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool ProverkaUslovia(bool x, bool y)
{
    bool result;
    if ((!(x || y)) == ((!x) && (!y))) result = true;
    else result = false;
    return result;
}
bool x1 = false;
bool y1 = false;
bool res1;
res1 = ProverkaUslovia(x1, y1);
if (res1 == false)
    Console.WriteLine("Проверка на истинность не пройдена");
else
{
    bool x2 = false;
    bool y2 = true;
    bool res2;
    res2 = ProverkaUslovia(x2, y2);
    if (res2 == false)
        Console.WriteLine("Проверка на истинность не пройдена");
    else
    {
        bool x3 = true;
        bool y3 = false;
        bool res3;
        res3 = ProverkaUslovia(x3, y3);
        if (res3 == false)
            Console.WriteLine("Проверка на истинность не пройдена");
        else
        {
            bool x4 = true;
            bool y4 = true;
            if (ProverkaUslovia(x4, y4) == false)
                Console.WriteLine("Проверка на истинность не пройдена");
            else Console.WriteLine("Утверждение истинно");
        }
    }
}
