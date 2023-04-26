using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace commandLineApplicationPart1Poe
{
    internal class report
    {
        public static string recipes;
        public static int[] nums;
        public static string [] name;
        public static double[] quants;
        public static string[] measures;
        public static string[] step;
         public static double [] ab ;
        // ab = quants;
        
        public static void display()                //method to display recipe
        {
            //string bb = "";
            //string bc = "";
            StringBuilder bc = new StringBuilder();         //string builder to display ingredients
            StringBuilder bb = new StringBuilder();          //string builder to display steps
            ab = quants;
            for (int i = 0; i < name.Length; i++)
            {

                bc.Append(ab[i] +" " + measures[i] +" " + name[i]+ "\n");
            }
            for (int i = 0; i < step.Length; i++)
            {
                bb.Append("Step " + (i + 1) + ": " + step[i] +"\n");
            }
            
            Console.WriteLine("*********************Recipe for "+ recipes+ " *********************** \n" +
                "********************************************* \n" +
                "Ingredients: \n" +
                 bc+" \n" +
                "Steps: \n" +
                bb +"\n"+
                "************************************************");

             Console.ReadLine();
        }

        

        public static double scale()                                    //method to scale ingredients
        {
            Console.WriteLine("recipe should be scaled to wich factor: \n" +
                        "1. Half (0.5) \n" +
                        "2. Double (2) \n" +
                        "3. Triple (3)");
            int opt = int.Parse(Console.ReadLine());
            StringBuilder bc = new StringBuilder();
            StringBuilder bb = new StringBuilder();
            StringBuilder sc = new StringBuilder();
            double  ab =0 ;
            for (int i = 0; i < quants.Length; i++)
            {

                if (opt == 1)
                {
                    //StringBuilder stringBuilder = sc.Append(quants[i] / 2);
                    ab = quants[i] / 2;
                }
                else if (opt == 2)
                {
                    ab=quants[i] * 2;
                }
                else if (opt == 3)
                {
                    ab =quants[i] * 3;
                }
                
            }
            
            for (int i = 0; i < name.Length; i++)
            {
                bc.Append(ab + " " + measures[i] + " " + name[i] +"\n");
            }
            for (int i = 0; i < step.Length; i++)
            {
                 bb.Append("Step "+ (i+1)+": "+step[i] + "\n");
            }
            Console.WriteLine("****************Recipe for "+ recipes+ " ************************ \n" +
                "************************************************ \n" +
                "Ingredients: \n" +
                 bc + " \n" +
                "Steps: \n" +
                bb +"\n"+
                "***************************************************");
            return ab;
            //Console.ReadLine();
        }
        public static void reset()                                  //method to reset values
        {
            for (int i = 0; i < quants.Length; i++)                 //loop to reset all values
            {
                quants= ab;
                
            }
            Console.WriteLine("********************************************* \n" +
                "******************* Values reset******************* \n" +
                "****************************************************");
            
        }

        
        public static void clear()
        {

            nums = new int[0];
            name = new string[0];
            quants = new double[0];
            measures = new string[0];
            step = new string[0];
            ab = new double[0];
            Console.WriteLine("******************************************** \n" +
                "**************** All VALUES CLEARED *********************** \n" +
                "*****************************************************");
        }
    }
}
