namespace Single_Responsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var cart = new ShoppingCartServices();

            //AddProductToCart(cart);

            //PrintCart(cart);

            //SaveToFile(cart);
        }

        private static void SaveToFile(ShoppingCartServices cart)
        {
            Console.WriteLine();
            Console.WriteLine("====== Save To File ======");
            Console.WriteLine("Writing to file...");
            cart.SaveToFile("cart.json");
        }

        private static void PrintCart(ShoppingCartServices cart)
        {
            Console.WriteLine();
            Console.WriteLine("====== Print cart ======");
            cart.Print(); 
        }

        private static void AddProductToCart(ShoppingCartServices cart)
        {
            Console.WriteLine("====== Add product to cart ======");
            cart.Add(new ShoppingCartModel()
            {
                Price = 1200,
                ProductId = 1,
                Quantity = 1,
                Title = "iPhone 14"
            });
            cart.Add(new ShoppingCartModel()
            {
                Price = 1400,
                ProductId = 1,
                Quantity = 2,
                Title = "iPhone 15"
            });
            Console.WriteLine("Add Success...");

        }
    }
}