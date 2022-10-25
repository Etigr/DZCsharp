// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет, 12821 -> да, 23432 -> да
/*
void Palind (int num){
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num / 10 % 10;
    int num5 = num % 10;
    if(num1==num5 && num2==num4){
        Console.WriteLine($"Число {num} палиндром");
    }
    else{
        Console.WriteLine($"Число {num} не палиндром");
    }
}
Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
    if (num > 9999 && num < 100000){
         Palind(num);
    } 
    else {
         Console.WriteLine($"Ваше число {num} не пятизначное значное "); 
    }
*/
// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84, A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Otrezok(int xa, int ya, int za, int xb, int yb, int zb){
double dlina = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
 return dlina;
}
Console.Write("Введите координату ха: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату хb: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yа: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yb: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату zа: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату zb: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double result = Otrezok(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"Длина отрезка между точками А({x1},{y1},{z1}) и В({x2},{y2},{z2}) равна {Math.Round(result, 2)}");
*/

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27      5 -> 1, 8, 27, 64, 125
/*
void Kub(int num){
    for(int i=1; i<=num; i++){
        Console.Write($"{i*i*i}  ");
    }
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Kub(num);
*/