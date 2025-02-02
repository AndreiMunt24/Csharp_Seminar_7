﻿// Задача 2: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


  void Main()
    {
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        int result = Ackermann(m, n);
        Console.WriteLine($"Ackermann({m}, {n}) = {result}");
    }

   int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
Main();
