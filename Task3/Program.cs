// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, 
// не использовать циклы.

    static void Main()
    {
        Console.WriteLine("Введите элементы массива, разделенные пробелами:");
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        if (index < 0)
        {
            return;
        }

        Console.Write(array[index]);
        if (index > 0)
        {
            Console.Write(" ");
        }
        PrintArrayReverse(array, index - 1);
    }
Main();