using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Product
    {
        
        public  int pcode {get;}
        public string pname { get; set; }
        public int qty_in_stock { get; set; }
        public double discount_allowed { get; set; }
        public double price {  get; set; }
        public static string brand { get; set;}

        public Product()
        {

        }


        public Product(string pname, int qty_in_stock, double discount_allowed,double price)
        {
            this.pname = pname;
            this.qty_in_stock = qty_in_stock;
            this.discount_allowed = discount_allowed;
            this.price = price;
            Random rnd = new Random();
            pcode = rnd.Next();
        }

        override
        public string ToString()
        {
            return $"[ pcode: {pcode} Product Name: {pname} Quantity: {qty_in_stock} Discount: {discount_allowed} ]";
        }
    }
}
