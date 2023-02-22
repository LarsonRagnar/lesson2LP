// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100, 1000);

int result = (number / 100) * 10 + (number % 10); // Для числа 472 (number / 100) * 10 = 4
Console.WriteLine("Исходное число " + number + " Первая и третья цифра это " + result);


// Строчка

// string message =Console.ReadLine();

// Console.WriteLine(message[0]+ "" + message[2] );

