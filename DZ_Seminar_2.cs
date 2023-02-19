/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

Console.WriteLine("Введите трехзначное число");
int stringNumber = Convert.ToInt32(Console.ReadLine());
int (length) = stringNumber.Length;
int (N);
if (length = 3)
    {
        N = (stringNumber/10%10);
        Console.ReadLine (N);
    }
else
    {
        Break
    }
/*
/*Задача 13: Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, что третьей цифры нет.
*/

/*Console.WriteLine("Введите семизначное число");
int stringNumber = Convert.ToInt32(Console.ReadLine());
int (length) = stringNumber.Length;
if (Length<3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.ReadLine (stringNumber(3));
    Console.ReadLine (stringNumber(4));
}
ДОП: цифра третья может быть как с левой стороны, так и с правой. 31 строчка печатает 3 цифры с левй стороны.

*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/
/*Console.WriteLine("Введите цифру, обозначающую день недели:");
int stringNumber = Convert.ToInt32(Console.ReadLine());
if (stringNumber>5)
{
    Console.WriteLine ("Цифра, введенная Вами обозначает выходной");
}
else
{
    Console.WriteLine ("Цифра, введенная Вами не обозначает выходной");
}
*/