// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array =new int [8];
{

}
for (int u = 0; u < array.Length; u++)
{
    array[u] = new Random().Next(0, 100);
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}