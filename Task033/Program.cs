/* Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, -3] -> да
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

bool IsContain(int[] mas, int num)
{
    for(int i = 0; i < mas.Length; i++)
    {
        if (mas[i] == num) return true; 
    }
    return false;
}

int[] array = GetArray(5, -10, 10);
Console.WriteLine(String.Join(" ", array));
if (IsContain(array, 6))
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");