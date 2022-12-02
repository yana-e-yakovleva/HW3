//
Console.WriteLine("Введите число: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (!isParsed){Console.WriteLine("некорректное число"); return;}
else {return number;}

int[] array = number.Length; // Как массиву присвоить значение введенного числа?

if (number == 5)
{
    if (array[0] == array[4] && array[1] == array[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }}

