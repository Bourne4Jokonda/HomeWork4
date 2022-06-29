// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите возводимое число A: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum=0;
int count = 0;
int numberA =A%10;
int i=0;

//int getCountDigits (int n)
//{
    while(A>0)
    {
        A /=10;
        count++;
    }
    
    // Console.WriteLine($"Число цифр: {count}");
    Console.WriteLine($"Цикл1 число {count}");//wr1
    //return A;
    
//}
// Console.WriteLine($"ЧИСЛО{A}");
//getCountDigits(countD);
int[]strA = new int [count];
//Console.WriteLine(strA);
Console.WriteLine(numberA);//wr2
// for(int i=0; i<=count-1;i++)
// {
//     Console.WriteLine($"Цикл1 счетчик{i}");//wr3
//     Console.WriteLine($"ЭлДо{strA[i]}");//wr4
//     Console.WriteLine(sum);//wr

//     sum=sum+strA[i];
//     Console.WriteLine($"ЭдПо{strA[i]}");//wr5
//     Console.WriteLine(sum);//wr6
// }
while(i<=count-1)
{
    Console.WriteLine($"Цикл1 счетчик{i}");//wr3
    Console.WriteLine($"ЭлДо{strA[i]}");//wr4
    Console.WriteLine(sum);//wr

    sum=sum+strA[i];
    i++;
    Console.WriteLine($"ЭдПо{strA[i]}");//wr5
    Console.WriteLine(sum);//wr6
}
Console.WriteLine(sum);//wr7
Console.WriteLine($"ЧИСЛО{A}");//wr8