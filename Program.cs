using src.Position;

namespace main{
    class Program{
        static void Main(string[] args){
            var p = new Postion();
            p.x = 10;
            p.y = 30;
            Console.WriteLine(p.myPosition());
        }
    }
}
