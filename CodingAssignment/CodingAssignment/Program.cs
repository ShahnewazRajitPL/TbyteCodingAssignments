﻿using System.Globalization;

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

            List<SelectedProducts> selectedProducts = new List<SelectedProducts>();

            // ***************** CHOOSING PRODUCTS ******************
            buyProducts(selectedProducts, products);

            // **************** DISPLAYING SELECTED PRODUCT WHICH USER WANT TO BUY ***************

            displaySelectedProducts(selectedProducts);

            Console.WriteLine();

            //********************** TAKING INFORMATION FROM USER *******************
            takingUserInfo(selectedProducts);



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


        // ******************** BUY PRODUCTS *******************
        public static void buyProducts(List<SelectedProducts> selectedProducts, Product[] products)
        {
            while (true)
            {
                Console.Write("Write the name of the product you want to buy (done to skip): ");
                string select = Console.ReadLine();
                if (select?.ToLower().Equals("done") == true)
                {
                    break;
                }
                int flag = 0;
                for (int i = 0; i < products.Length; i++)
                {
                    if (select?.ToLower().Equals(products[i].productName.ToLower()) == true)
                    {
                        flag = 1;
                        Console.Write("Enter the quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        if (quantity > products[i].productQuantity)
                        {
                            Console.WriteLine("We don't have enough quantity of this product");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            products[i].productQuantity = products[i].productQuantity - quantity;
                            selectedProducts.Add(new SelectedProducts(products[i].productName, products[i].productPrice, quantity));
                        }
                    }
                }

                if (flag == 1)
                {
                    Console.Write("Do you want to add more? (yes/no): ");
                    string decision = Console.ReadLine();
                    if (decision?.Equals("yes") == true)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (flag == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your product name is invalid, please correct it!!");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }

        //********************** DISPLAYING SELECTED PRODUCTS *********************

        public static void displaySelectedProducts(List<SelectedProducts> selectedProducts)
        {
            if (selectedProducts.Count >= 1)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Selected products are: ");
                Console.ResetColor();

                for (int i = 0; i < selectedProducts.Count; i++)
                {
                    Console.WriteLine($"Product Name: {selectedProducts[i].productName} {new string(' ', 6)} Product Price: ${selectedProducts[i].productPrice} {new string(' ', 6)} Product Quantity: {selectedProducts[i].productQuantity}");
                }
            }
        }

        // ************************* TAKE INFORMATION FROM USER *********************

        public static void takingUserInfo(List<SelectedProducts> selectedProducts)
        {
            Console.Write("Are you sure to buy these products? (yes/no): ");
            string buyEnsure = Console.ReadLine();
            Console.WriteLine();

            if (buyEnsure?.ToLower().Equals("yes") == true)
            {
                System.Console.Write("Enter your first Name: ");
                string firstName = Console.ReadLine();
                System.Console.Write("Enter your last Name: ");
                string lastName = Console.ReadLine();
                System.Console.Write("Enter your email address: ");
                string email = Console.ReadLine();
                System.Console.Write("Enter your address: ");
                string address = Console.ReadLine();
                System.Console.Write("Enter your date of birth:(d-m-y): ");
                string dob = Console.ReadLine();



                Console.WriteLine();
                System.Console.WriteLine("---------------- Here is your Invoice ----------------");
                System.Console.WriteLine("*************** User Information: *****************");
                System.Console.WriteLine($"Name: {firstName} {lastName} {new string(' ', 7)} Email: {email}");

                System.Console.WriteLine($"Address: {address} {new string(' ', 7)} Date of Birth: {dob}");

                System.Console.WriteLine("*************** Total amount *****************");
                double totalAmount = 0;
                for (int i = 0; i < selectedProducts.Count; i++)
                {
                    totalAmount = totalAmount + (selectedProducts[i].productPrice * selectedProducts[i].productQuantity);
                    System.Console.WriteLine($"Product Name: {selectedProducts[i].productName} {new string(' ', 5)} Product Price: ${selectedProducts[i].productPrice} {new string(' ', 5)} Product Quantity: {selectedProducts[i].productQuantity} {new string(' ', 5)} Amount: ${selectedProducts[i].productPrice * selectedProducts[i].productQuantity}");
                }

                System.Console.WriteLine("--------------------------------------------------------------------------------------");

                System.Console.WriteLine($"Total Amount: {totalAmount + ((totalAmount * 2) / 100)} (2% vat included)");
                System.Console.WriteLine();

                



            }
            else
            {
                Console.WriteLine("Thank you for your response");
            }
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


    class SelectedProducts
    {
        public string productName;
        public double productPrice;
        public int productQuantity;

        public SelectedProducts(string productName, double productPrice, int productQuantity)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
        }
    }








}