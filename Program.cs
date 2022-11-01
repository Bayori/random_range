using System;

namespace random_range
{

    class Program
    {
        static int doRandom(int _startRange, int _endRange)
        {
            int _result;
            Random _rand = new Random(); // Создание объекта рандомизации
            _result = _rand.Next(_startRange, _endRange);
            return _result; // Возвращение результата в Main
        }
        static void Main(string[] args)
        {
            int _startRange, _endRange;

            Console.WriteLine("Введите диапозон чисел [От меньшего к большему]");
            _startRange = Convert.ToInt32(Console.ReadLine()); // Ввод
            _endRange = Convert.ToInt32(Console.ReadLine());

            if (_startRange >= _endRange) // Проверка на корректность указания диапозона
            {
                Console.WriteLine("[Ошибка] Первое число не может быть больше или равно второму");
                return;
            }

            Console.WriteLine("\nСлучайное число в указанном диапозоне: " + doRandom(_startRange, _endRange)); // Запрос к методу doRandom и вывод результата
        }
    }
}
