// Creator: Ryder Held
// Date: 1/27/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSistersAndTheDuckbear
{
    public class EggSolver
    {
        // Variables
        private int eggsGathered = -1;

        // Gets and sets
        public int EggsGathered
        {   
            get { return this.eggsGathered; }
            set { this.eggsGathered = value; }
        }

        // Constructors
        public EggSolver()
        {
            // Empty constructor
        }

        public EggSolver(int eggsGatheredToday)
        {
            // Full Constructor
            this.EggsGathered = eggsGatheredToday;
        }

        // Methods
        public int EggsPerSister()
        {
            int eggsPerSister = this.EggsGathered / 4;
            return eggsPerSister;
        }
        public int EggsForDuckbear()
        {
            int eggsForDuckbear = this.EggsGathered % 4;
            return eggsForDuckbear;
        }
    }
}
