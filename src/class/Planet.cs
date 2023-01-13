using src.Object;

namespace src.Planet {
    public class PlanetClass : Obj{
        private int _diameter;
        public int diameter{
            get => _diameter;
            set => _diameter = value;
        }

        private Obj _obj = new Obj();
        public Obj obj{
            get => _obj;
            set => _obj = value;
        }
        
        //Constructor
        public void constructorPlanet(int weightObj,int position,int diameterP){
            diameter = diameterP;
            _obj.constructorObject(weightObj,position);
        }
    }
}