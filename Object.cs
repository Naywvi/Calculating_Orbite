namespace src.Object
{
    public class Obj
    {
        private int _position; // private variable to store object's position
        public int position
        { // public property to access object's position
            get => _position; // getter for _position
            set => _position = value; // setter for _position
        }

        private int _weight; // private variable to store object's weight
        public int weightObj
        { // public property to access object's weight
            get => _weight; // getter for _weight
            set => _weight = value; // setter for _weight
        }

        public void constructorObject(int weightObjP, int positionP)
        { // constructor function for object
            weightObj = weightObjP; // sets object's weight
            position = positionP; // sets object's position
        }
    }
}