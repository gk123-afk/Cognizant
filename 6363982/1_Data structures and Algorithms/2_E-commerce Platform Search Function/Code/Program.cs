using System;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {ProductId}, Name: {ProductName}, Category: {Category}");
    }
}

class ECommerceSearch
{
    
    public static Product LinearSearch(Product[] products, int targetId)
    {
        foreach (var product in products)
        {
            if (product.ProductId == targetId)
                return product;
        }
        return null;
    }

   
    public static Product BinarySearch(Product[] products, int targetId)
    {
        int left = 0, right = products.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (products[mid].ProductId == targetId)
                return products[mid];
            else if (products[mid].ProductId < targetId)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return null;
    }

    static void Main()
    {
        Product[] products = new Product[]
        {
            new Product(103, "i phone", "Electronics"),
            new Product(208, "Sandals", "Footwear"),
            new Product(473, "clock", "Accessories"),
            new Product(312, "lenovo legion laptop", "Electronics"),
            new Product(593, "bag", "Travel")
        };

       
        Array.Sort(products, (a, b) => a.ProductId.CompareTo(b.ProductId));

        int searchId = 312;

        Console.WriteLine("=== Linear Search ===");
        Product foundLinear = LinearSearch(products, searchId);
        if (foundLinear != null)
            foundLinear.Display();
        else
            Console.WriteLine("Product not found");

        Console.WriteLine("=== Binary Search ===");
        Product foundBinary = BinarySearch(products, searchId);
        if (foundBinary != null)
            foundBinary.Display();
        else
            Console.WriteLine("Product not found");
    }
}
