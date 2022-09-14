/* 
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 
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


int SumOfOddElements(int[] numbers)
{
    int result = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        for(int j = 0; j < numbers.Length; j = j + 2)
        {
            result = result + numbers[j];
        }
    }
    return result;    
}

int[] arr = new int[10];

FillArray(arr);
PrintArray(arr);
System.Console.WriteLine();
System.Console.WriteLine();
Console.Write(SumOfOddElements(arr)); 