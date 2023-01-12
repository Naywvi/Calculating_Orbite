using src.Planet;
using src.Object;

namespace src.Simulation{

        abstract class Simulation : PlanetClass {
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
        public void constructorSimulation(){

        }
    }
}
