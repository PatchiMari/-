// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

Random rand = new Random();
 int [] Array = new int [rand.Next(1,101)];
    for(int i =0; i<Array.GetLength(0); i++)
        {
            Array[i]= rand.Next(100);
            Console.Write(Array[i]+ " ");
        }

Console.WriteLine(" => ");

void Natural(int M, int N, int pos)
    {
        if (M + pos >= 0)
        {
            Console.Write((Array[M+pos])+ " ");
            pos--;
            Natural(0,Array.GetLength(0)-1, pos);
        }
        else
        {
            return;
        }
    }

Natural(0,Array.GetLength(0)-1, Array.GetLength(0)-1);