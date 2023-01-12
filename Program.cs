using src.Position;
using src.Planet;
using src.Object;

namespace main{
    class Program{
        static void Main(string[] args){
            var main = new Program();

            Console.WriteLine("Welcome to the Orbit project !");

            var pos = new Position();
            pos.constructorPosition(main.generatePostion(1),main.generatePostion(2));

            var obj = new Obj();
            //obj.diameter = main.generatePostion(4);
            obj.constructorObject(obj.weightObj,obj.position);

            var planet = new PlanetClass();
            planet.constructorPlanet(main.generatePostion(7), main.generatePostion(5), main.generatePostion(6));
        }

        private int generatePostion(int sentence){
            Console.WriteLine("Please enter",_sentences[sentence]);
            var _OstdIn = Console.ReadLine();
            if (!int.TryParse(_OstdIn, out int result)){
                Console.WriteLine(_sentences[0]);
                _OstdIn = Console.ReadLine();
            }
            return result;
        }
        private string[] _sentences = new string[] {
            "Entrée non valide. Veuillez entrer un nombre valide.",
            " a starting x position for your object (in km) : ",
            " a starting y position for your object (in km) : ",
            " a starting position for your object :",
            " a starting position for your object : ",
            " the mass of your object : ",
            " the diameter of your object : ",
            " a starting position for your planet : ",
            " the mass of your planet : ",
            " the diameter of your planet : "
            };
    }
}
