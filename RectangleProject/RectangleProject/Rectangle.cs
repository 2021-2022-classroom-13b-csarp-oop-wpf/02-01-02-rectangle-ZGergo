namespace RectangleProject
{
    class Rectangle
    {
        private double sideA;
        private double sideB;

        public double SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                SideA = value;
            }
        }

        public double SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                SideB = value;
            }
        }

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
    }
}
