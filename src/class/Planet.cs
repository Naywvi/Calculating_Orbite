using src.Object;

namespace src.Planet
{
    public class PlanetClass : Obj
    {
        private double _diameter;
        public double diameter
        {
            get => _diameter;
            set => _diameter = value;
        }

        private Obj _obj = new Obj();
        public Obj obj
        {
            get => _obj;
            set => _obj = value;
        }

        //Constructor
        public void constructorPlanet(double weightObj, double position, double diameterP)
        {
            diameter = diameterP;
            _obj.constructorObject(weightObj, position);
        }
    }
}