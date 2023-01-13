namespace src.Position
{
    public class Pos
    {
        private double _x;
        public double x
        {
            get => _x;
            set => _x = value;
        }
        private string xString
        {
            get => _x.ToString();
        }
        private double _y;
        public double y
        {
            get => _y;
            set => _y = value;
        }
        private string yString
        {
            get => _y.ToString();
        }

        // function to show position as a string
        public string showPosition()
        {
            var postionString = "\n position:  x: " + this.yString + " km \n            y: " + this.xString + " km\n";
            return postionString;
        }

        //,Consctuctor
        public void constructorPosition(double xP, double yP)
        {
            x = xP;
            y = yP;
        }
    }
}