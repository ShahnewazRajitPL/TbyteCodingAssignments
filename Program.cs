namespace CodingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome To Invoice Console App");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Debug Squid Team");

            
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