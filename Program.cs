namespace CodingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome To Invoice Console App");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Debug Squad Team");

            // **************** CREATING PRODUCT CLASS ARRAY AND DISPLAY***************

            Product[] products = new Product[6];
            DisplayProducts(products);




        }

        // ******************** DISPLAYING PRODUCTS *******************
        public static void DisplayProducts(Product[] products)
        {
            products[0] = new Product("Iphone", 5000, 20);
            products[1] = new Product("Samsung", 4000, 10);
            products[2] = new Product("Oneplus", 4000, 40);
            products[3] = new Product("Xiaomi", 3000, 20);
            products[4] = new Product("Oppo", 3000, 10);
            products[5] = new Product("Nokia", 4000, 15);



            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Product Name: {products[i].productName} {new string(' ', 10)} Product Price: ${products[i].productPrice} {new string(' ', 10)} Product Quantity: {products[i].productQuantity}");
            }
            Console.ResetColor();
        }
    }

    class Product
    {
        public string productName;
        public double productPrice;
        public int productQuantity;

        public Product(string productName, double productPrice, int productQuantity)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
        }
    }
}