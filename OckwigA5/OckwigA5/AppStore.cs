using System;
using System.Collections.Generic;
using System.Text;

namespace AppStoreNS
{


    //Probably need to default load the app list
    abstract public class AppStore
    {
        public AppStore(App[] aList,int sel = 0, int p=0)
        {
            appList = aList;
            selected = sel;
            paid = p;
        }
        public AppStore(int sel = 0, int p = 0)
        {

            selected = sel;
            paid = p;
        }
        public App[] appList; //may need to add private
        public int selected { get; set; }
        public int paid { get; set; }


        public virtual void WelcomeToStore()//PROBABLY CHANGE TO ABSTRACT
        {

        }
        public void SelectApp()
        {
            bool sel=true;
            
            Console.WriteLine("Name     Price      Quantity");

            for(int i = 0;i< appList.Length;i++)
            {
                Console.WriteLine(appList[i].Name + "    " + appList[i].Price + "    " + appList[i].Available);
            }
            do
            {
                selected = Console.Read();

                if(selected>=0||selected<appList.Length)
                {
                    sel = false;

                }
            } while (sel);

        }
        virtual public void PayForApp()
        {
            //
            //This will collect 20,10 for MS and default
            //
            //
        }
        virtual public void ReturnChange(int r)
        {
            int tens = r / 10;
            int doll = r % 10;
            Console.WriteLine("Your Change is");
            Console.WriteLine("Tens: " + tens);
            Console.WriteLine("Ones: " + doll);

        }
        public void DownloadApp(bool payment)
        {
            if (payment)
            {
                Console.WriteLine("Your payment was sufficient and download will commence...");
            }
            else
            {
                Console.WriteLine("I'm sorry. The payment provided was insufficient to cover the purchase");
            }

        }
        public void PurchaseApp()
        {
            WelcomeToStore();
            SelectApp();
        }


    }
}
