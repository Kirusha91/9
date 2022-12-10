// Задача 10: Напишите программу, которая принимает на вход трёхзначное
//  число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int CutNumber(int num){
//     
//     int ed = num / 10;
//     int result = ed % 10;
//     return result;

// }

// int oldNum = n;

// int newNum = CutNumber(n);

// Console.WriteLine($"New version of a number {oldNum} in {newNum}");


// Задача 15: Напишите программу, 
// которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет




bool met(int day){

    if (day == 6 || day == 7){
        return true;
    }   
    else 
    {
        return false;
    }
}

Console.Write("Введи цифру, для дня недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
bool result = met(day);
Console.WriteLine(result);


// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int met(int num){


// }