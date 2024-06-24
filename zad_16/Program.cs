using System.Diagnostics;

Random random = new Random();
object lockObject = new object();
double[] elapsedTimes = new double[10];
void Sorting(object? k)
{

    int[] ints = new int[random.Next(10000000, 15000000)];
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = random.Next(0, 1001);
    }




    Array.Sort(ints);

    Stopwatch sw = Stopwatch.StartNew();

    lock (lockObject)
    {
        sw.Stop();
        Console.WriteLine(Array.BinarySearch(ints, k));
    }


    Console.WriteLine(sw.ElapsedMilliseconds);
    elapsedTimes[(int)k - 1] = sw.ElapsedMilliseconds;
}


void Calculate()
{
    Thread.Sleep(5000);
    Array.Sort(elapsedTimes);
    double middle = 0;
    double min = 0;
    for (int i = 0; i < elapsedTimes.Length; i++)
    {
        if (elapsedTimes[i] != 0)
            middle += elapsedTimes[i];
        if (min == 0)
        {
            min = elapsedTimes[i];
        }
    }
    middle /= elapsedTimes.Length;
    Console.WriteLine($"Min time: {elapsedTimes[0]}");
    Console.WriteLine($"Max time: {elapsedTimes[elapsedTimes.Length - 1]}");
    Console.WriteLine($"Middle time: {middle}");
}



Thread myFirstTask;

for (int i = 1; i <= 10; i++)
{
    myFirstTask = new Thread(Sorting);

    myFirstTask.Start(i);

}

Thread mySecondTask = new Thread(Calculate);
mySecondTask.Start();

//Выводит сука все по нулям
