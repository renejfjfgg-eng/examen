using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== ИГРА «УГАДАЙ ЧИСЛО» =====");
        Console.WriteLine("Я загадал число от 1 до 50. Попробуй угадать!\n");

        // Загадываем случайное число
        Random random = new Random();
        int secretNumber = random.Next(1, 51); // от 1 до 50 включительно

        int guess = 0;
        int attempts = 0;

        // Игровой цикл
        while (guess != secretNumber)
        {
            Console.Write("Введи число: ");

            // Проверка корректности ввода
            if (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Ошибка! Введите целое число.");
                continue;
            }

            // Проверка диапазона
            if (guess < 1 || guess > 50)
            {
                Console.WriteLine("Число должно быть от 1 до 50!");
                continue;
            }

            attempts++;

            // Подсказки
            if (guess < secretNumber)
            {
                Console.WriteLine("→ Загаданное число БОЛЬШЕ\n");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("→ Загаданное число МЕНЬШЕ\n");
            }
        }

        // Победа
        Console.WriteLine("==================================");
        Console.WriteLine($"🎉 ПОЗДРАВЛЯЮ! Ты угадал число {secretNumber}!");
        Console.WriteLine($"Количество попыток: {attempts}");

        // Оценка результата
        if (attempts <= 3)
            Console.WriteLine("🏆 Отличный результат!");
        else if (attempts <= 6)
            Console.WriteLine("👍 Хороший результат!");
        else
            Console.WriteLine("😊 Попробуй ещё раз улучшить результат!");

        Console.WriteLine("\nНажми любую клавишу для выхода...");
        Console.ReadKey();
    }
}