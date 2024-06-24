MyClass a = new MyClass(3, 4);
MyClass b = new MyClass(3, 4);
MyClass c = a + b;
Console.WriteLine(c.a);
class MyClass {
    public int a;
    public int b;
    public MyClass(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public static MyClass operator +(MyClass a, MyClass b){
        return new MyClass(a.a + b.a, b.a + b.b);
        }
}