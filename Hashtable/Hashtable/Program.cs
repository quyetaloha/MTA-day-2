using System;
using System.Collections;

namespace Hashtable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable cart = new Hashtable();
            int number = 3;
            for(int i = 0; i < number; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                cart.Add(key, value);
            }
            Console.WriteLine("của sản phẩm có id =1:{0}", cart["1"]);
            Console.WriteLine("Gio hang co ma la 1: {0}", cart.ContainsKey("1"));
            cart.Remove("2");
            ICollection keys = cart.Keys;

            foreach (string k in keys)
            {
                Console.WriteLine(k + ": " + cart[k]);
            }
        }
    }
}
