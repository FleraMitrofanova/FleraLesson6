// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

void Corner(int k1, int k2, int b1, int b2)
{
    int x, y = 0;
    x = (b2-b1)/(k1-k2);
    y = k2 * x + b2;


    Console.WriteLine("Точка пересечения" + " x " +  x + " y " + y);
}

int k1,k2,b1,b2;
Console.WriteLine("Введите координаты");
k1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты");
k2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты");
b1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты");
b2=Convert.ToInt32(Console.ReadLine());

Corner(k1,k2,b1,b2);
