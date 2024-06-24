MyClass<int> a = new MyClass<int>();
MyClass<string> b = new MyClass<string>();
b.print();

class MyClass<T> {
    public void print() { 
        Console.WriteLine(typeof(T).Name);
    }
}