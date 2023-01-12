using src.Position;
using src.Planet;
using src.Simulation;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            var main = new Program();

            Console.WriteLine(main._sentences[7]);

            var pos = new Pos();
            pos.constructorPosition(main.generatePostion(1), main.generatePostion(2));

            var planet = new PlanetClass();//Object start pos = 0 need launch
            planet.constructorPlanet(main.generatePostion(3), 0, main.generatePostion(4));

            var simulation = new Simulation();
            simulation.constructorSimulation(planet, pos);
        }

        private int generatePostion(int sentence)
        {
            Console.WriteLine("Please enter" + _sentences[sentence]);
            var _OstdIn = Console.ReadLine();
            if (sentence == 6)
            {
                return 0;
            }
            else
            {
                if (!int.TryParse(_OstdIn, out int result))
                {
                    Console.WriteLine(_sentences[0]);
                    _OstdIn = Console.ReadLine();
                }
                return result;
            }

        }

        private string[] _sentences = new string[] {
            "Bad input try again.",
            " a starting x position for your object (km) : ",
            " a starting y position for your object (km) : ",
            " the weight of your object : ",
            " the diameter of your planet : ",
            " the angle of throw (Degree) : ",
            " throw speed (km)  MAX 180 : ",
            "Welcome to the Orbit project !",
            };
    }
}
//Besoin de récup