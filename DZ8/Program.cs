// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int [,] Create2dArray(int rows, int colums, int minValue, int maxValue)
{
    int [,] CreatedArray = new int[rows, colums];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
            CreatedArray[i,j] = new Random().Next(minValue, maxValue + 1);
    }
    return CreatedArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] ArraySort(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1)-1; j++)
    {
      int temp = array[i, j]; 
      if (array[i, j] < array[i, j + 1])
      { 
 
        temp = array[i, j + 1];
        array[i, j + 1] = array[i, j]; 
        array[i, j] = temp;  
      }
    }  
  }
  return (array);
}

Console.Write("Введите кол-во строк в массиве, больше 2: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массиве, больше 2: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int minnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int maxnum = Convert.ToInt32(Console.ReadLine());
ArraySort(Create2dArray(row, col, minnum, maxnum));
int[,] myArray = Create2dArray(row, col, minnum, maxnum); //
Console.WriteLine("Сгенерированный массив:");
Show2dArray(myArray);

for (int i = 0; i < myArray.GetLength(1) - 1; i++)
ArraySort(myArray);

Console.WriteLine("Массив после автосортировки:");
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int [,] Create2dArray(int rows, int colums, int minValue, int maxValue)
{
    int [,] CreatedArray = new int[rows, colums];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
            CreatedArray[i,j] = new Random().Next(minValue, maxValue + 1);
    }
    return CreatedArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[] SumRows(int[,] array) {
    int[] Summa = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++){
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++){
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма элементов {i+1} строки, равна : {sum}");
        Summa[i] = sum;
    }
    return Summa;
}

Console.Write("Введите кол-во строк в массиве, больше 2: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массиве, больше 2: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int minnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int maxnum = Convert.ToInt32(Console.ReadLine());

int[,] GenArray = Create2dArray(row, col, minnum, maxnum); 
Console.WriteLine("Сгенерированный массив:");
Show2dArray(GenArray);

int[] SumArray = SumRows(GenArray);
int min = SumArray[0];
int minI = 0;
for (int i = 0; i < SumArray.Length; i++)
{
    if (SumArray[i] < min)
    {
        min = SumArray[i];
        minI = i;
    }
}
Console.Write($"{minI+1} строка с наименьшей суммой элементов");
*/
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
Console.Write("Cтрок в массиве, не менее2-х: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцов в массиве, не менее2-х: ");
int colums = Convert.ToInt32(Console.ReadLine());
 
void ShowArr(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++) 
  {
    for (int j = 0; j < arr.GetLength(1); j++){

        Console.Write($"{arr[i, j], 2} ");

    }
    Console.WriteLine();
  }
}

int SpirallArr(int[,] newArray, int count, int iElm, int jElm) {
 
    for (int j = jElm; j < colums; j++){
        if (newArray[iElm, j] == 0) newArray[iElm, j] = count;
        count++;
    }
    
    for (int i = iElm + 1; i < rows; i++){
        if (newArray[i, colums - 1] == 0) newArray[i, colums - 1] = count;
        count++;
    }
 
    for (int j = colums - 2; j >= jElm; j--)
    {             
        if (newArray[rows - 1, j] == 0) newArray[rows - 1, j] = count;
        count++;
    }
 
    for (int i = rows - 2; i > iElm; i--)
    {                
        if (newArray[i, jElm] == 0) newArray[i, jElm] = count; 
        count++;
    }
    return count;
}

int[,] spirAddArray = new int[rows, colums];
int iBegin = 0;
int jBegin = 0;
int value = 1;

while (rows > 1 & colums > 1)
{
    value = SpirallArr(spirAddArray, value, iBegin, jBegin);
    iBegin++;
    jBegin++;
    rows--;
    colums--;  
}

ShowArr(spirAddArray);
*/