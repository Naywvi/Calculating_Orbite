using src.Position; // using the Position namespace, planet etc
using src.Planet;
using src.Simulation;

namespace main
{
    class Program{

        //Setup all constructors
        static void Main(string[] args){
            var main = new Program();
            Console.WriteLine(main._sentences[7]);

            var pos = new Pos();
            pos.constructorPosition(main.userPromp(1), main.userPromp(2));

            var planet = new PlanetClass();
            planet.constructorPlanet(main.userPromp(3), 0, main.userPromp(4));

            var simulation = new Simulation();
            simulation.constructorSimulation(planet,pos,main.userPromp(5),main.userPromp(6));
        }

        //Generate from user input for constructors
        private int userPromp(int sentence){
            Console.WriteLine("[+] - Please enter" + _sentences[sentence]);
            var _OstdIn = Console.ReadLine();
            if (sentence == 6){//Special verification for degree
                
                if(int.Parse(_OstdIn) > 180 || int.Parse(_OstdIn) <= 0){//Check if input (>180 & <= 0)
                    Console.WriteLine(_sentences[0]);
                    return userPromp(6);
                }
                if (!int.TryParse(_OstdIn, out int result) ){
                    Console.WriteLine(_sentences[0]);
                    _OstdIn = Console.ReadLine();
                }
                return result;

            }else{
                if (!int.TryParse(_OstdIn, out int result)){ // check if the input is an integer
                    Console.WriteLine(_sentences[0]);
                    _OstdIn = Console.ReadLine();
                }
                return result;
            }
        }
        
        private string[] _sentences = new string[] {
            "[-] - Bad input try again.",
            " a starting x position for your object (km) : ",
            " a starting y position for your object (km) : ",
            " the weight of your object : ",
            " the diameter of your planet : ",
            " throw speed (km/s | example : 190) : ",
            " the angle of throw (degree) MAX 180 : ",
            "Welcome to the Orbit project !",
            };
    }
}