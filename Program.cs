using src.Position; // using the Position namespace, planet etc
using src.Planet;
using src.Simulation;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            var main = new Program(); // creates a new object of type Program
            Console.WriteLine(main._sentences[7]);  // displays the 7th sentence from the _sentences array

            var pos = new Pos(); // creates a new object of type Pos
            pos.constructorPosition(main.generatePostion(1), main.generatePostion(2)); // calls the constructorPosition function on the pos object

            var planet = new PlanetClass(); // creates a new object of type PlanetClass
            planet.constructorPlanet(main.generatePostion(3), 0, main.generatePostion(4)); // calls the constructorPlanet function on the planet object

            var simulation = new Simulation(); // creates a new object of type Simulation
            simulation.constructorSimulation(planet, pos); // calls the constructorSimulation function on the simulation object
        }

        private int generatePostion(int sentence)
        { // function to generate a position
            Console.WriteLine("Please enter" + _sentences[sentence]); // prompts the user to enter a position
            var _OstdIn = Console.ReadLine(); // stores the user's input
            if (sentence == 6)
            {
                return 0; // returns 0 if the sentence passed as a parameter is 6
            }
            else
            {
                if (!int.TryParse(_OstdIn, out int result))
                { // check if the input is an integer
                    Console.WriteLine(_sentences[0]); // displays an error message if it is not an integer
                    _OstdIn = Console.ReadLine(); // gets the input again
                }
                return result; // returns the input converted to an integer
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
