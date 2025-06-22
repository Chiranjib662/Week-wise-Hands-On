using System;
using System.Linq;

namespace ECommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample product data
            Product[] products = {
                new Product(101, "Laptop", "Electronics"),
                new Product(203, "Shoes", "Footwear"),
                new Product(150, "Smartphone", "Electronics"),
                new Product(404, "T-shirt", "Clothing"),
                new Product(301, "Watch", "Accessories")
            };

            Console.WriteLine("\n🔍 Linear Search for Product ID 150:");
            var result1 = LinearSearch(products, 150);
            Console.WriteLine(result1 != null ? result1.ToString() : "Product not found");

            // Sort the array for binary search
            var sortedProducts = products.OrderBy(p => p.ProductId).ToArray();

            Console.WriteLine("\n🔍 Binary Search for Product ID 150:");
            var result2 = BinarySearch(sortedProducts, 150);
            Console.WriteLine(result2 != null ? result2.ToString() : "Product not found");
        }

        // Linear search implementation
        static Product LinearSearch(Product[] products, int targetId)
        {
            foreach (var product in products)
            {
                if (product.ProductId == targetId)
                    return product;
            }
            return null;
        }

        // Binary search implementation
        static Product BinarySearch(Product[] products, int targetId)
        {
            int left = 0, right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (products[mid].ProductId == targetId)
                    return products[mid];
                else if (products[mid].ProductId < targetId)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return null;
        }
    }
}
