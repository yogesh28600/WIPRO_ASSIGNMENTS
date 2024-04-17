namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Who are you?\n1.Admin\n2.Customer");
                switch(int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Admin admin = new Admin();
                        Console.WriteLine("1.Add Product\n2.Display Products");
                        switch (int.Parse(Console.ReadLine()))
                        {
                            case 1:
                                string pname; 
                                int qty_in_stock; 
                                double discount_allowed; 
                                double price;
                                Console.WriteLine("Enter Product Name");
                                pname = Console.ReadLine();
                                Console.WriteLine("Enter Quantity availabe");
                                qty_in_stock = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Discount % ");
                                discount_allowed = Double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Product price");
                                price = Double.Parse(Console.ReadLine());
                                admin.addProduct(pname,qty_in_stock,discount_allowed,price);
                                break;
                            case 2:
                                admin.displayProducts();
                                break;
                        }
                        break;
                    case 2:
                        Customer customer = new Customer();
                        Console.WriteLine("Available Products");
                        Console.Write("[ ");
                        foreach(var product in Admin.products)
                        {
                            Console.WriteLine(product.pname + " ");
                        }
                        Console.Write("]");
                        Console.WriteLine("1.Display product details\n2.Purchase product\n3.Get bill");
                        switch (int.Parse(Console.ReadLine()))
                        {
                            case 1:
                                Console.WriteLine("Enter product name ");
                                customer.displayProduct(Console.ReadLine().ToLower());
                                break;
                            case 2:
                                Console.WriteLine("Enter product name ");
                                customer.purchaseProduct(Console.ReadLine().ToLower());
                                break;
                            case 3:
                                Console.WriteLine("Total amout to be paid: " + customer.bill);
                                break;
                        }
                        break;
                }

            }
        }
    }
}
