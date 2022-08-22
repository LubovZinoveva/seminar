/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i =0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SumArray(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Write("Задайте размер массива: ");
int s = int.Parse(Console.ReadLine());
Console.WriteLine("Введите min и max значения массива:");
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());

int[] arr = GetArray(s, min, max);
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(SumArray(arr));