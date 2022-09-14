/* 
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 
*/



int[] FillArray(int[] collection)
{
    int lenghtArr = collection.Length;    
    for(int i = 0; i< lenghtArr; i++)
    {
        collection[i] = new Random().Next(100, 1000);        
    }
    return collection;
}

void PrintArray(int[] array)
{
    int i = 0;
    while (i < array.Length - 1)
    {
        Console.Write($"{array[i]}" + ", ");
        i++;
    }
    Console.Write($"{array[i]}");
}

int EvenNumbers(int[] numbers)
{
    int result = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        int x = numbers[i] % 2;
         if (x == 0)
    result++;
        }
    return result;
}



int[] arr = new int[10];

FillArray(arr);
PrintArray(arr);
System.Console.WriteLine();
Console.Write(EvenNumbers(arr)); 