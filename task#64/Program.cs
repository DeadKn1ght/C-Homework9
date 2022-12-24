// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int NaturNumbers(int i, int numb)
{
    if ( i < numb)
    {
        System.Console.Write($"{NaturNumbers(i+1, numb)}, ");
    }
       return i;
}


Console.WriteLine("Input number N :");
int numberN = int.Parse(Console.ReadLine());
int i = 1;

int Natur = NaturNumbers(i, numberN);
System.Console.WriteLine($"{Natur}");