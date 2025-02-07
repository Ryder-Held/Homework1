// Creator: Ryder Held
// Date: 1/27/2025
namespace TheTriangleFarmer
{
    public class ProgramTF
    {
        public static void Main(string[] args)
        {
            AreaCalculator areaValues1 = new AreaCalculator(4, 5);
            // Base of 4, height of 5
            AreaCalculator areaValues2 = new AreaCalculator(7, 9);
            // Base of 7, height of 9
            AreaCalculator areaValues3 = new AreaCalculator(100, 12);
            // Base of 100, height of 12

            List<AreaCalculator> areaValueList = new List<AreaCalculator>();
            areaValueList.Add(areaValues1);
            areaValueList.Add(areaValues2);
            areaValueList.Add(areaValues3);
            
            foreach(AreaCalculator Area in areaValueList)
            {
                Console.WriteLine("Triangles Area: " + Area.CalcArea());
            }
            // The correct results of 10, 31.5, and 600 were returned
        }
    }
}
