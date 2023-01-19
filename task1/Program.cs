// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

//Без использования массива

Console.WriteLine("Введи трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
if (Math.Abs((num / 100)) < 1) {
    Console.WriteLine("Число не трехзначное");
    System.Environment.Exit(0);
}
Console.WriteLine($"Вторая цифра в числе {num} это - {Math.Abs((num%100)/10)}");

//С массивом

// Console.WriteLine("Введи трехзначное число:");
// string num = Console.ReadLine();
// if (Math.Abs((Convert.ToInt32(num) / 100)) < 1) {
//     Console.WriteLine("Число не трехзначное");
//     System.Environment.Exit(0);
// }
// if ((Convert.ToInt32(num) < 0)) {
//     Console.WriteLine($"Вторая цифра в числе {num} это - {num[2]}");
// }
// else {
//     Console.WriteLine($"Вторая цифра в числе {num} это - {num[1]}");
// }