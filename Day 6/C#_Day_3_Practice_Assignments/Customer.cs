namespace Assignment3
{
    internal class Customer
    {
        public double bill { get; set; }
        public void displayProduct(string name)
        {
            foreach(var product in Admin.products)
            {
                if(product.pname.ToLower().Equals( name))
                {
                    Console.WriteLine($"[  Product Name: {product.pname} Quantity: {product.qty_in_stock} Discount: {product.discount_allowed} ]");
                }
            }
        }
        public void purchaseProduct(string productName)
        {
            foreach(var product in Admin.products)
            {
                if(product.pname.ToLower().Equals(productName))
                {
                    string[] date = DateTime.Now.ToString().Split("-");
                    double discount = product.discount_allowed;
                    int day = int.Parse(date[0]);
                    int month = int.Parse(date[1]);
                    if (day == 26 && month == 1)
                    {
                        discount = 0.5;
                    }
                    if(discount != 0)
                    {
                        bill += product.price * discount;
                    }else
                    {
                        bill += product.price;
                    }
                    
                }
            }
         
        }
    }
}
