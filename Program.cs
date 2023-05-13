// НОМЕР 6.43

double n;
double m;
bool error = true;
int count = 0;
int i = 1;
try
{
    Console.WriteLine("введите 1000, если хотите закончить последовательность");
    Console.WriteLine("Введите первое число ");
    n = double.Parse(Console.ReadLine());
    m = n;
    do
    {
        Console.WriteLine($"Введите число РАВНОЕ или БОЛЬШЕ {n}");
        n= double.Parse(Console.ReadLine());
        if (m > n) error = false;
        if (m == n) count++;
        m = n;
        i++;
    }
    while (n != 1000);
    if (error) Console.WriteLine($"Количество повторяющихся чисел = {count + 1}, количество различающихся чисел = {i - count}");
    else Console.WriteLine("Ваша последовательность не соответствует требованиям!");
}
catch
{ Console.WriteLine("Ошибка"); }