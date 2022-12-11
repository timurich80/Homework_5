/* 
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 
*/
Console.Clear();
System.Console.WriteLine("Введите длину массива: ");
int lengthArr = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[lengthArr];

FillArray(arr);
PrintArray(arr);
System.Console.WriteLine();
Console.Write(SumOfOddElements(arr));

int[] FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0, 10);
    }
    return collection;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) { }
    Console.Write(String.Join(",", array));
}


int SumOfOddElements(int[] numbers)
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 == 0)
        {
            result = result + numbers[i];
        }
    }
    return result;
}
