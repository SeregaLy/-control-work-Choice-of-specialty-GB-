string[] arr1 = { "Hello", "2", "world", ":-)" };
string[] arr2 = { "1234", "1567", "-2", "computer science" };
string[] arr3 = { "Russia", "Denmark", "Kazan" };

int num = 3;

void SortArray(string[] array, int num)
{
    System.Console.Write($"Массив отсортирован не более {num} символами:\t");
    for (int i = 0; i < array.Length; i++)
    {
        bool IsStringNumeric(char charToCheck) => char.IsLetterOrDigit(charToCheck) || char.IsAscii(charToCheck);
        int count = 0;
        foreach (var el in array[i]) if (IsStringNumeric(el)) count++;
        if (num >= count)
        {
            System.Console.Write("“");
            System.Console.Write($"{array[i]}");
            System.Console.Write("”\t");
        }
    }
    System.Console.WriteLine();
}

SortArray(arr1, num);
SortArray(arr2, num);
SortArray(arr3, num);
