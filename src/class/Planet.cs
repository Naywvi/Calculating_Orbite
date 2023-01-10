using src.Object;

namespace src.Planet {
    public class PlanetClass : Obj{
        private int _diameter;
        public int diameter{
            get => _diameter;
            set => _diameter = value;
        }

        protected void constructor(int weightObj,int position,int diameter){
            this.weightObj = weightObj;
            this.position = position;
            this.diameter = diameter;
        }
    }
}