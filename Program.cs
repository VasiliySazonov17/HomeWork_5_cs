//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] FillArray(int[] array, int length)
{

    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 999);
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

void QuantityEvenNumbersInArray(int[] array, int length)
{
int count = 0; 

    for(int i = 0; i < length; i++)
        {
            if(array[i] %2 == 0)
            {
                count++;
            }
            else
            {
                continue;   
            }
            
        }
    Console.WriteLine($"Quantity even numbers in array iqual: {count}");

}

Console.Write("Input length array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
FillArray(array, length);
PrintArray(array, length);
QuantityEvenNumbersInArray(array, length);