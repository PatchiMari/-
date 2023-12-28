// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;
int A(int M, int N)
{
    if(M==0)
    {
        return N+1;
    }
    else {
        if (N==0)
        {
            return A(M-1,1);
        }
        else 
        {
            return A(M-1,A(M,N-1)); 
        }
         }

}

Console.Write($"Задайте значение M: ");
int M=Convert.ToInt32(Console.ReadLine());
 Console.Write($"Задайте значение N: ");
int N=Convert.ToInt32(Console.ReadLine());

Console.Write($"Функция Аккермана = {A(M,N)}");