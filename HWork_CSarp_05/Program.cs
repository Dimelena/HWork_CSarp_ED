// Task 34.

// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
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

int SumEvenNum(int[] array)    
{ 
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0) sum++;
    }
    return sum;
}

Console.Write("Input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(Length, min, max);      
WriteArray(myArray);
int sum = SumEvenNum(myArray);
//Console.WriteLine(sum);
Console.WriteLine($"Number of even numbers in the array is {sum}");
*/

// Task 36.
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
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

int SumEvenNum(int[] array)    
{ 
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i %2 == 1) 
            sum = array[i] + sum;
    }
    return sum;
}

Console.Write("Input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(Length, min, max);      
WriteArray(myArray);
int sum = SumEvenNum(myArray);
//Console.WriteLine(sum);
Console.WriteLine($"Sum of odd index numbers is {sum}");
*/

// Task 38.
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomArray(int size)       
{
    double[] array = new double[size];                                                                                                    
    for (int i = 0; i < size; i++)                                  
        // array[i] = new Random().Next(minValue, maxValue + 1); 
        array[i] = new Random().NextDouble(); 
        // array[i] = Math.Round(array[i], 2);    
    // return array;    
    return array;   // Math.Round(([i]array), 2); 
}

double[] WriteArray(double[] array)                                        
{
    for (int i = 0; i < array.Length; i++)     
        Console.Write((Math.Round(array[i], 2))+ "; ") ;  
        Console.WriteLine(); 
    return array;   
}


// int SumEvenNum(int[] array)     
// { 
//     int sum = 0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (i %2 == 1) 
//             sum = array[i] + sum;
//     }
//     return sum;
// }

Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Round(CreateRandomArray(Length), 2));

double[] myArray = CreateRandomArray(size);      
WriteArray(myArray);
// int sum = SumEvenNum(myArray);
// Console.WriteLine(sum);
// Console.WriteLine(array); //CreateRandomArray(Length));
*/



// !!!   НЕ ТРОГАТЬ !!!   РАБОТАЕТ ДЛЯ СОЗДАНИЯ МАССИВА ВЕЩЕСТВЕННОГО ЧИСЛА (ЗНАЧЕНИЕ ПОСЛЕ ",")
/*
double[] CreateRandomArray(int size)       
{
    double[] array = new double[size];                                                                                                    
    for (int i = 0; i < size; i++)                                  
        array[i] = new Random().NextDouble(); 
          
    return array;  
}



double[] WriteArray(double[] array)                                        
{
    for (int i = 0; i < array.Length; i++)     
        Console.Write((Math.Round(array[i], 2))+ "; ") ;  
        Console.WriteLine(); 
    return array;   
}

Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size);      
WriteArray(myArray);
*/
// !!!   НЕ ТРОГАТЬ !!!   РАБОТАЕТ ДЛЯ СОЗДАНИЯ МАССИВА ВЕЩЕСТВЕННОГО ЧИСЛА (ЗНАЧЕНИЕ ПОСЛЕ ",")


 

// !!! НЕ РАБОТАЕТ
/*
double[,] CreateRandomArray(int size, int minValue, int maxValue)       
{
    double[,] array = new double[size];                                                                                                    
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1)+new Random().NextDouble();                                  
        
          
    return array;  
}

Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandomArray(size);      
WriteArray(myArray);
*/
// !!! НЕ РАБОТАЕТ



/*
double[] CreateRandomArray(int size)       
{
    double[] array = new double[size];                                                                                                    
    for (int i = 0; i < size; i++)                                  
        array[i] = new Random().NextDouble(); 
          
    return array;  
}



double[] WriteArray(double[] array)                                        
{
    for (int i = 0; i < array.Length; i++)     
        Console.Write((Math.Round(array[i], 2))+ "; ") ;  
        Console.WriteLine(); 
    return array;   
}
*/

// double MaxNum(double[] array)                                        
// {
//     double max = array[i];
//     for (int i = 0; i < array.Length; i++) 
//         if (max > array[i]);   
//               //Console.Write((Math.Round(array[i], 2))+ "; ") ;  
//               //Console.WriteLine(); 
//     return max;   
// }
/*
double[] MaxNum(double[] array)                                        
{
    double max = array[i];
    
    for (int i = 0; i < array.Length; i++)
    {        0      2
        if (max > array[i]);   
    }       //Console.Write(max) ;  
            //Console.WriteLine(); 
    return max;   
}

Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size);      
WriteArray(myArray);
MaxNum(myArray);
*/


// Вариант Кристины

// 38 задача. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] FillArray(int size)
{
    double [] array1 = new double [size];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = Math.Round(new Random().NextDouble(),2) + new Random().Next(50);
            }
    return  array1;

}

/* это мой для дробной части числа (после запятой)

double[] CreateRandomArray(int size)       
{
    double[] array = new double[size];                                                                                                    
    for (int i = 0; i < size; i++)                                  
        array[i] = new Random().NextDouble(); 
          
    return array;  
}
*/
void PrintArray(double [] array)
{
    foreach (double item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

void MaxMin(double [] array)
{
    double max = array[0];
    double min = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]> max) max= array [i];
        if (array[i]< min) min= array [i];
    }
    System.Console.WriteLine($"максимальный элемент массива = {max}");
    System.Console.WriteLine($"минимальный элемент массива = {min}");
    System.Console.WriteLine($"разница между максимальным и минимальным элементом массива = {max - min}");

}


System.Console.WriteLine("введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = FillArray(size);
PrintArray(array);
MaxMin(array);