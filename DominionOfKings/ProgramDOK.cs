// Creator: Ryder Held
// Date: 1/28/2025
namespace DominionOfKings
{
    public class ProgramDOK
    {
        public static void Main(string[] args)
        {
            KingdomWorth kingdomWorth1 = new KingdomWorth(3, 8, 8);
            KingdomWorth kingdomWorth2 = new KingdomWorth(20, 3, 3);
            KingdomWorth kingdomWorth3 = new KingdomWorth(7, 12, 5);
            // Amount of estates, duchies, and provinces per kingdom

            List<KingdomWorth> kingdomValuesList = new List<KingdomWorth>();
            kingdomValuesList.Add(kingdomWorth1);
            kingdomValuesList.Add(kingdomWorth2);
            kingdomValuesList.Add(kingdomWorth3);

            foreach(KingdomWorth kingdomWorth in kingdomValuesList)
            {
                Console.WriteLine(kingdomWorth.KingdomValue());
            }
            // The correct scores for estates, duchies, and provinces were given along with the kingdoms
            //                                                                                  total value
        }
    }
}
