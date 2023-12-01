//  Задание 1:Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }


// Задание 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Console.Write("Введите координаты точки X ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки Y ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x>0 && y>0)
// {
//     Console.WriteLine("1");
// }
// if (x<0 && y>0)
// {
//     Console.WriteLine("2");
// }
// if (x<0 && y<0)
// {
//     Console.WriteLine("3");
// }
// if (x>0 && y<0)
// {
//     Console.WriteLine("4");
// }
// else
// {
//     Console.WriteLine("Точка находится на оси координат");
// }


// Задание 3:Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 9 && number < 100) // [10;99]
// {
//     int firstDigit = number / 10; // 12 / 10 => 1
//     int secondDigit = number % 10; // 12 % 10 => 2
//     int maxDigit = firstDigit; // Пусть максимум - 1
//     if (secondDigit > maxDigit) //  2 > 1, max = 2
//     {
//         maxDigit = secondDigit;
//     }
//     Console.WriteLine($"Максимальная цифра в числе {number} => {maxDigit}");
// }
// // $"Текст {переменная} текст"
// else
// {
//     Console.WriteLine("Вы ввели некорректное число :( ");
// }


// Задание 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string digits = String.Empty; // " "
// while (number > 0)
// {
//     digits = number % 10 + " , " + digits;
//     number = number / 10;
// }
// Console.WriteLine(digits);