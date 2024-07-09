// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.

void Main()
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine($"Числа в промежутке от {M} до {N}:");
        PrintNumbers(M, N);
    }
 void PrintNumbers(int M, int N)
    {
        if (M > N)
        {
            return;
        }
        
        Console.Write(M);
        if (M < N)
        {
            Console.Write(", ");
        }
        PrintNumbers(M + 1, N);
    }
Main();
