using System;

namespace First
{
    class Fraction
    {
        private double numerator;
        private double denomerator;

        public Fraction(double numerator, double denomerator) 
        {
            Numerator = numerator;
            Denomerator = denomerator;
        }

        public double Numerator { get => numerator; set => numerator = value; }

        public double Multiplication { get => numerator * denomerator; }

        public double Division { get => numerator / denomerator; }

        public double Addition { get => numerator + denomerator; }

        public double Subtraction { get => numerator - denomerator; }

        public double Denomerator { get => denomerator; set {
                if (value == 0)
                    throw new Exception();
                else
                    denomerator = value;
            } }
    }
}
