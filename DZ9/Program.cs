// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNum(int N)
{
    Console.Write(N + " ");
    if (N > 1) ShowNum(N - 1);
}

Console.Write("Введите число N, больше 1 : ");
int N = Convert.ToInt32(Console.ReadLine());

ShowNum(N);
*/
// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int Sum(int M, int N)
{
    if (M != N+1) return M + Sum(M+1, N);
    else return 0;
}

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N, больше M: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равно {Sum(M, N)}");
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа M и N.
// M = 2, N = 3 -> A(M,N) = 9
// M = 3, N = 2 -> A(M,N) = 29
/*
int Ackerman (int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return Ackerman(M - 1, 1);
    if (M > 0 && N > 0) return Ackerman(M - 1, Ackerman(M, N - 1));
return Ackerman(M, N);
}

Console.Write("Введите начальное число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное число N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) равна {Ackerman(m, n)}");
*/