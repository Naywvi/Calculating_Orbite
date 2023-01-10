namespace src.Object{
    class Obj{
        private int _position;
        public int position{
            get => _position;
            set => _position = value;
        }
        public string positionObjStr{
            get => _position.ToString();
        }

        private int _weight;
        public int weightObj{
            get => _weight;
            set => _weight = value;
        }
        public string weightObjStr{
            get => _weight.ToString();
        }
    }
}