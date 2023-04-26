using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace commandLineApplicationPart1Poe
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            int p = 1;
            while (p != 6)                                                    //while loop to loop menu
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("choose one of the following options below \n" +
                    "1. Enter the details for a single recipe \n" +
                    "2. Display the full recipe \n" +
                    "3. Scale the recipe \n" +
                    "4. Reset quantities to its orignal values \n" +
                    "5. Clear all data to enter a new recipe \n" +
                    "6. Exit application ");


                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    string recipes = recipe();
                    report.recipes = recipes;
                    int num =  numIngredients() ;
                    string[] names = new string[num];
                    //string[] recipe = new string[num];
                    double [] quant = new double[num];
                    string [] measure = new string[num];
                    string[] stepdesc= new string[num];
                    
                    for (int i = 0; i < num; i++)
                    {
                        //recipes[i]= recipe();
                        names [i] = name(i);
                        quant[i] = quantity(i);
                        measure[i] = measur();
                        
                    }
                    int ste = step();
                    for (int j = 0; j < ste; j++)
                    {
                        stepdesc[j] = stepdes(j);
                    }
                    report.name = names;
                    report.quants= quant;
                    report.measures = measure;
                    report.step = stepdesc;
                }
                else if (option == 2)
                {


                    report.display();
                }
                else if (option == 3)
                {
                    report.scale();
                }
                else if (option == 4)
                {
                     report.reset();
                }
                else if (option == 5)
                {
                    report.clear();
                }
                else if (option == 6)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("wrong input");
                }

            }


        }
        public static string recipe()
        {
            Console.WriteLine("Please enter the name of Recipe ");
            string rec = Console.ReadLine();    
            return rec;
        }
        public static int numIngredients()
        {
            Console.WriteLine("Enter the number of ingredients needed for the recipe");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
        public static string name(int i)
        {
            Console.WriteLine("Please enter the name of Ingredient " + (i+1) + ": ");
            string name = Console.ReadLine();
            return name;
        }
        public static double quantity(int i)
        {
            Console.WriteLine("Please enter the quantity for ingredient " + (i+1));
            double quantity = double.Parse(Console.ReadLine());
            return quantity;
        }
        public static string measur()
        {
            Console.WriteLine("Choose the unit of meaurment \n" +
                "1. Teaspoon \n" +
                "2. Tablespoon \n" +
                "3. Cup");
            //Console.WriteLine(Convert.ToInt32(Console.ReadLine()));
            
            int measur = Convert.ToInt32(Console.ReadLine());
            
            string measurement = "";
            if (measur == 1)
            {

                measurement = "Teaspoon";
            }
            else if (measur == 2)
            {

                measurement = "Tablespoon";
            }
            else if (measur == 3)
            {
                measurement = "Cup";
            }
            return measurement;
        }
        
        public static int step()
        {
            Console.WriteLine("Enter the number of steps required for the recipe: ");
            int step = int.Parse(Console.ReadLine());
            return step;
        }
        public static string stepdes(int i)
        {
            Console.WriteLine("Please enter step "+ (i+1)+": ");
            String stepDes = Console.ReadLine();
            return stepDes;
        }

    }
}