/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int [] GetArray(string message)
{
    Console.WriteLine(message);
    string str = Console.ReadLine();
    string[] strArray = str.Split(',');

    int[] intArray = new int[strArray.Length];
    
    for (int i = 0; i < intArray.Length; i++)
    {
        intArray[i] = Convert.ToInt32(strArray[i]);
    }
    return intArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int CountPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int [] arr = GetArray("Введите целые числа через запятую: ");
PrintArray(arr);


Console.WriteLine($"Количество чисел больше 0 равно {CountPositive(arr)}");