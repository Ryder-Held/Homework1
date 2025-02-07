// Creator: Ryder Held
// Date: 1/28/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionOfKings
{
    public class KingdomWorth
    {
        // Variables
        private int kingdomEstates = -1;
        private int kingdomDuchies = -1;
        private int kingdomProvinces = -1;

        // Gets and sets
        public int KingdomEstates
        {
            get { return this.kingdomEstates; }
            set { this.kingdomEstates = value; }
        }
        public int KingdomDuchies
        {
            get { return this.kingdomDuchies; }
            set { this.kingdomDuchies = value; }
        }
        public int KingdomProvinces
        {
            get { return this.kingdomProvinces; }
            set { this.kingdomProvinces = value; }
        }

        // Constructors
        public KingdomWorth()
        {
            // Empty Constructor
        }
        public KingdomWorth(int aKingdomEstates, int aKingdomDuchies, int aKingdomProvinces)
        {
            // Full Constructor
            this.KingdomEstates = aKingdomEstates;
            this.KingdomDuchies = aKingdomDuchies;
            this.KingdomProvinces = aKingdomProvinces;
        }

        // Methods
        public string KingdomValue()
        {
            int estatesWorth = KingdomEstates * 1;
            int duchiesWorth = KingdomDuchies * 3;
            int provincesWorth = KingdomProvinces * 6;
            string message = "";
            message = message + "Value of kingdom estates: " + estatesWorth + "\n";
            message = message + "Value of kingdom duchies: " + duchiesWorth + "\n";
            message = message + "Value of kingdom provinces: " + provincesWorth + "\n";
            message = message + "Total value of the kingdom: " + (estatesWorth + duchiesWorth + provincesWorth) + "\n";
            return message;
        }
    }
}
