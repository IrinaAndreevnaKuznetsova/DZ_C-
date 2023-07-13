// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int size = 12;
// int[] array = new int[size];

// int count = 0;

// for (int i = 0; i < size; i++) 
// {
//     array[i] = new Random().Next(100, 1000);
//     if ( array[i] % 2 == 0)
//     {
//        count++; 
//     }
    
// }
// Console.WriteLine($"В Массиве: [ {string.Join("; ", array)} ]");
// Console.WriteLine($"количество четных чисел равно: {count}");




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int size = 5;
// int[] array = new int[size];

// int sum = 0;

// for (int i = 0; i < size; i++) 
// {
//     array[i] = new Random().Next(0, 10);
//     if (i % 2 == 1)
//     {
//        sum= sum + array[i]; 
//     }
    
// }
// Console.WriteLine($"В Массиве: [ {string.Join("; ", array)} ]");
// Console.WriteLine($"в этом масивве сумма элементов, стоящих на нечётных позициях = {sum}");






// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


int size = 3;
double[] array = new double[size];
 Random random = new Random ();
for (int i = 0; i < size; i++) 
{
   array [i] = random.NextDouble()*1000;
Console.WriteLine($"В Массиве: [ {string.Join("; ", array)} ]");
}
int max = 0;
int min = 0;

foreach (int i in array)
{
    if (min> i) min = i;
    if (max< i) max = i;

}


Console.WriteLine($"\n максимальный элемент:{max}\n Минимальный элемент: {min}");
Console.WriteLine($"разница между ними : {max-min}");



