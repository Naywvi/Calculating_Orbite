namespace src.Position
{
    public class Pos
    {
        private int _x;
        public int x{
            get => _x;
            set => _x = value;
        }
        private string xString{
            get => _x.ToString();
        }
        private int _y;
        public int y{
            get => _y;
            set => _y = value;
        }
        private string yString{
            get => _y.ToString();
        } 
        
        // function to show position as a string
        public string showPosition(){
            var postionString = "\n position:  x: " + this.yString + " km \n            y: " + this.xString + " km\n";
            return postionString;
        }

        //,Consctuctor
        public void constructorPosition(int xP, int yP){
            x = xP;
            y = yP;
        }
    }
}