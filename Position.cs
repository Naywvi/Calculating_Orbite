namespace src.Position
{
    public class Pos
    {
        private int _x; // private variable to store x position
        public int x
        { // public property to access x position
            get => _x; // getter for _x
            set => _x = value; // setter for _x
        }
        private string xString
        { // private property to get string representation of x position
            get => _x.ToString();
        }
        private int _y; // private variable to store y position
        public int y
        { // public property to access y position
            get => _y; // getter for _y
            set => _y = value; // setter for _y
        }
        private string yString
        { // private property to get string representation of y position
            get => _y.ToString();
        }
        public string showPosition()
        { // function to show position as a string
            var postionString = "\n position:  x: " + this.yString + " km \n            y: " + this.xString + " km\n";
            return postionString; // return the position string
        }
        public void constructorPosition(int xP, int yP)
        { // constructor function for position
            x = xP; // sets x position
            y = yP; // sets y position
        }
    }
}