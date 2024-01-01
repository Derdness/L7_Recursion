/*Задача 1: Задайте значения M и N. 
Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
*/

Random rng = new Random();
int m = rng.Next(51);
int n = rng.Next(51,101);
Console.WriteLine($"Промежуток: [{m}, {n}]");
RecursiveCount(m,n);

///<summary>
///Выводит все числа в (закрытом) промежутке от from до to
///в строку через пробелы.
///Значение начала промежутка должно быть меньше
///значения конца интервала.
///</summary>
/// <param name="from">Начало интервала.</param>
/// <param name="num">Конец интервала.</param>
void RecursiveCount(int from, int to)
{
    if(from<to)
    {
        Console.Write($"{from} ");
        RecursiveCount(++from, to);
    }
    else
    {
        Console.WriteLine(to);
    }
}