// This will be on the branch four

// HomeWork_Seminar_04


// Task 1

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// 3, 5 -> 243 (3⁵)   
// 2, 4 -> 16  

//   работает криво
/*
int InputText (string se)
{
    System.Console.Write(se);
    string readInput = Console.ReadLine();
    int resalt = int.Parse(readInput);
    return resalt;
}




int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}





bool ValidateNumber(int number)
{
    if (number < 0)
    {
        System.Console.WriteLine("Repeat the entry. Input a positive Power Number ");
        return false;    
    }
    return true;
}





int powerBase = InputText("Input a number: ");
int exponent = InputText("Input a positive Power Number: ");

if (ValidateNumber(exponent))
{
    System.Console.WriteLine ($"The number {powerBase} to the power of {exponent} is {Power(powerBase, exponent)}");
} 
*/




// // Task 2

// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//    Работает, но криво. Важно именно += в строке 78
/*
int InputText(string se)
{
    System.Console.WriteLine(se);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}




int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    } 
    return result;
}





int number = InputText("Input a positive number: ");
System.Console.WriteLine($"The sum of the digits in the number {number} is {SumAllDigit(number)}");
*/
 



// // Task 3

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


/*
int InputText(string se)
{
    System.Console.WriteLine(se);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}





int [] RandAr(int size, int minN, int maxN)
{
    int [] array = new int [size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array [i] = random.Next(minN, maxN + 1);
    }
    return array;
}




void PrintAr(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine($"{array[array.Length - 1]}]");
}




int size = InputText ("Input the number of elements in the array: ");
int minN = InputText ("Input the smallest number of the array: ");
int maxN = InputText ("Input the largest number of the array: ");
int [] myarray = RandAr(size, minN, maxN);

System.Console.Write($"Array of random numbers of a given range  ->  "); PrintAr(myarray);
*/