/* 
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2 
*/
Console.Clear();
System.Console.WriteLine("Введите длину массива: ");
int lengthArr = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[lengthArr];

FillArray(arr);
PrintArray(arr);
System.Console.WriteLine();
Console.Write(EvenNumbers(arr));

int[] FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(100, 1000);
    }
    return collection;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) { }
    Console.Write(String.Join(",", array));
}

int EvenNumbers(int[] numbers)
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        int x = numbers[i] % 2;
        if (x == 0)
            result++;
    }
    return result;
}