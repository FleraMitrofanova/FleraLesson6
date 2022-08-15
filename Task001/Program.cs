 //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

 int Sum(int size)
 {
    int a;
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        a=Convert.ToInt32(Console.ReadLine());
        if(a>0)
        {
            count++;
        }

    }
    return count;
 }
 int size = 5;
 int result = Sum(size);
 Console.WriteLine(result);
