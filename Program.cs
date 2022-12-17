// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

//   Console.Write("Введите число A: ");
//   int numA = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите число B: ");
//   int numB = Convert.ToInt32(Console.ReadLine());

//   int exp = met(numA, numB);
//   Console.WriteLine($"Ответ:   {exp}");



// int met(int numA, int numB){

//   int res = 1;

//   for(int i=1; i <= numB; i++){

//     res = res * numA;

//   }

//     return res;
// }



// Задача 27: Напишите программу, которая принимает на вход число и
//  выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

  int Sum(int num){
    
    // int count = 0;
    int a = 0;
    int res = 0;

    for (int count = 0; count <= num; count++){
      a = num - num % 10;
      res = res + (num - a);
      num = num / 10;
    }
   return res;
  }

int sum = Sum(num);
Console.WriteLine("Сумма цифр в числе: " + sum);







