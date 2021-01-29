using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class ProductManager : IProductService
    {
        public void List(Product producManager)
        {
            
            Console.WriteLine(producManager.ProductName+" : " + producManager.ProductPrice+"$");
        }

        
    }
}
