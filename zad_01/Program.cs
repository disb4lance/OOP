using System;

using zad_01;

int count;

while (!int.TryParse(Console.ReadLine(), out count) || count <= 0) {
    Console.WriteLine("не верно");
}

classes[] mas = new classes[count];
Random rand = new Random();

for (int i = 0; i < count; i++)
{
    mas[i] = new classes(rand.Next(1, 100), "qwe" + rand.Next(1, 100));
}

foreach (classes item in mas) {
    Console.WriteLine($"{item.a}, {item.b}");
}