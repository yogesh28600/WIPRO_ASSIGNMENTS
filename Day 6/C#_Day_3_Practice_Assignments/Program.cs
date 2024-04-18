using System.ComponentModel;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin1 = new Admin();
            admin1.addProduct("Monitor", 10, 0, 20000);
            admin1.addProduct("Keyboard", 10, 0, 1500);
            admin1.addProduct("Mouse", 10, 0, 650);
            admin1.addProduct("CPU", 10, 0, 50000);
            admin1.addProduct("Graphic Card", 10, 0, 30000);
            admin1.setBrand("YK Computers");
            while (true)
            {
                Console.WriteLine("Who are you?\n1.Admin\n2.Customer");
                switch(int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Admin admin = new Admin();
                        bool flag = true;
                        while (flag)
                        {
                            Console.WriteLine("1.Add Product\n2.Display Products\n3.Edit Brand name\n4.Exit");
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
                                    admin.addProduct(pname, qty_in_stock, discount_allowed, price);
                                    break;
                                case 2:
                                    admin.displayProducts();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter Product price");
                                    admin.setBrand(Console.ReadLine());
                                    break;
                                case 4:
                                    flag = false;
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Customer customer = new Customer();
                        bool flag1 = true;
                        while (flag1)
                        {
                            Console.WriteLine("----Available Products------");
                            foreach (var product in Admin.products)
                            {
                                Console.WriteLine(product.pname + " ");
                            }
                            Console.WriteLine("----Menu------");
                            Console.WriteLine("1.Display product details\n2.Purchase product\n3.Get bill\n4.Exit");
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
                                case 4:
                                    flag1=false;
                                    break;
                            }
                        }
                        break;
                }

            }
        }
    }
}

