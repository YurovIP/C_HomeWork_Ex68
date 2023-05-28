﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

System.Console.WriteLine("Значение m= ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Значение n= ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("m = " + m + "; n = " + n + " -> " + "A(m,n) = " + Akkerman(m, n));