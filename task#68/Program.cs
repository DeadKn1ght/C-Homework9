// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();

int AkkerMan(int numberM, int numberN)
{
    if (numberM == 0)
        return numberN + 1;
    else
        if ((numberM != 0) && (numberN == 0))
            return AkkerMan(numberM - 1, 1);
        else
            return AkkerMan(numberM - 1, AkkerMan(numberM, numberN - 1));
}

Console.WriteLine("Input number M(where M and N are more than 0) :");
int numbM = int.Parse(Console.ReadLine());
Console.WriteLine("Input number N :");
int numbN = int.Parse(Console.ReadLine());
int Akker = AkkerMan(numbM, numbN);
System.Console.WriteLine($"Functionn Akkerman for number M and numbers N is :{Akker}");