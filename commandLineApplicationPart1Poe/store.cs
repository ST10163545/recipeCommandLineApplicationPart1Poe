using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandLineApplicationPart1Poe
{
     internal class store
    {
        public string recip { get; set; }
        
        public List<string> names { get; set; }
        public List<double> quants { get; set; }
        public List<string> measures { get; set; }
        public List<string> steps { get; set; }
        public List<int> calories { get; set; }
        public List<string> foodgroups { get; set; }

        //public List<double> notes;
        public store()
        {
            //recip = new List<string>();
            //nums = new List<int>();
            names = new List<string>();
            quants = new List<double>();
            measures = new List<string>();
            steps = new List<string>();
            calories = new List<int>();
            foodgroups = new List<string>();
        }

        public void display()                //method to display recipe
        {
            Console.WriteLine("*********************Recipe for " + recip + " *********************** \n" +
                "**************************************************************** \n" +
                "Ingredients: \n");
            int totalcal = 0;
            for (int i = 0; i < calories.Count; i++)
            {
                totalcal += calories[i];
                
            }
            Console.WriteLine("Total Calories of all ingredients: " + totalcal);
            for (int i = 0; i < names.Count; i++)
            {
                
                 Console.WriteLine(quants[i] + " " + measures[i] + " " + names[i] + " \n" +
                     "Food group: "+ foodgroups[i] +"\n" +
                     "----------------------------------------------------------------------------");
            }
            
            Console.WriteLine("Steps: ");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine("Step " + (i + 1) + ": " + steps[i] + "\n" +
                "*********************************************************************************");
            }
        }

    }
}

