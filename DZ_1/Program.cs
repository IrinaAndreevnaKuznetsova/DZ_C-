// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
Double numberB = Convert.ToInt32(Console.ReadLine());
double result = 1;
for(int i = 0 ;i <= numberB; i++)
{
    result= Math.Pow(numberA,i);
}
Console.WriteLine($"{numberA} в степени {numberB}  равно {result}");




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int s= 0;
// int count = 0; 
// int copyNumber = A; 
//     while (A > 0)
//     {
//         count++; 
//         s = s + A%10;
//         A = A /10; 
//     }
// Console.WriteLine($"сумма цифр в числе {copyNumber}: {s} ");



// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

// int size = 8;
// int[] array = new int[size]; 

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(10,1000);
    
// }

// Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
