gun a = new glock();
a.shooot();
a.shoot();

abstract class gun {
    public abstract void shoot();
    public virtual void shooot() { Console.WriteLine("qwef"); }
}

class glock : gun { 
    public override void shoot() { Console.WriteLine("shoot"); }

    public override void shooot() { Console.WriteLine("shooot"); }
}