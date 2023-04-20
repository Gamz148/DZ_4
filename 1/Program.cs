// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("введите число A:");
int A = int.Parse(Console.ReadLine());

System.Console.WriteLine("введите число B:");
int B = int.Parse(Console.ReadLine());


System.Console.WriteLine($"число {A} в степени {B} = {Math.Pow(A, B)}");