// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


using System;

void Natural(int M, int N, int pos)
    {
        if (M + pos <= N)
        {
            Console.WriteLine((M + pos)+ " ");
            pos++;
            Natural(M,N,pos);
        }
        else
        {
            return;
        }
    }


 Console.Write($"Задайте значение M: ");
int M=Convert.ToInt32(Console.ReadLine());
 Console.Write($"Задайте значение N: ");
int N=Convert.ToInt32(Console.ReadLine());

if(M<N)
    {
        Natural(M,N,0);
    }
else
    {
       Natural(N,M,0);
    }
