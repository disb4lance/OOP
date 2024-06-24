Nasled[] mas = new Nasled[10];
Nasled[] mas2 = new Nasled[10];
Random rand = new Random();
int count1, count2;
count1 = 0;
count2 = 0;
for (int i = 0; i < 10; i++)
{
    mas[i] = new Nasled (rand.Next(0, 2) == 1 ? true : false, "qwe " + rand.Next(0, 100)) ;
    mas2[i] = new Nasled(rand.Next(0, 2) == 1 ? true : false, "qwe " + rand.Next(0, 100));
    if (mas[i].a == false) count1++;
    if (mas2[i].a == false) count2++;
    Console.WriteLine($"{mas[i].a} | {mas2[i].a}\n");
}

Console.WriteLine(count1 >= count2 ? (count1 > count2 ? "1 масиив\n" : "одинакого\n") : "2 массив\n");
Console.WriteLine($"{count1} {count2}");
class Myclass { 
    public bool? a { get; set; }
    public string b { get; set; }

    public Myclass(bool a, string b)
    {
        this.a = a;
        this.b = b;
    }   
}

class Nasled : Myclass {
    public Nasled(bool a, string b) : base(a, b) { }

}