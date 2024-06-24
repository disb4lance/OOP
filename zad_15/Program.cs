using System.Diagnostics;

Random random = new Random();
long[] elapsedTimes = new long[10];
void Sorting(object? k)
{

    int[] ints = new int[random.Next(10000000, 15000000)];
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = random.Next(0, 1001);
    }


    Stopwatch sw = Stopwatch.StartNew();
    Array.Sort(ints);
    sw.Stop();
    Console.WriteLine(sw.ElapsedMilliseconds);
    elapsedTimes[(int)k - 1] = sw.ElapsedMilliseconds;
}

Thread thread;

for (int i = 0; i < 10; i++) {
    thread = new Thread(Sorting);
    thread.Start(random.Next(1, 1001));
}

