//Create a Class called Products with Productid, Product Name, Price. Accept 10 Products, sort them based on the price, and display the sorted Products

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    public class Products 
    {
        public static void Main(string[] args)
        {
            List<Products> prolist = new List<Products>
              {
              new Products{Product_Id=1,Product_Name="Soap",Price=24.0f},
              new Products{Product_Id=2,Product_Name="hairoil",Price=120.0f},
              new Products{Product_Id=3,Product_Name="Earrings",Price=40.0f},
              new Products{Product_Id=4,Product_Name="Rubberband",Price=15.0f},
              new Products{Product_Id=5,Product_Name="pen",Price=20.0f},
              new Products{Product_Id=6,Product_Name="pencil",Price=20.0f},
              new Products{Product_Id=7,Product_Name="Sketches",Price=28.0f},
              new Products{Product_Id=8,Product_Name="colours",Price=35.0f},
              new Products{Product_Id=9,Product_Name="paintings",Price=50.0f},
              new Products{Product_Id=10,Product_Name="stickers",Price=160.0f}
              };
            Display(prolist);
            Console.Read();
             }
        public static void Display(List<Products> products)
        {
            Console.WriteLine();
            var val = products.OrderBy(a => a.Price).ToList();
            foreach (var p in val)
            {
                Console.WriteLine("Id: {0} Name: {1} price: {2} ", p.Product_Id, p.Product_Name, p.Price);
            }
        }
    }

    public class Products
    {
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public float Price { get; set; }


    }
}
