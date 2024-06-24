using System;
using System.Reflection;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса MyClass
            MyClass myClassInstance = new MyClass();

            // Получаем тип класса MyClass
            Type myClassType = typeof(MyClass);

            // Получаем информацию о приватном методе PrintMessage
            MethodInfo printMessageMethod = myClassType.GetMethod("PrintMessage", BindingFlags.NonPublic | BindingFlags.Instance);

            if (printMessageMethod != null)
            {
                // Вызываем приватный метод PrintMessage
                printMessageMethod.Invoke(myClassInstance, new object[] { "Hello from the private method!" });
            }
            else
            {
                Console.WriteLine("Приватный метод не найден.");
            }
        }
    }

    public class MyClass
    {
        // Приватный метод, который выводит сообщение на консоль
        private void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
