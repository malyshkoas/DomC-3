// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0, num = number;
while (number > 0) 
{
    i = i * 10 + number % 10; 
    number /= 10;
}
if (num == i)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}
