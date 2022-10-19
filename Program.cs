// 1.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{ 
    Console.WriteLine($"Первое число {num1} больше второго числа {num2}");
}
else if (num1<num2)
{ 
    Console.WriteLine($"Второе число {num2} больше первого числа {num1}");
}
    else {
        Console.WriteLine("Number first equal second number");
    }
    */
// 2.Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num1>max) max = num1;
if (num2>max) max = num2;
if (num3>max) max = num3;

Console.WriteLine($"Максимальное число {max}");
*/

// 3.Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
/*
Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

int result = num1 % 2;
if (result>0)
{
  Console.WriteLine($"Число {num1}  - нечётное");  
}
else
{
Console.WriteLine($"Число {num1}  - чётное");}
*/

// 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Введите число");
int numN = Convert.ToInt32(Console.ReadLine());
int num1 = 2;

while (num1<=numN)
{
    Console.Write(num1 + " ");
    num1=num1+2;
}
*/
