using src.Planet;
using src.Object;
using src.Position;

namespace src.Simulation{

        public class Simulation : PlanetClass {
        private int _speed;
        public int speed{
            get => _speed;
            set => _speed = value;
        }
        private int _throwingAngle;
        public int throwingAngle{
            get => _throwingAngle;
            set => _throwingAngle = value;
        }
        public void constructorSimulation(PlanetClass planet,Pos pos){
            Console.WriteLine(pos.showPosition());
            Console.WriteLine(planet.diameter + " - " + planet.obj.position + " = " + planet.obj.weightObj);
        
        }
    }
}
