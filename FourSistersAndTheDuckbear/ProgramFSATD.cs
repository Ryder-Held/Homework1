// Creator: Ryder Held
// Date: 1/27/2025
namespace FourSistersAndTheDuckbear
{
    public class ProgramFSATD
    {
        public static void Main(string[] args)
        {
            EggSolver totalEggsDay1 = new EggSolver(7);
            EggSolver totalEggsDay2 = new EggSolver(38);
            EggSolver totalEggsDay3 = new EggSolver(1);
            // Egg amount being 7, 38, and 1

            List<EggSolver> dailyEggList = new List<EggSolver>();
            dailyEggList.Add(totalEggsDay1);
            dailyEggList.Add(totalEggsDay2);
            dailyEggList.Add(totalEggsDay3);

            foreach(EggSolver Eggs in dailyEggList)
            {
                Console.WriteLine("Amount of eggs for each sister: " + Eggs.EggsPerSister());
                Console.WriteLine("Eggs fed to the Duckbear: " + Eggs.EggsForDuckbear() + "\n");
            }
            // Correct returns of 1:3, 9:2, and 0:1
            // ratio (eggsPerSister:eggsForDuckbear)
            // Answer for the book question: The three egg counts in which the duckbear
            //                               gets more than the sisters in a day are --> 1, 2, and 3
        }
    }
}
