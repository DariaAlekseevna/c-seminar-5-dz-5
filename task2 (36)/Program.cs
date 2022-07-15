/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-100, 100);
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

int i = 1;
int  sum = 0;

while (i < N)
{
    sum = sum + array[i];
    i += 2;
}

System.Console.WriteLine("сумму элементов, стоящих на нечётных позициях:" + (sum));
