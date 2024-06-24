int Size;
while (!int.TryParse(Console.ReadLine(), out Size) || Size <= 0) {
    Console.WriteLine("не верно");
}


int[] mas = new int[Size];
Random rand = new Random();
for (int i = 0; i < Size; i++) {
    mas[i] = rand.Next(1, 100);
    Console.WriteLine(mas[i]);
}
Console.WriteLine(Method.qwe(mas));
class Method {
    public static float qwe(int[] mas) {
        float sum = 0F;
        for (int i = 0; i < mas.Length; i++) { 
            sum += mas[i];
        }
        return sum/mas.Length;
    }
}