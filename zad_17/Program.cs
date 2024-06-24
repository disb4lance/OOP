using System;

class Program
{
    static volatile bool enterPressed = false;

    static void Main(string[] args)
    {
        // Запуск метода в отдельном потоке из пула потоков
        ThreadPool.QueueUserWorkItem(ThreadMethod);

        Console.WriteLine("Press Enter to trigger the message. Press Ctrl+C to exit.");

        while (true)
        {
            // Ожидание нажатия Enter
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                enterPressed = true;  // Устанавливаем флаг
            }
        }
    }

    static void ThreadMethod(object state)
    {
        while (true)
        {
            if (enterPressed)
            {
                Console.WriteLine("Enter key pressed!");
                enterPressed = false; // Сбрасываем флаг
            }

            Thread.Sleep(100); // Небольшая задержка для уменьшения нагрузки на процессор
        }
    }
}
