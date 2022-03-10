// See https://aka.ms/new-console-template for more information
using OOP1;

Product product1 = new Product();
product1.Id = 001;
product1.CategoryId = 02;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitInStock = 3;

Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitInStock = 5, UnitPrice = 35 };

ProductManager productManager = new ProductManager();
productManager.Add(product1);


productManager.Topla2(2, 6);
int toplamaSonucu = productManager.Topla(2, 6);
Console.WriteLine(toplamaSonucu*2);




