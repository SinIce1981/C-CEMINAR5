// // Задача 31 Масси из 12 элементов заполненный случайными цифрвами от -9 до 9
// // найти сумму отрицательных и положитльныъ элементов массива

// void Zadacha31()
// {
// int size = 12;
// int [] numbers = new int [size];

// FillArray(numbers, -9,9);
// PrintArray(numbers);
// Console.WriteLine(SumPositive(numbers));
// Console.WriteLine(SumNegative(numbers));
// }

// int SumPositive(int[]numbers)
// {
//     int sum = 0;
//     for (int i = 0; i<numbers.Length; i++)
//     {
//         if (numbers[i] >0)
//         sum+=numbers[i];
//     }
//     return sum;
// }

//     int SumNegative(int[]numbers)
// {
//     int sum = 0;
//     for (int i = 0; i<numbers.Length; i++)
//     {
//         if (numbers[i] < 0)
//         sum+=numbers[i]; 
//     }
//     return sum;

// }
// void FillArray(int[]numbers,
//                int minValue=0,
//                int maxValue=100)
// {
//     maxValue++;
//     Random random = new Random();
//     for (int i = 0; i<numbers.Length; i++)
//     {
//         numbers[i] = random.Next(minValue, maxValue);
//     }
// }
// void PrintArray(int[]numbers)

// {
//     Console.WriteLine("Вывод массива");

//     for (int i = 0; i<numbers.Length; i++)
//     {
//         Console.Write (numbers[i] +" ");

//     }
//     Console.WriteLine();
// }

//  Zadacha31();

// Задача 32: Напишите программу замены элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.

// void Zadacha32()
// {
//     int size = 12;
//     int[] numbers = new int[size];
//     FillArray(numbers);
//     PrintArray(numbers);
//     changeValue(numbers);
//     PrintArray(numbers);
// }
// void FillArray(int[] numbers)
// {
//     Random random = new Random();
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = random.Next(-9, 10);
//     }
// }
// void PrintArray(int[] numbers)

// {
//     Console.WriteLine("Вывод массива");

//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");

//     }
//     Console.WriteLine();
// }

// void changeValue(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] *= -1;
//     }
// }

// // Zadacha32();

// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

// void Zadacha33()

// {
//     Console.WriteLine("Введите число для поиска в масссиве");
//     int check = Convert.ToInt32(Console.ReadLine());
//     int size = 12;
//     int[] numbers = new int[size];
//     FillArray(numbers);
//     CheckArray(numbers, check);
//     PrintArray(numbers);

// }
// void FillArray(int[] numbers)
// {
//     Random random = new Random();
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = random.Next(-9, 10);
//     }
// }
// void PrintArray(int[] numbers)

// {
//     Console.WriteLine("Вывод массива");

//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");

//     }
//     Console.WriteLine();
// }

// void CheckArray(int[] numbers, int check)

//   {   bool flag = false;
//     // int i =0;
//     for (int i = 0; !flag && i < numbers.Length; i++)
//     {
//         if (check == numbers[i])
//         {
//            flag = true;
//         }
//     }
//     // while (!flag && i < numbers.Length)
//     // {
//     //     if (check == numbers[i])
//     //        {
//     //           flag = true;
//     //        }
//     //        i++;
//     // }

//     if (flag )
//         Console.WriteLine("Число находится в массиве");
//     else
//         Console.WriteLine("Число не находится в массиве");

//   }

// Zadacha33();

// Задача 35: Задайте одномерный массив, состоящий из случайных чисел.
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// void Zadacha35()

// {
//     int size = 12;
//     int[] numbers = new int[size];
//     FillArray(numbers);
//     PrintArray(numbers);
//     FindArray(numbers);


// }

// void FillArray(int[] numbers)
// {
//     Random random = new Random();
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = random.Next(-10, 100);
//     }
// }

// void PrintArray(int[] numbers)

// {
//     Console.WriteLine("Вывод массива");

//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");

//     }
//     Console.WriteLine();

// }

// void FindArray(int[] numbers)
// {
//     int count = 0;

//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] >= 10 && numbers[i] <= 99)
//         {
//             count++;

//         }
//     }
//     Console.WriteLine(count);
// }
// Zadacha35();


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.


void Zadacha37()
{
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    int maxIndex = size-1;

    for (int i = 0; i < size/2; i++)
    {
        Console.WriteLine($"{numbers[i]}  + {numbers [maxIndex-i]} = {numbers[i]}*{numbers [maxIndex-i]}");
    }
    if (size % 2 ==1)
    {
        Console.WriteLine("cредний элемент массива   " + numbers[size/2]);
    }
    Console.WriteLine();
}
void FillArray(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(-9, 9);
    }
}
void PrintArray(int[] numbers)

{
    Console.WriteLine("Вывод массива");

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");

    }
    Console.WriteLine();
    
}
Zadacha37();