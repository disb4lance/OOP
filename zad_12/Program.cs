using zad_12;

using (datacontext db = new datacontext()) {
    db.models.Add(new model{ id = 2, name = "qwe" });
    db.SaveChanges();
    foreach (var model in db.models)
    {
        Console.WriteLine(model.name);
    }
}