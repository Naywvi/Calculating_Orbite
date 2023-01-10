namespace src.Object;
class Object{
    private int _position;
    public int positionObj{
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