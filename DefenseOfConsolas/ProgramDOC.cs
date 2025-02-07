// Creator: Ryder Held
// Date: 1/29/2025
namespace DefenseOfConsolas
{
    public class ProgramDOC
    {
        public static void Main(string[] args)
        {
            TargetTracker target = new TargetTracker(6, 5);
            Console.WriteLine(target.ToString());

            // Changes the following text to green as the book asked
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(target.DeployDefense());
            
            // Changes the following code back to white
            Console.ForegroundColor = ConsoleColor.White;

            // Adds the beeping sound the book wanted
            Console.Beep();
        }
    }
}
