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
                Console.ForegroundColor = ConsoleColor.Green;                   //wording colour changed to green
                Console.WriteLine("choose one of the following options below \n" +       //menu option   
                    "1. Enter the details for a single recipe \n" +
                    "2. Display the full recipe \n" +
                    "3. Scale the recipe \n" +
                    "4. Reset quantities to its orignal values \n" +
                    "5. Clear all data to enter a new recipe \n" +
                    "6. Exit application ");


                int option = int.Parse(Console.ReadLine());             //input to choose option
                if (option == 1)
                {
                    string recipes = recipe();                          //varable to store recipe
                    report.recipes = recipes;
                    int num =  numIngredients();                       //varable to store number of ingrediednts
                    string[] names = new string[num];                   //array to store names
                    double [] quant = new double[num];                  //array to store quantiy
                    string [] measure = new string[num];                //array to unit of measure
                    string[] stepdesc= new string[num];                 //array to store steps
                    
                    for (int i = 0; i < num; i++)                   //loop to get ingredients
                    {
                        names [i] = name(i);
                        quant[i] = quantity(i);
                        measure[i] = measur();
                        
                    }
                    int ste = step();                           //varable to store number of steps

                    for (int j = 0; j < ste; j++)               //loop to get steps 
                    {
                        stepdesc[j] = stepdes(j);
                    }
                    report.name = names;
                    report.quants= quant;
                    report.measures = measure;
                    report.step = stepdesc;
                }
                else if (option == 2)                       //if statement for second option
                {

                       report.display();
                }
                else if (option == 3)                   //if statement for third option
                {
                    report.scale();
                }
                else if (option == 4)                   //if statement for fourth option
                {
                     report.reset();
                }
                else if (option == 5)                   //if statement for fifth option
                {
                    report.clear();
                }
                else if (option == 6)                   //if statement for sixth option
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("wrong input");
                }

            }


        }
        public static string recipe()                           //method to enter name of recipe
        {
            Console.WriteLine("Please enter the name of Recipe ");
            string rec = Console.ReadLine();    
            return rec;
        }
        public static int numIngredients()          //method to enter number of ingredients
        {
            Console.WriteLine("Enter the number of ingredients needed for the recipe");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
        public static string name(int i)            //method to enter the name of the ingredient
        {
            Console.WriteLine("Please enter the name of Ingredient " + (i+1) + ": ");
            string name = Console.ReadLine();
            return name;
        }
        public static double quantity(int i)        //method to enter quantity
        {
            Console.WriteLine("Please enter the quantity for ingredient " + (i+1));
            double quantity = double.Parse(Console.ReadLine());
            return quantity;
        }
        public static string measur()           //method to capture unit of measure
        {
            Console.WriteLine("Choose the unit of meaurment \n" +
                "1. Teaspoon \n" +
                "2. Tablespoon \n" +
                "3. Cup");
            
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
        
        public static int step()            //method to enter number of steps
        {
            Console.WriteLine("Enter the number of steps required for the recipe: ");
            int step = int.Parse(Console.ReadLine());
            return step;
        }
        public static string stepdes(int i)         //method to enter steps
        {
            Console.WriteLine("Please enter step "+ (i+1)+": ");
            String stepDes = Console.ReadLine();
            return stepDes;
        }

    }
}