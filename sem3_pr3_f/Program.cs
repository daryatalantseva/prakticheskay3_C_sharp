﻿/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int[] kub(int N)
{
int[] array = new int[N];
for (int i = 0; i <array.Length; i++)
{
array[i]=Convert.ToInt32(Math.Pow(i+1,3));
}
return array;
}

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < kub(N).Length; i++ )
{
    Console.Write(kub(N)[i] + " ");
}


