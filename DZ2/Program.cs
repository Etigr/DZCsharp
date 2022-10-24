//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5, 782 -> 8, 918 -> 1
/*
int SecondNumber(int num){
  int result = num / 10 % 10;
  return result;
}
Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
    if (num > 99 && num < 1000){
        int x = SecondNumber(num);
        Console.WriteLine($"вторая цифра вашего числа равна: {x}");
    } 
    else {
         Console.WriteLine($"Ваше число {num} не трёх значное "); 
    }
    */

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6
/*
void SecondNumber(int num){
    if (num > 99 && num <1000){
    int result = num % 10;
    Console.WriteLine($"Третья цифра вашего числа равна {result}");
    }
        else if (num > 999 && num <10000){
        int result = num % 100 / 10;
        Console.WriteLine($"Третья цифра вашего числа равна {result}");
        }
          else if (num > 9999 && num <100000){
          int result = num % 1000 / 100;
          Console.WriteLine($"Третья цифра вашего числа равна {result}");
          }  
            else if (num > 99999 && num <1000000){
            int result = num % 10000 / 1000;
            Console.WriteLine($"Третья цифра вашего числа равна {result}");
            }  
                else if (num > 999999 && num <10000000){
                int result = num % 100000 / 10000;
                Console.WriteLine($"Третья цифра вашего числа равна {result}");
                }  
                    else if (num > 9999999 && num <100000000){
                    int result = num % 1000000 / 100000;
                    Console.WriteLine($"Третья цифра вашего числа равна {result}");
                    }  
}
Console.WriteLine("Введите число мешьше 100000000");
int num = Convert.ToInt32(Console.ReadLine());
SecondNumber(num);
    if (num < 99 ){
        
        Console.WriteLine($"Третьей цифры в вашем числе НЕТ");
    } 
    else if (num > 1000000000){
         Console.WriteLine($"Вы вышли за диапазон"); 
    }
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да, 7 -> да, 1 -> нет
/*
void Nedeli(int day){
    if (day < 6){
        Console.WriteLine($"Сегодня будни, иди работай");
    }
    else {
        Console.WriteLine($"Сегодня можно отдохнуть");
    }
}
Console.WriteLine("Введите порядковый номер дня недели");
    
        int day = Convert.ToInt32(Console.ReadLine());
        if (0 < day && day < 8){
        Nedeli (day);}
    else {
         Console.WriteLine($"В неделе всего 7 дней");
    }
    */