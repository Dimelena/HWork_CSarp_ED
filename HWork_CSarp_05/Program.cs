// Task 34.

// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateRandomArray(int size, int minValue, int maxValue)       
{
    int[] array = new int[size];                                    
                                                                    
    for (int i = 0; i < size; i++)                                  
        array[i] = new Random().Next(minValue, maxValue + 1);      
    return array;    
}

void WriteArray(int[] array)                                        
{
    for (int i = 0; i < array.Length; i++)     
    Console.Write(array[i] + " ");                                  

    
    Console.WriteLine();
}

int SearchQuan(int [] array, int A, int B)     // находим количество элементов массива, значения которых лежат в определенном отрезке [a, b]
{ 
    int quan = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= A && array[i] <= B) quan++;
    }
    return quan;
}

Console.Write("Input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a value for the start of the segment: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a value for the end of the segment: ");
int B = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(Length, min, max);      
WriteArray(myArray);
int quan = SearchQuan(myArray, A, B);
Console.WriteLine(quan);