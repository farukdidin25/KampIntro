// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Product product1 = new Product();
product1.ProductName = "Mouse";
product1.ProductCode = 001;
product1.ProductSale = 619;

Product product2 = new Product();
product2.ProductName = "Klavye";
product2.ProductCode = 002;
product2.ProductSale = 548;

Product product3 = new Product();
product3.ProductName = "Kulaklık";
product3.ProductCode = 003;
product3.ProductSale = 349;

Product[] products = new Product[] { product1, product2, product3 };

foreach (Product product in products)
{
    Console.WriteLine(product.ProductName);
}






class Product
{
    public string ProductName { get; set; }
    public int ProductCode { get; set; }
    public int ProductSale { get; set; }
}