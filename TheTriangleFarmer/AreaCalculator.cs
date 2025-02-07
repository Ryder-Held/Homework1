// Creator: Ryder Held
// Date: 1/27/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TheTriangleFarmer
{
    public class AreaCalculator
    {
        // Variables
        private double triangleBase = -1;
        private double triangleHeight = -1;

        // Gets and sets
        public double TriangleBase
        {
            get { return this.triangleBase; }
            set { this.triangleBase = value; }
        }
        public double TriangleHeight
        {
            get { return this.triangleHeight; }
            set { this.triangleHeight = value; }
        }

        // Constructors
        public AreaCalculator()
        {
            // Empty constructor
        }
        public AreaCalculator(double aTriangleBase, double aTriangleHeight)
        {
            // Full Constructor
            this.triangleBase = aTriangleBase;
            this.triangleHeight = aTriangleHeight;
        }

        // Methods
        public double CalcArea()
        {
            double triangleArea = (this.triangleBase * this.triangleHeight) / 2;
            return triangleArea;
        }
    }
}
