// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Без использования массива

Console.WriteLine("Введи число:");
int num = Convert.ToInt32(Console.ReadLine());
int bigNum = num; //чтобы сохранить изначальное число, если оно было больше 1000
if (Math.Abs((num / 100)) < 1) {
    Console.WriteLine($"У числа {num} нет третьей цифры");
    System.Environment.Exit(0);
}
else if (Math.Abs((num / 1000)) < 1) {
    Console.WriteLine($"Третья цифра в числе {num} это - {Math.Abs(num%10)}");
}
else {
    while ((Math.Abs(num / 1000)) >=1)
    {
        num = num / 10;
    }
    Console.WriteLine($"Третья цифра в числе {bigNum} это - {Math.Abs(num%10)}");
}

//С массивом

// Console.WriteLine("Введи число:");
// string num = Console.ReadLine();
// if (Math.Abs((Convert.ToInt32(num) / 100)) < 1) {
//     Console.WriteLine($"У числа {num} нет третьей цифры");
//     System.Environment.Exit(0);
// }
// if ((Convert.ToInt32(num) < 0)) {       
//     Console.WriteLine($"Третья цифра в числе {num} это - {num[3]}");
// }
// else {
//     Console.WriteLine($"Третья цифра в числе {num} это - {num[2]}");
// }
