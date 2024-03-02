using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Classes
{
    public class AddProduct
    {
        public void AllProducts()
        {
            bool res = File.Exists("All products.txt");
            {
                string[] s = File.ReadAllLines("All products.txt");
                for (int i = 0; i < s.Length; i += 3)
                {
                    if (s[i] == null)
                    {
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.Write(s[i]);
                    }



                }
            }
            if (!res)
            {
               Console.WriteLine(" SORRY. THIS CLOTHING WAS NOT FOUND ");

            }
        }
        public void SellProducts(string name)
        {
            string path = $"{name}.txt";
            bool res  = File.Exists(path);
            if (res)
            {
                string[] s = File.ReadAllLines (path);

                Console.Write("  NAME OF CLOTHES ==> "); Console.WriteLine(s[0]);
                Console.Write(" PRICE OF CLOTHES ==> "); Console.WriteLine(s[1]);
                Console.Write(" CHOOSE CLOTHES COLOR ==> "); Console.WriteLine(s[2]);
            }

        }

        
        
    }
       

    
}
