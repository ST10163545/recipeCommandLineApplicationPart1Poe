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
         static report reports = new report();
        

        static void Main(string[] args)
        {
            //Program program = new Program();
            int p = 1;
            while (p != 6)                                                    //while loop to loop menu
            {
                Console.ForegroundColor = ConsoleColor.Green;                   //wording colour changed to green
                Console.WriteLine("--------------------------------------------------------------------- \n" +
                    "choose one of the following options below:  \n" +       //menu option   
                    "1. Enter the details for a recipe \n" +
                    "2. Display all recipes \n" +
                    "3. Scale the recipe \n" +
                    "4. Reset quantities to its orignal values \n" +
                    "5. Clear all data to enter a new recipe \n" +
                    "6. Exit application0 \n" +
                    "-------------------------------------------------------------------------- ");


                int option = int.Parse(Console.ReadLine());             //input to choose option
                if (option == 1)
                {
                    
                    
                    enter();
                }


                else if (option == 2)                       //if statement for second option
                {
                    
                    //store.display();
                    reports.displayallrec();
                    
                }
                else if (option == 3)                   //if statement for third option
                {
                    reports.scale();
                }
                else if (option == 4)                   //if statement for fourth option
                {
                     reports.reset();
                }
                else if (option == 5)                   //if statement for fifth option
                {
                    reports.clear();
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
        static void enter()                               //method for all user inputs
        {
            reports.rr = new store();
            string rec = recipe();
            reports.rr.recip = rec;
            int numin = numIngredients();
            
            for (int i = 0; i < numin; i++)
            {
                string nam = name(i);
                double quatity = quantity(i);
                string measure = measur();
                int calory = numcalories();
                int total = 300;
                if (calory >= total)
                {
                    string msg = null;
                    reports.notify(msg);
                }

                string foodg = foodgroup();
                //add the values to store class
                reports.rr.names.Add(nam);                  
                reports.rr.quants.Add(quatity);
                reports.rr.measures.Add(measure);
                reports.rr.calories.Add(calory);
                reports.rr.foodgroups.Add(foodg);

            }
            int steps = step();
            for (int i = 0; i < steps; i++)
            {
                string stepdescrip = stepdes(i);

                reports.rr.steps.Add(stepdescrip);

            }
            reports.recipes.Add(reports.rr);
            Console.WriteLine("********************************************************************* \n" +
                "********************** SUCCESFULLY CAPTURED******************************** \n" +
                "**************************************************************************");
        }
         static string recipe()                           //method to enter name of recipe
        {
            Console.WriteLine("Please enter the name of Recipe ");
             string rec = Console.ReadLine();    
            return rec;
        }
         static int numIngredients()          //method to enter number of ingredients
        {
            Console.WriteLine("Enter the number of ingredients needed for the recipe");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
         static string name(int i)            //method to enter the name of the ingredient
        {
            Console.WriteLine("Please enter the name of Ingredient " + (i+1) + ": ");
            string name = Console.ReadLine();
            return name;
        }
        static double quantity(int i)        //method to enter quantity
        {
            Console.WriteLine("Please enter the quantity for ingredient " + (i+1));
            double quantity = double.Parse(Console.ReadLine());
            return quantity;
        }
        static string measur()           //method to capture unit of measure
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
        static int numcalories()          //method to enter number of caloris
        {
            Console.WriteLine("Enter the number of calories Kcal");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
        static string foodgroup()                           //method to enter name of foodgroup
        {
            Console.WriteLine("Choose a food group: \n" +
                "1. Fat \n" +
                "2. Protein \n" +
                "3. Dairy \n" +
                "4.Fruits and vegtables \n" +
                "5. Starch");

            int measur = Convert.ToInt32(Console.ReadLine());

            string measurement = "";
            if (measur == 1)
            {

                measurement = "Fat";
            }
            else if (measur == 2)
            {

                measurement = "Protein";
            }
            else if (measur == 3)
            {
                measurement = "Dairy";
            }
            else if (measur == 4)
            {
                measurement = "Fruits and vegtables";
            }
            else if (measur == 5)
            {
                measurement = "Starch";
            }
            else
            {
                Console.WriteLine("wrong input");
            }
            return measurement;
        }
        static int step()            //method to enter number of steps
        {
            Console.WriteLine("Enter the number of steps required for the recipe: ");
            int step = int.Parse(Console.ReadLine());
            return step;
        }
         static string stepdes(int i)         //method to enter steps
        {
            Console.WriteLine("Please enter step "+ (i+1)+": ");
            String stepDes = Console.ReadLine();
            return stepDes;
        }

        
    }
}