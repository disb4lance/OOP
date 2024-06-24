IMyclass x = new Myclass();
IMyclass y = new M();
y.print();
interface IMyclass {

    public void print();
}

class Myclass : IMyclass {

    public  void print() {
        Console.WriteLine("qwefqwe");
    }
}

class M : Myclass {
    public void print()
    {
        Console.WriteLine("qef");   
    }
}