/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] FillArray(int[] array, int length)
{

    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-77, 77);
    }

return array;
}

void PrintArray(int[] array, int length)
{

    for(int i = 0; i < length; i++)
    {
            Console.Write($"{array[i]}");
            if (i+1 != length)
            {
                Console.Write(", ");  
            }
            else
            {
                Console.WriteLine(". ");
            }
    } 
}

void SumNumOddPositionArray(int[] array, int length)
{
    int SumNumbers = 0;

    for(int i = 0; i < length; i++)
    { 
        if( i % 2 != 0)
        {
            SumNumbers += array[i];
        }
        else
        {
            continue;
        }
    }

    Console.WriteLine($"Sum numbers array on odd positions: {SumNumbers}");

}


Console.Write("Input length array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
FillArray(array, length);
PrintArray(array, length);
SumNumOddPositionArray(array, length);
