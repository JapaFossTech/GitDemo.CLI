// See https://aka.ms/new-console-template for more information
using GitDemo.CLI;
using Northwind.EntityModels;
using PrjBase;

//* Chapter 3

Console.WriteLine("Hello, Git!");

Console.WriteLine(Calculator.Add(2, 3));

//* Chapter 4

WebConfig config = new();
config.OutputAll();

Product product = new()
{
    ProductId = 1,
    CategoryId = 1,
    ProductName = "Chai",
    UnitPrice = 1,
    UnitsInStock = 1,
    Discontinued = false
};

WriteLine("Press enter to exit.");
