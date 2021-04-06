using System;
using System.Collections.Generic;
using System.Text;

namespace AppStoreNS
{
    public class Apple:AppStore
    {  
        public Apple():base()
        {

            appList[0] = new App("Bioshock Infinite", 54, 3);
            appList[1] = new App("Civilization VI", 50, 4);
            appList[2] = new App("Planet Coaster", 46, 5);
            appList[3] = new App("Shadow Tomb Raider", 57, 2);
        }
        Apple(App[] a):base(a)
        {

        }
        public override void WelcomeToStore()
        {
            Console.WriteLine("Welcome to the Apple Store!");
        }






    }
}
