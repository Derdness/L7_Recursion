/*Задача 2: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/


int m = 3;
int n = 2;

Console.WriteLine(AckermannFunction(m,n));

///<summary>
///Всюду определённая вычислимая функция, 
///которая не является примитивно рекурсивной.
/// <param name="m">Целое число.</param>
/// <param name="n">Целое число.</param>
int AckermannFunction(int m, int n)
{
    if(m == 0)
        return n + 1;
    else if(n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
        return AckermannFunction(m - 1,AckermannFunction(m,n - 1));
}