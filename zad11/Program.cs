ExampleDelegate x = Metods.method1;
ExampleDelegate2 y = Metods.method2;
ExampleDelegate z = () => Console.WriteLine("3 метод");

qwe a = new qwe();
a.Subs(x);
a.Subs(y);
a.Subs(z);
a.Trigger(x);
a.Trigger(y);
a.Trigger(z);
a.Subs(x);
a.Subs(y);
a.Subs(z);
a.print();

public delegate void ExampleDelegate();
    public delegate int ExampleDelegate2();
    class qwe
{
        public event ExampleDelegate Event1;
        public event ExampleDelegate2 Event2;

    public void print() {
        Event1();
        Event2();
    }
        public void Subs(ExampleDelegate x)
        {
            Event1 += x;
            Console.WriteLine($"{x.Method.Name} подписался на событие Event1");
        }

        public int Subs(ExampleDelegate2 x)
        {
            Event2 += x;
            Console.WriteLine($"{x.Method.Name} подписался на событие Event2");
            return 0;
        }

        public int Trigger(ExampleDelegate2 x)
        {
            Event2 -= x;
            Console.WriteLine($"{x.Method.Name} отписался Event2");
            return 0;
        }
        public int Trigger(ExampleDelegate x)
        {
            Event1 -= x;
            Console.WriteLine($"{x.Method.Name} отписался Event1");
            return 0;
        }
    }
    class Metods
    {
        public static void method1()
        {
            Console.WriteLine("метод 1");
        }

        public static int method2()
        {
            Console.WriteLine("метод 2");
            return 0;
        }
    }

