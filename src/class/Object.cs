namespace src.Object{
    public class Obj{
        private int _position;
        public int position{
            get => _position;
            set => _position = value;
        }
        private int _weight;
        public int weightObj{
            get => _weight;
            set => _weight = value;
        }
        
        public void constructorObject(int weightObj,int position){
            this.weightObj = weightObj;
            this.position = position;
        }

    }
}