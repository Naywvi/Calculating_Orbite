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
        // public int objWeight{
        //     get => _obj.weightObj;
        //     set => _obj.weightObj = value;
        // }
        private void generateObject(int weightObj,int position){
            _obj.constructorObject(weightObj,position);
        }

        public void constructorPlanet(int weightObj,int position,int diameterP){
            diameter = diameterP;
            generateObject(weightObj,position);
        }
    }
}