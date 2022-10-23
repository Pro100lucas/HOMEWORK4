 // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int a = int.Parse(Console.ReadLine());
while ( a < 1 || a > 7)
{
 Console.WriteLine("укажите значение в диапазоне 1 - 7 ");
 a = int.Parse(Console.ReadLine());
}
if ( a < 6 )
{
Console.WriteLine(" Рабочий день ");
}
else 
{
Console.WriteLine(" Выходной день ");
}