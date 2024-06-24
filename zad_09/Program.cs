using System;

namespace DelegateExample
{
    // Объявление делегатов
    public delegate void MyDelegate1(int number, string text, bool flag);
    public delegate int MyDelegate2(int[] numbers, double value);

    class qwe
    {
        // Метод, соответствующий делегату MyDelegate1
        public static void Method1(int number, string text, bool flag)
        {
            Console.WriteLine($"Method1 - Number: {number}, Text: {text}, Flag: {flag}");
        }

        // Метод, соответствующий делегату MyDelegate2
        public static int Method2(int[] numbers, double value)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            int result = sum + (int)value;
            Console.WriteLine($"Method2 - Sum: {sum}, Value: {value}, Result: {result}");
            return result;
        }

        static void Main(string[] args)
        {
            // Создание экземпляров делегатов и присваивание методов
            MyDelegate1 del1 = new MyDelegate1(Method1);
            MyDelegate2 del2 = new MyDelegate2(Method2);

            // Вызов методов через делегаты
            Console.WriteLine("Calling Method1 through del1:");
            del1(42, "Hello, World!", true);

            Console.WriteLine("\nCalling Method2 through del2:");
            int result = del2(new int[] { 1, 2, 3, 4, 5 }, 10.5);

            Console.WriteLine($"\nResult from Method2: {result}");
        }
    }
}
