// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введи число, соответствующее дню недели:");
int num = Convert.ToInt32(Console.ReadLine());
if ((num > 7) || (num < 1)) {
    Console.WriteLine($"Число {num} не соответствует дню недели");
}
else {
    switch(num)
    {
        case < 6:
            Console.WriteLine("Это не выходной день");
            break;
        case >= 6:
            Console.WriteLine("Это выходной день");
            break;
    }
    
}

