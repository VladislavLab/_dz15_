//Задача 15: Напишите программу, которая принимает на вход
//цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите номер дня недели  ");
int num = int.Parse(Console.ReadLine()!);

if (num ==7 || num==6)
{
      Console.WriteLine(" Выходной  день");
}
else
{
      Console.WriteLine("Рабочий день");
}
