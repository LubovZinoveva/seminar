/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i =0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

int CountPositive(int[] arr)
{
    int count = 0;
    foreach(int el in arr)
    {
        if(el % 2 == 0) count++;
    }
    return count;
}

Console.Write("Задайте размер массива: ");
int s = int.Parse(Console.ReadLine());
int[] array = GetArray(s);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(CountPositive(array));