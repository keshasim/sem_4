// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 0; i <= b; i++)
// {
//     result = i * a;
// }
// Console.WriteLine($"Число {a} в степени {b} = " + Math.Pow(a, b));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число: "); 
// int number,a,b,sum=0; 
// number = Convert.ToInt32(Console.ReadLine()); 
 
// for(b=number;number!=0;number=number/10) 
// { 
// a=number % 10; 
// sum=sum+a; 
// } 
 
// Console.Write($"Сумма цифр в числе {b} = {sum}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int size = 8;
// int[] array = new int[size]; 
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(10, 1000); 
// }
// Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");