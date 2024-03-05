using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Classes
{
    public class DeleteProduct
    {
      public void Delete_product(string name)
        {
            string path = $"{name}.txt";
            bool res = File.Exists(path) ;
            if(!res) { Console.WriteLine("THIS CLOTHING WAS NOT FOUND"); }
            if (res)
            {
                File.Delete(path) ;
                string[] del = File.ReadAllLines("All products.txt") ;
                for(int i = 0; i < del.Length; i++ )
                {
                    if (del[i] == name )
                    {
                        del[i] = del[i].Remove(0);
                        del[i + 1] = del[i + 1].Remove(0);
                        del[i + 2] = del[i + 2].Remove(0);
                    }
                }
                File.Delete("All products.txt") ;
                foreach (var a in del)
                {
                    File.AppendAllText("All products.txt", a + "\n");
                }

            }
        }
    }
}