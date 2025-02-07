// Creator: Ryder Held
// Date: 1/29/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseOfConsolas
{
    public class TargetTracker
    {
        // Variables
        private int targetRow = -1;
        private int targetColumb = -1;

        // Gets and sets
        public int TargetRow
        {
            get { return this.targetRow; }
            set { this.targetRow = value; }
        }
        public int TargetColumb
        {
            get { return this.targetColumb; }
            set { this.targetColumb = value; }
        }

        // Constructors
        public TargetTracker()
        {
            // Empty constructor
        }

        public TargetTracker(int aTargetRow, int aTargetColumb)
        {
            // Full Constructor
            this.TargetRow = aTargetRow;
            this.TargetColumb = aTargetColumb;
        }

        // Methods
        public override string ToString()
        {
            string message = "";
            message = message + "Target Row: " + this.TargetRow + "\n";
            message = message + "Target Colomb: " + this.TargetColumb;
            return message;
        }

        public string DeployDefense()
        {
            string defensePositions = "";
            defensePositions = defensePositions + "Deploy to:\n";
            defensePositions = defensePositions + $"({this.TargetRow}, {this.TargetColumb - 1})\n";
            defensePositions = defensePositions + $"({this.TargetRow - 1}, {this.TargetColumb})\n";
            defensePositions = defensePositions + $"({this.TargetRow}, {this.TargetColumb + 1})\n";
            defensePositions = defensePositions + $"({this.TargetRow + 1}, {this.TargetColumb})\n";
            return defensePositions;
        }
    }
}
