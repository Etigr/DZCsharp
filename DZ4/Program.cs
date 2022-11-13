// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)
// 3, 5 -> 243 (3⁵);   0, 0 - >1;   2, 4 -> 16
/*
int Degree (int a, int b){
    int c=1;
    for (int i=0; i < b; i++)
 {c *= a;
 }
 return c;  

}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());
if(b>=0)
{
    Console.Write($"Число {a} в степени {b} равно {Degree(a,b)} ");
}
else {
    Console.Write($"Число {b} - отрицательное, а надо ввести натуральное ну или хотя бы 0");
}
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11;  82 -> 10;  9012 -> 12
/*
int Sum (int number){
    int result = 0;
    result += number % 10;
    number /= 10;
            if(number > 0)
            {
                result += Sum(number);
            }
            return result;
        }
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма цифр числа {number} равна: {(Sum(number))}");
*/

// Задача 29: Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19];   6, 1, 33 -> [6, 1, 33]
/*
int [] UserMasiv (int size, int minnum, int maxnum){
    int [] arr = new int[size]; 
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minnum,maxnum);
    }
        return arr;
}
void PrintArray(int [] arr){
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]}, ");
    }  
    Console.Write("\b\b]");
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

PrintArray(UserMasiv(size, 1, 100));
*/

// все переменные вводятся пользователем
/*
int [] UserMasiv (int size, int minnum, int maxnum){
    int [] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minnum,maxnum);
    }
        return arr;
}
void PrintArray(int [] arr){
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]}, ");
    }  
    Console.Write("\b\b]");
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int minnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int maxnum = Convert.ToInt32(Console.ReadLine());
PrintArray(UserMasiv(size, minnum, maxnum));
*/
