/*Задача 3: Задайте произвольный массив. 
Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.
*/

Random rng = new Random();
//Зададим массив чисел случайной длины
int[] arr = new int[rng.Next(5,21)];

//Заполним этот массив случайными цифрами и напечатаем его
for(int i=0;i<arr.Length;i++)
{
    arr[i] = rng.Next(0,10);
    Console.Write(arr[i]);
}

Console.WriteLine();

RecursiveReversePrint(arr, arr.Length);

/// <summary>
/// Выводит данный массив в обратном порядке на печать с применением рекурсии.
/// </summary>
/// <param name="arr">Выводимый наоборот массив.</param>
/// <param name="pos">Номер элемента массива, с которого начнётся печать.
/// Для полной печати массива задать как поле Length</param>
void RecursiveReversePrint(int[] arr, int pos)
{
    if(pos != 0)
    {
        Console.Write(arr[pos-1]);
        RecursiveReversePrint(arr, pos - 1);
    }
}