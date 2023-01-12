using src.Position;
using src.Planet;
using src.Object;

namespace main{
    class Program{
        static void Main(string[] args){
            var main = new Program();

            Console.WriteLine(main._sentences[5]);

            var pos = new Position();
            pos.constructorPosition(main.generatePostion(1),main.generatePostion(2));

            var planet = new PlanetClass();//Object start pos = 0 need launch
            planet.constructorPlanet(main.generatePostion(3), 0, main.generatePostion(4));
        
            //Console.WriteLine(pos.showPosition());
            //Console.WriteLine(planet.diameter + " - " + planet.obj.position + " = " + planet.obj.weightObj);
        }

        private int generatePostion(int sentence){
            Console.WriteLine("Please enter" + _sentences[sentence]);
            var _OstdIn = Console.ReadLine();
            if (!int.TryParse(_OstdIn, out int result)){
                Console.WriteLine(_sentences[0]);
                _OstdIn = Console.ReadLine();
            }
            return result;
        }
        private string[] _sentences = new string[] {
            "Bad input try again.",
            " a starting x position for your object (in km) : ",
            " a starting y position for your object (in km) : ",
            " the weight of your object : ",
            " the diameter of your planet : ",
            "Welcome to the Orbit project !",
            };
    }
}
