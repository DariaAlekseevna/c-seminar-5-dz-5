/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 100);
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
int  max  = array[i];
int min = array[i];
while (i < N)
{
    if (max <= array[i])
    {
        max = array[i];
    }
    i++;
}

i = 0;
while (i < N)
{
    if (min > array[i])
    {
        min = array[i];
    }
    i++;
}

System.Console.WriteLine("разница между макс и мин равна:" + (max-min));