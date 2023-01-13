namespace src.Object
{
    public class Obj
    {
        private double _position;
        public double position
        {
            get => _position;
            set => _position = value;
        }

        private double _weight;
        public double weightObj
        {
            get => _weight;
            set => _weight = value;
        }

        // constructor
        public void constructorObject(double weightObjP, double positionP)
        {
            weightObj = weightObjP;
            position = positionP;
        }
    }
}