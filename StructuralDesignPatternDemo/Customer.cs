using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatternDemo
{

    //abstract/interfaces etc can be used.



    public class Customer
    {
        public int custid { get; set; }
        public string custname { get; set; }
        public string City { get; set; }

        //public List<Products> purchasedProducts { get; set; }

    }

    public class CustomerProducts
    {
        public int Custid { get; set; }
        public List<Products> Products { get; set; }

    }


    
    //1 Customer purchases M Products

    public class Products
    {
        public int Prodid { get; set; }
        public string Prodname { get; set; }
        public int Price { get; set; }

    }
}
