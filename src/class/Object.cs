namespace src.Object{
    public class Obj{
        private int _position;
        public int position{
            get => _position;
            set => _position = value;
        }
        private string positionObjStr{
            get => _position.ToString();
        }

        private int _weight;
        public int weightObj{
            get => _weight;
            set => _weight = value;
        }
        private string weightObjStr{
            get => _weight.ToString();
        }

    }
}