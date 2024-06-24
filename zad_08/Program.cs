using System;

Myclass x = new Myclass(12, "qwef");
MyGeneric<Myclass> y = new MyGeneric<Myclass>();
y.y(x);

Myclass2 n = new Myclass2(1234, "qwef");
MyGeneric<Myclass2> m = new MyGeneric<Myclass2>();



class Myclass { 
    public int x;
    public string y;

    public Myclass(int x, string y) { 
        this.x = x; this.y = y;
        }
}

class Myclass2 : Myclass
{
    public Myclass2(int x, string y) : base(x, y) {}
}

class MyGeneric<T> where T : Myclass { 
    public T x;

    public void y(T x)
    {
        Console.WriteLine("qweqe");
    }

}