using System;
using System.Collections.Generic;
using System.Text;

namespace AppStoreNS
{
    public class App
    {
        public App(string n = "", int p = 0,int q =0)
        {
            Name = n;
            Price = p;
            Available = q;
        }
        public App(App a)
        {
            Name = a.Name;
            Price = a.Price;
            Available = a.Available;
        }
        public string Name { get; set; }
        public int Price { get; set; }//Restric getters and setters
        public int Available { get; set; }//for proper requirements
    }
}
