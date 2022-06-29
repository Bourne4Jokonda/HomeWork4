// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B\

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// !НЕ ИСПОЛЬЗОВАТЬ MATH.POW() И АНАЛОГИ!

Console.WriteLine("Введите возводимое число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число-степень B: ");
int B = Convert.ToInt32(Console.ReadLine());
int sum = 1;
for(int i=1; i<=B; i++)
{
    sum=sum*A;
}
Console.WriteLine($"{sum}");