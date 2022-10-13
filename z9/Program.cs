// =============== Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Recurs(N, 1));

string Recurs(int n, int minValue)
{
    if (n == minValue)
    {
        return n.ToString();               //преобразование int в string
    }
    return (n + "," + Recurs(n - 1, minValue));
}





// // =================== Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30


// Console.Clear();
// Console.Write("Введите значение M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(SumRecurs(M,N));

// int SumRecurs(int m, int n)
// {
//     if (m == n)
//     {
//         return m;
//     }
//     return (m + SumRecurs(m + 1, n));
// }



// // ============================ Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9
// // m = 3, n = 2 -> A(m,n) = 29


// Console.Clear();
// Console.Write("Введите неотрицательное число M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите неотрицательное число  N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(AkkRecurs(M, N));

// int AkkRecurs(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if ((m > 0) && (n == 0))
//     {
//         return AkkRecurs(m - 1, 1);
//     }
//     else if ((m > 0) && (n > 0))
//     {
//         return AkkRecurs(m - 1, AkkRecurs(m, n - 1));
//     }
//     return n + 1;
// }

