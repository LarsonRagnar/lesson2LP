// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber % 7 == 0 && firstNumber % 23 == 0)  // "&&" и то и то "||" или - Логические операторы
{
    Console.WriteLine($"Число {firstNumber} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {firstNumber} не кратно 7 и 23");
    Console.WriteLine($"Остаток от деления числа {firstNumber} на 7 = {firstNumber % 7}");
    Console.WriteLine($"Остаток от деления числа {firstNumber} на 23 = {firstNumber % 23}");
}