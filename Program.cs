// Задача 34: Задайте массив заполненный случайными
//  положительными трёхзначными числами. Напишите программу,
//   которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] num = new int[15];


// void Array(int[] array, int min, int max){
//   for (int i = 0; i<array.Length; i++ ){
//     array[i] = new Random().Next(min, max);
//   }
// }


// void WrArray(int[] array){
//     for (int i = 0; i<array.Length; i++ ){
//     Console.Write(array[i] + " ");
//   }
//   Console.WriteLine();
// }



// int kol(int[] array){
//     int kolich = 0;
//     for (int i = 0; i<array.Length; i++ ){
//     if (array[i] % 2 == 0)
//     {
//       kolich++;
//     }
//   }
//   return kolich;
// }



// Array(num, 100, 1000);
// WrArray(num);
// Console.WriteLine();


// int kolich = kol(num);
// Console.WriteLine($"Количество чётных чисел в массиве: {kolich}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] CreateRandomArray(int size, int minVal, int maxVal){ 

    int[] array = new int[size];

    for(int i =0; i < size; i++)
        array[i] = new Random().Next(minVal, maxVal +1);

    return array;
}

void ShowArray(int[] array){

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int GetSumNechet(int[] array){

    int sum = 0;

    for(int i =0; i < array.Length; i++)
        if(array[i] % 2 == 1)
            sum +=array[i];

    return sum; 
    
}

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

int res = GetSumNechet(myArray);
Console.WriteLine("Сумма нечетных элементов " + res);



