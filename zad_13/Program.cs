using Microsoft.EntityFrameworkCore.Storage;
using System.Diagnostics;
using zad_13;

using (datacontext db = new datacontext()) {
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();
    Random rnd = new Random();

    for (int i = 0; i < 100; i++) {
        db.models.Add(new model { id = i + 1, name = "qwe" + rnd.Next(1, 101) });

    }
    db.SaveChanges();

    Stopwatch sw = Stopwatch.StartNew();

    for (int i = 0; i < 100; i++) {
        int a = rnd.Next(1, 101);
        db.models.FirstOrDefault(x => x.id == a);
    }

    sw.Stop();

    Console.WriteLine((double)sw.ElapsedMilliseconds / 100);
}