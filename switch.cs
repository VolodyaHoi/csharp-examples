// Использование switch

int num; // Обьявление переменной номера месяца

Console.WriteLine("Введите номер месяца: "); // Ввод номера месяца
num = Convert.ToInt32(Console.ReadLine());

while ( num > 12 && num > 0) // проверка на промежуток с 1 до 12
{
    Console.WriteLine("Неверный номер месяца! Введите еще раз: "); // в случае,если введенное значение не соответствует номеру месяца,ввести еще раз
    num = Convert.ToInt32(Console.ReadLine());
}

switch(num) // switch -
            // в скобках указывается переменная, взависимости значения которой будет                 
            // выполняться какое либо действие,в данном случае вывод месяца 
                                                                            
{
    case 1:
        Console.WriteLine("Январь"); // вывод месяца
        break;

    case 2:
        Console.WriteLine("Февраль");
        break;

    case 3:
        Console.WriteLine("Март");
        break;

    case 4:
        Console.WriteLine("Апрель");
        break;

    case 5:
        Console.WriteLine("Май");
        break;

    case 6:
        Console.WriteLine("Июнь");
        break;

    case 7:
        Console.WriteLine("Июль");
        break;

    case 8:
        Console.WriteLine("Август");
        break;

    case 9:
        Console.WriteLine("Сентябрь");
        break;

    case 10:
        Console.WriteLine("Октябрь");
        break;

    case 11:
        Console.WriteLine("Ноябрь");
        break;

    case 12:
        Console.WriteLine("Декабрь");

        break;
}
