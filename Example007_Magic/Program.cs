Console.Clear();       //Очистка копсоли
// Console.SetCursorPosition(10,4);   //Команда, которая будет рисовать. (Первая цифра - отступ слева, вторая - сверху).
// Console.WriteLine("+");

int xa = 1;       
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 40;
int yc = 30;          // Можно записать в строчку через запятую - int xa = 1, ya = 1, xb = 1, yb = 30; и тд

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = yb;
int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3);         //  [0;3)  0 1 2 - полуинтевал выдает числа "0 1 2". what -название переменной(случайное число).
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;                                     //count = count + 1; count +=1; - счетчик
}
