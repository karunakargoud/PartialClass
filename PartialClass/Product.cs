using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    partial class Product
    {
        partial void AddProduct();
        partial void EditProduct();
        partial void FindProduct();
        partial void DeleteProduct();
    }
    //Developer1
     partial class Product
    {
        partial void AddProduct()
        {
            Console.WriteLine("AddProduct by Developer1");
        }
        public void SumProduct()
        {
            AddProduct();
        }
    }
    //Developer2
    partial class Product
    {
        partial void EditProduct()
        { 
            Console.WriteLine("EditProduct by Developer2");
      
         }
        public void UpdateProduct()
        {
            EditProduct();
        }
    }

    //Developer3
     partial class Product
    {
        partial void FindProduct()
        {
            Console.WriteLine("FindProduct by Developer3");
        }
        public void SearchProduct()
        {
            FindProduct();
        }
    }
    //Developer4
    partial class Product
    {
        partial void DeleteProduct()
        {
            Console.WriteLine("RemoveProduct by Developer4");
        }
        public void  RemoveProduct()
        {
            DeleteProduct();
        }
    }

}

