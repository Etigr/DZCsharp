// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] RandomThree (int size, int minVal, int maxVal)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    } 
    return array;
}
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int ChetSum(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum += 1;
        }
    }
    return sum;
}
Console.Write("Введите размер массива: ");
int usersize = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 999;

int [] newArray = RandomThree(usersize, min, max);
PrintArray(newArray);

Console.Write($"Количествово чётных чисел в массиве: {ChetSum(newArray)}");
*/

// Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] RandomThree (int size, int minVal, int maxVal)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    } 
    return array;
}
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int ChetSum(int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
        sum += array[i];  
    return sum;
}
Console.Write("Введите размер массива: ");
int usersize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение минимального значения массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение максимального значения массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] newArray = RandomThree(usersize, min, max);
PrintArray(newArray);

Console.Write($"Сумма элементов на нечётных позициях равна: {ChetSum(newArray)}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.0 7.2 22.7 2.1 78.3] -> 76.2

double [] RandomThree (int size, int minVal, int maxVal)
{
    double [] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1)/1.11;
    } 
    return array;
}
void PrintArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double Raznost(double [] array)
{
  double min =  array[0];
  double max =  array[0];

  for(int i =0; i < array.Length; i++)
  {

    if(array[i] <= min)     min =  array[i];
    
        if(array[i] >= max)    max =  array[i];
  
  }
  return (max - min) ;
}
Console.Write("Введите размер массива: ");
int usersize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение минимального значения массива: ");
int mini = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение максимального значения массива: ");
int maxi = Convert.ToInt32(Console.ReadLine());

double [] newArray = RandomThree(usersize, mini, maxi);
PrintArray(newArray);

Console.Write($"Разница между максимальным и минимальным значением в массиве = {Math.Round(Raznost(newArray), 2) }") ;


