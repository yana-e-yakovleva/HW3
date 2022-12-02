//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N. Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
int Number()
{
    Console.WriteLine("Введите число  ");
    bool isNum = int.TryParse(Console.ReadLine(), out int x);
    if (isNum)
    {
        return x;
    }
    else
    {
        Console.WriteLine("Некорректное значение");
        return -1;
    }
}

int x = Number();

int[] GetCube (int x)
{
    int[] array = new int[x];
    for (int i = 0; i < x; i++)
    {
        array[i] = (int)((Math.Pow(i + 1, 3)));
    }
    return array;    
}

int[] Table = GetCube(x);

void PrintArray (int[] arr)
{
    for (int i =0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}



PrintArray(Table);