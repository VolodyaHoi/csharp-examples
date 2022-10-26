// Работа с математическими операциями

int a, b; // обьявление переменных для ввода

Console.WriteLine("Введите первое число: "); // ввод чисел
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("{0} делить на {1}: {2}", a, b, a / b); // целое деление
Console.WriteLine("{0} умножить на {1}: {2}", a, b, a * b); // умножение
Console.WriteLine("{0} сложить с {1}: {2}", a, b, a + b); // сложение
Console.WriteLine("Из {0} вычести {1}: {2}", a, b, a - b); // вычитание
Console.WriteLine("Остаток деления {0} на {1}: {2}", a, b, a % b); // получение остатка


