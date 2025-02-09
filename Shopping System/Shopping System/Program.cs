using System.Collections;

namespace Shopping_System
{
    internal class Program
    {
        static public List<string> cartItems = new List<string>();
        static public Dictionary<string, double> itemPrices = new Dictionary<string, double>()
        {
            {"Apple", 1.2},
            {"Banana", 0.5},
            {"Orange", 1.0},
            {"Mango", 2.0},
            {"Grapes", 1.5}
        };
        static public Stack<string> undoStack = new Stack<string>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome To The Shopping System");
                Console.WriteLine("==============================");
                Console.WriteLine("1- Add Items To The Cart");
                Console.WriteLine("2- Remove Items From The Cart");
                Console.WriteLine("3- Show Items In The Cart");
                Console.WriteLine("4- Checkout Items");
                Console.WriteLine("5- Undo Last Action");
                Console.WriteLine("6- Exit");
                Console.WriteLine("==============================");
                Console.WriteLine("Enter Your Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addItem();
                        break;
                    case 2:
                        removeItem();
                        break;
                    case 3:
                        viewCart();
                        break;
                    case 4:
                        Checkout();
                        break;
                    case 5:
                        undoAction();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

        }
        private static void addItem()
        {
            Console.WriteLine("Available Items");
            Console.WriteLine("===============");
            foreach (var item in itemPrices)
            {
                Console.WriteLine($"Product : {item.Key} - Price : {item.Value}");
            }
            Console.WriteLine("Enter The Product Name You Want To Purchase");
            string cartItem = Console.ReadLine();

            if (itemPrices.ContainsKey(cartItem))
            {
                cartItems.Add(cartItem);
                undoStack.Push($"Item {cartItem} Is Added");
                Console.WriteLine($"{cartItem} Is Added To Your Cart");
            }
            else
            {
                Console.WriteLine("The Item Is Out Of Stock Or Unavailable");
            }
        }
        private static void removeItem()
        {
            viewCart();
            if (cartItems.Any())
            {
                Console.WriteLine("Enter The Product Name You Want To Remove");
                string cartItem = Console.ReadLine();

                if (cartItems.Contains(cartItem))
                {
                    cartItems.Remove(cartItem);
                    undoStack.Push($"Iten {cartItem} Is Removed");
                    Console.WriteLine($"{cartItem} Is Removed From Your Cart");
                }
                else
                {
                    Console.WriteLine("The Item Is Not In Your Cart");
                }
            }
        }
        private static void viewCart()
        {
            Console.WriteLine("Your Cart Items");
            if (cartItems.Count > 0)
            {
                var itemPricesCollection = getCartPrices();
                foreach (var item in itemPricesCollection)
                {
                    Console.WriteLine($"Product : {item.Item1} - Price : {item.Item2}");
                }
            }
            else
            {
                Console.WriteLine("Your Cart Is Empty");
            }
        }
        private static IEnumerable<Tuple<string, double>> getCartPrices()
        {
            var cartPrices = new List<Tuple<string, double>>();
            foreach (var item in cartItems)
            {
                double price = 0;
                bool searchPrice = itemPrices.TryGetValue(item, out price);

                if (searchPrice)
                {
                    cartPrices.Add(new Tuple<string, double>(item, price));
                }
            }

            return cartPrices;
        }
        private static void Checkout()
        {
            if (cartItems.Any())
            {
                double total = 0;
                Console.WriteLine("Your Cart Items : ");
                var itemPricesCollection = getCartPrices();
                foreach (var item in itemPricesCollection)
                {
                    total += item.Item2;
                }
                Console.WriteLine($"Total Amount To Pay : {total}");
                cartItems.Clear();
                Console.WriteLine("Thank You For Shopping With Us");

                undoStack.Push("Checkout Completed");
            }
            else
            {
                Console.WriteLine("Your Cart Is Empty");
            }
        }
        private static void undoAction()
        {
            if (undoStack.Count > 0)
            {
                string lastAction = undoStack.Pop();
                Console.WriteLine($"Your Last Action Is : {lastAction}");

                var actionArray = lastAction.Split();

                if (actionArray.Contains("Added"))
                {
                    cartItems.Remove(actionArray[1]);
                }
                else if (actionArray.Contains("Removed"))
                {
                    cartItems.Add(actionArray[1]);
                }
                else if (actionArray.Contains("Checkout"))
                {
                    Console.WriteLine("Can't Undo This Action");
                }
                else
                {
                    Console.WriteLine("No Action To Undo");
                }
            }
        }
    }
}