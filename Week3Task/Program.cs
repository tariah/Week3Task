using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace Question1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            // State Collection
            List<string> stateList = new List<string>()
            {
                //new States() { stateId = 1, state = "Abia"},
                //new States() { stateId = 2, state = "Adamawa"},
                //new States() { stateId = 3, state = "Akwa Ibom"},
                //new States() { stateId = 4, state = "Anambra"},
                //new States() { stateId = 5, state = "Bauchi"},
                //new States() { stateId = 6, state = "Bayelsa"},
                //new States() { stateId = 7, state = "Benue"},
                //new States() { stateId = 8, state = "Borno"},
                //new States() { stateId = 9, state = "Cross River"},
                //new States() { stateId = 10, state = "Delta"},
                //new States() { stateId = 11, state = "Ebonyi"},
                //new States() { stateId = 12, state = "Edo"},
                //new States() { stateId = 13, state = "Ekiti"},
                //new States() { stateId = 14, state = "Enugu"},
                //new States() { stateId = 15, state = "Gombe"},
                //new States() { stateId = 16, state = "Imo"},
                //new States() { stateId = 17, state = "Jigawa"},
                //new States() { stateId = 18, state = "Kaduna"},
                //new States() { stateId = 19, state = "Kano"},
                //new States() { stateId = 20, state = "Katsina"},
                //new States() { stateId = 21, state = "Kebbi"},
                //new States() { stateId = 22, state = "Kogi"},
                //new States() { stateId = 23, state = "Kwara"},
                //new States() { stateId = 24, state = "Lagos"},
                //new States() { stateId = 25, state = "Nasarawa"},
                //new States() { stateId = 26, state = "Niger"},
                //new States() { stateId = 27, state = "Ogun"},
                //new States() { stateId = 28, state = "Ondo"},
                //new States() { stateId = 29, state = "Osun"},
                //new States() { stateId = 30, state = "Oyo"},
                //new States() { stateId = 31, state = "Plateau"},
                //new States() { stateId = 32, state = "Rivers"},
                //new States() { stateId = 33, state = "Sokoto"},
                //new States() { stateId = 34, state = "Taraba"},
                //new States() { stateId = 35, state = "Yobe"},
                //new States() { stateId = 36, state = "Zamfara"}

            "Abia", "Adamawa", "Akwa Ibom", "Anambra", "Bauchi", "Bayelsa", "Benue", "Borno",
            "Cross River", "Delta", "Ebonyi", "Edo", "Ekiti", "Enugu", "Gombe", "Imo", "Jigawa",
            "Kaduna", "Kano", "Katsina", "Kebbi", "Kogi", "Kwara", "Lagos", "Nasarawa", "Niger",
            "Ogun", "Ondo", "Osun", "Oyo", "Plateau", "Rivers", "Sokoto", "Taraba", "Yobe", "Zamfara"

        };
            
            

            // LINQ Query
            int groupSize = 3; // Grouping size

            var groups = stateList.Select((s, index) => new { s, index }).GroupBy(s => s.index / groupSize, s => s);

            Console.WriteLine($"A Group of states in sets of {groupSize}:\n===============================\n");

            foreach (var group in groups)
            {
                Console.WriteLine(string.Join(", ", group));
                Console.WriteLine("-------------------------\n\n\n");
            }


            // Quetion 3
            var groupedStates = stateList.GroupJoin("ABCDEFGHIJKLMNOPQRSTUVWXYZ",  // Create a sequence of 26 alphabet characters
                s => s.First().ToString(),  // Key selector for states (first alphabet)
                letter => letter.ToString(),        // Key selector for alphabet letters
                (letter, groupOfStates) => new
                {
                    Letter = letter,
                    States = groupOfStates.OrderBy(s => s) // Sort states within each group
                });

            foreach (var group in groupedStates)
            {
                Console.WriteLine($"Group {group.Letter} - {group.States.Count()}");
                Console.WriteLine("\n----------------");
                Console.WriteLine(string.Join(", ", group.States));
                Console.WriteLine();
            }
        }
    }
}
