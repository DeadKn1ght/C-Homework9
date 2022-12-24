// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int SummNaturNumbers(int numberM, int numberN,int summ)
{   
    if (numberM <= numberN)
    {
       summ= numberM + SummNaturNumbers(numberM+1, numberN,summ);
    }
    return summ;
}

Console.WriteLine("Input number M(where M is more than N) :");
int numbM = int.Parse(Console.ReadLine());
Console.WriteLine("Input number N :");
int numbN = int.Parse(Console.ReadLine());
int summ = 0;
if(numbN>numbM)
{
int Summ = SummNaturNumbers(numbM, numbN,summ);
System.Console.WriteLine("Summ of all elements between M and N are :");
System.Console.WriteLine($"{Summ}");
}
else System.Console.WriteLine("You input incorrect numbers M and N");