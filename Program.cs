// Задача 19

// Напишите программу, которая принимает на
//  вход пятизначное число и проверяет,
//   является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// // 23432 -> да

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = n;
int revers = 0;

int met(int num){
    while (n > 0){
        int d = n % 10;
        revers = revers * 10 + d; // Переворачиваем число задом на перед
        n = n / 10;
    }
    return revers;




//         // if(temp == revers){// проверяем новое число со старым
//         //     Console.WriteLine($"Ваше число: {n} это палиндром.");
//         // }
//         // else Console.WriteLine($"Ваше число: {n} это не палиндром.");
    


}
if(temp == revers){// проверяем новое число со старым
            Console.WriteLine($"Ваше число: {n} это палиндром.");
        }
        else Console.WriteLine($"Ваше число: {n} это не палиндром.");
int result = met(num);



// Задача 21

// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// double fd( double xA, double yA, double zA, double xB, double yB, double zB){

    
//     double dis = Math.Sqrt(Math.Pow(xA - xB ,2) + Math.Pow(xB - yB ,2) + Math.Pow(zA - zB ,2));

//     return dis;
// }

// Console.WriteLine("Введите Координаты точки zA: ");
// double xA = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координаты точки yA: ");
// double yA = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координаты точки zA: ");
// double zA = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координаты точки xB: ");
// double xB = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координаты точки yB: ");
// double yB = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координаты точки zB: ");
// double zB = Convert.ToDouble(Console.ReadLine());
 

//  double dist = fd(xA, yA, zA, xB, yB, zB);
//  Console.WriteLine($"Ваша дистанция = {dist}");