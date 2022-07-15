/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        if (position == 0 && (count - 1) == 0)
        {
            Console.WriteLine("[" + array[position] + "]");
        }
        else if (position == 0)
        {
            Console.Write("[" + array[position] + ", ");
        }
        else if (position == (count - 1))
        {
            Console.WriteLine(array[position] + "]");
        }
        else
        {
            Console.Write(array[position] + ", ");
        }
        position++;
    }
}


int N;
System.Console.WriteLine("введите длину массива:");
while (!int.TryParse(Console.ReadLine(), out N))
{
    System.Console.WriteLine("Введите корректное значение:");
}
int[] array = new int [N];

FillArray(array); 
PrintArray(array); 


int i = 0;
int  sum = 0;

while (i < N)
{
    if (array[i] % 2 == 0)
    {
        sum++;
    }
    i++;
}

System.Console.WriteLine("количество чётных чисел в массиве:" + (sum));