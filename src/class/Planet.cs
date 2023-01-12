using src.Object;

namespace src.Planet {
    public class PlanetClass : Obj{
        private int _diameter;
        public int diameter{
            get => _diameter;
            set => _diameter = value;
        }
        public void showPlanetPosition(){
            
        }
        public void constructorPlanet(int weightObj,int position,int diameter){
            var Obj = new Obj();
            Obj.constructorObject(weightObj,position);
            this.diameter = diameter;
        }
    }
}