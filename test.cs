using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строки через пробел или запятую:");
        string[] inputArray = Console.ReadLine().Split(',', ' ');

        string[] resArray = FilterArray(inputArray);
        resArray = resArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();
        resArray = resArray.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();


        Console.WriteLine("Результат:");
        PrintArray(resArray);
    }

    static string[] FilterArray(string[] inputArray)
    {
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] resArray = new string[count];
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resArray[index] = str;
                index++;
            }
        }

        return resArray;
    }

    static void PrintArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"\"{array[i]}\"");
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}
