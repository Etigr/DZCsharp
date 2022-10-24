//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5, 782 -> 8, 918 -> 1
/*
int SecondNumber(int secondnum){
  int result = secondnum / 10 % 10;
  return result;
}
Console.WriteLine("Введите трёхзначное число");
int secondnum = Convert.ToInt32(Console.ReadLine());
    if (secondnum > 99 && secondnum < 1000){
        int x = SecondNumber(secondnum);
        Console.WriteLine($"вторая цифра вашего числа равна: {x}");
    } 
    else {
         Console.WriteLine($"Ваше число {secondnum} не трёх значное "); 
    }
    */

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6



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