/* Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
[1,2,2,3,2] -> [3, 2, 2, 2, 1]
*/

int [] BubbleSort(int[] array)
{
    int s;
    for(int i = 0; i < array.Length; i++)
    {
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[i] < array[j])
            {
                s = array[j];
                array[j] = array [i];
                array[i] = s;
            } 
        }
    }
    return array;
}

int[] GetArray()
{
    Console.WriteLine("Задайте размер масссива:");
    int size = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите элементы массива:");
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int[] arr = GetArray();
Console.WriteLine(String.Join(" ", arr));
BubbleSort(arr);
Console.WriteLine(String.Join(" ", arr));
