//Console.Write("Введіть перше число: ");
//int number1 = int.Parse(Console.ReadLine());

//Console.Write("Введіть друге число: ");
//int number2 = int.Parse(Console.ReadLine());
//int month, day;
//if (number1 <= 12 && number2 <= 31)
//{
//    month = number1;
//    day = number2;
//}
//else if (number2 <= 12 && number1 <= 31)
//{
//    month = number2;
//    day = number1;
//}
//else
//{
//    Console.WriteLine("Ці числа не можуть бути днем та місяцем.");
//    return;
//}



//Console.Write("Введіть число: ");
//float number = float.Parse(Console.ReadLine());
//int twoDigits = (int)(number * 100) % 100;
//int digit1 = twoDigits / 10;
//int digit2 = twoDigits % 10;
//Console.WriteLine($"{digit1} + {digit2} = {digit1 + digit2}");



//Console.Write("Введіть число: ");
//int time = int.Parse(Console.ReadLine());
//if ((time >= 0 && time <= 5) || (time < 22 && time >= 24))
//{
//    Console.WriteLine("Доброї ночі!");
//}
//else if (time >= 5 && time < 12) 
//{
//    Console.WriteLine("Доброго ранку!");
//}
//else if (time >= 12 && time < 18) 
//{
//    Console.WriteLine("Доброго дня!");
//}
//else if (time >= 18 && time < 22) 
//{
//    Console.WriteLine("Доброго вечора!");
//}
//else
//{
//    Console.WriteLine("Некоректний час!");
//}

//Console.Write("Введіть число 1: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Введіть число 2: ");
//int num2 = int.Parse(Console.ReadLine());
//Console.Write("Введіть число 3: ");
//int num3 = int.Parse(Console.ReadLine());
//int max = num1;
//int min = num1;
//if (num2 > max) max = num2;
//if (num3 > max) max = num3;
//if (num2 < min) min = num2;
//if (num3 < min) min = num3;
//Console.WriteLine($"Максимальне число: {max}");
//Console.WriteLine($"Мінімальне число: {min}");



//Console.Write("Введіть ширину: ");
//double width = double.Parse(Console.ReadLine());
//Console.Write("Введіть довжину: ");
//double length = double.Parse(Console.ReadLine());
//Console.WriteLine(length*width);



//Console.Write("Введіть число ");
//int Number = int.Parse(Console.ReadLine());
//if (Number % 2 == 0)
//{
//    Console.WriteLine("Парне");
//}
//else
//{
//    Console.WriteLine("Непарне");
//}


//Console.Write("Введіть температуру в градусах Цельсія: ");
//double celsius = Convert.ToDouble(Console.ReadLine());
//double fahrenheit = (celsius * 9 / 5) + 32;
//Console.WriteLine($"Температура у градусах Фаренгейта: {fahrenheit}");


Console.Write("Введіть число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int suma = n * (n + 1) / 2; // формула суми 1 + 2 + ... + n

Console.WriteLine($"Сума перших {n} натуральних чисел дорівнює: {suma}");


