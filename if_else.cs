// Работа  условиями if-else

int comNumber; // обьявление переменной номера команды

Console.WriteLine("Введите команду:\n1. Start\n2.Finish"); // ввод номера команды
comNumber = Convert.ToInt32(Console.ReadLine());

if ( comNumber == 1 ) { // проверка условия. if - если условие верно, выполняются команды в фигурных скобках
  Console.WriteLine("Программа запущена!");
}
else if ( comNumber == 2 ) { // else-if - условие выполняется в случае если первое условие провалено
  Console.WriteLine("Программа завершена");
}
else { Console.WriteLine("Неверная команда!"); } // else - выполняется в случае если все условия провалены

