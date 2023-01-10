namespace src.Position;
class Postion{
    private int _x;
    public int x{
        get => _x;
        set => _x = value;
    }
    public string xString{
        get => _x.ToString();
    }
    private int _y;
    public int y{
        get => _y;
        set => _y = value;
    }
    public string yString{
        get => _y.ToString();
    }
    public string myPosition(){
        var postionString = "\n position:  x: "+this.yString+" km \n            y: "+this.xString+" km\n";
        return postionString;
    }
}
