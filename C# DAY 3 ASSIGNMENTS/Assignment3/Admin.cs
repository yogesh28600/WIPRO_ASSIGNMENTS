namespace Assignment3
{
    internal class Admin
    {
        public static List<Product> products = new List<Product>();
        public void addProduct(string pname, int qty_in_stock, double discount_allowed,double price)
        {
            Product product = new Product( pname,  qty_in_stock,  discount_allowed,price);
            products.Add(product);
        }
        public Product getProduct(string name)
        {
            foreach (Product product in products)
            {
                if(name == product.pname)
                {
                    return product;
                }
            }
            return null;
        }
        public void setBrand(string brand)
        {
            Product.brand = brand;
        }
        public void displayProducts()
        {
            foreach(Product product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
