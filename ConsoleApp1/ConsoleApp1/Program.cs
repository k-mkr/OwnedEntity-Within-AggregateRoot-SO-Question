// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;

AppDbContext context = new AppDbContext();

context.Database.EnsureDeleted();
context.Database.Migrate();

Document document = new Document();
document.IncrementVersison();
document.IncrementVersison();

context.Documents.Add(document);

context.SaveChanges();
context.ChangeTracker.Clear();

var document2 = context.Documents.Single();
document2.IncrementVersison();

context.SaveChanges();
context.ChangeTracker.Clear();

var document3 = context.Documents.Single();

Console.ReadKey();