﻿/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSumOfInterval(M, N));

int GetSumOfInterval(int M, int N)
{
	int sum = N;
	if (N <= M) return sum;
	return (sum+GetSumOfInterval(M, N-1));
}