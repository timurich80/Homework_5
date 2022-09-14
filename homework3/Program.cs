/* 
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 
*/


int[] FillArray(int[] collection)
{
    int lenghtArr = collection.Length;    
    for(int i = 0; i< lenghtArr; i++)
    {
        collection[i] = new Random().Next(1, 10);        
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


int SumOfOddElements(int[] numbers)
{
    Console.WriteLine("Minimum number is " + numbers.Min());
    Console.WriteLine("Maximum number is " + numbers.Max());
    int result = numbers.Max() - numbers.Min();
    return result;    
}

int[] arr = new int[10];

FillArray(arr);
PrintArray(arr);
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементов массива ->" + SumOfOddElements(arr)); 