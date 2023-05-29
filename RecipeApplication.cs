using Microsoft
    
    .SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace commandLineApplicationPart1Poe
{
     internal class report
     {
        
        
        public List<store> recipes;
        public store rr;
        public delegate void messdeligate(string msg);
        public report()
        {
            recipes = new List<store>();
        }
        
        
        public void displayallrec()
        {
            Console.WriteLine("***************************************************************** \n" +
                "-----------------------Saved Recipe--------------------------------- \n" +
                "************************************************************************** \n" +
                "Recipes: ");
            recipes.Sort((r1, r2) => string.Compare(r1.recip, r2.recip));
            foreach (store store in recipes)
            {
                
                Console.WriteLine( store.recip);
            }

            //store ab = new store();
            Console.WriteLine("Enter the name of the recipe you want to display");
            string input = Console.ReadLine();

            store ab = recipes.Find(store => store.recip.Equals(input, StringComparison.Ordinal));

            if (input.Equals(ab.recip))
            {
                ab.display();
                //display();
            }
            else
            {
                Console.WriteLine("wrong input");
            }
            
        }
        
        public void scale()                                    //method to scale ingredients
        {
            Console.WriteLine("Enter the name of the recipe you want to reset");
            string input = Console.ReadLine();

            store ab = recipes.Find(store => store.recip.Equals(input, StringComparison.Ordinal));
            //store store = new store();
            if (input.Equals(ab.recip))
            {
                Console.WriteLine("recipe should be scaled to wich factor: \n" +
                            "1. Half (0.5) \n" +
                            "2. Double (2) \n" +
                            "3. Triple (3)");
                int opt = int.Parse(Console.ReadLine());
                StringBuilder bc = new StringBuilder();
                StringBuilder bb = new StringBuilder();
                StringBuilder sc = new StringBuilder();
                double aa = 0;
                for (int i = 0; i < ab.quants.Count; i++)
                {
                    
                    if (opt == 1)
                    {

                        aa = ab.quants[i] / 2;
                        ab.quants[i] = aa;
                    }
                    else if (opt == 2)
                    {
                        aa = ab.quants[i] * 2;
                        ab.quants[i] = aa;
                    }
                    else if (opt == 3)
                    {
                        aa = ab.quants[i] * 3;
                        ab.quants[i] = aa;
                    }
                    else
                    {
                        Console.WriteLine("wrong input");
                    }

                }
            }
            else { Console.WriteLine("wrong input"); }
            
        }
        public  void reset()                                  //method to reset values
        {
            Console.WriteLine("Enter the name of the recipe you want to reset");
            string input = Console.ReadLine();

            store ab = recipes.Find(store => store.recip.Equals(input, StringComparison.Ordinal));
            //store store = new store();
            if (ab != null)
            {
                for (int i = 0; i < ab.quants.Count; i++)                 //loop to reset all values
                {
                    //     quants= ab;
                    ab.quants[i] = ab.quants[i]/2 ;
                }
                Console.WriteLine("********************************************* \n" +
                    "******************* Values reset******************* \n" +
                    "****************************************************");
            }else { Console.WriteLine("wrong input"); }
        }
        
        
        public void clear()                          //method to clear values
        {

            recipes.Clear();
            Console.WriteLine("******************************************** \n" +
                "**************** All VALUES CLEARED *********************** \n" +
                "*****************************************************");
        }
        public void notify(string msg)                             //method to display error message delegate
        {
            msg = "******************************************************* \n" +
                "---------------recipe has exceeded 300 calories----------------\n" +
                "***********************************************************";
            Console.WriteLine(msg);
        }
    }
}
