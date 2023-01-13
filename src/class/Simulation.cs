using src.Planet;
using src.Object;
using src.Position;

namespace src.Simulation
{

    public class Simulation : PlanetClass
    {
        private double _speed;
        public double speed
        {
            get => _speed;
            set => _speed = value;
        }
        private double _throwingAngle;
        public double throwingAngle
        {
            get => _throwingAngle;
            set => _throwingAngle = value;
        }

        //Constructor simulation
        public void constructorSimulation(PlanetClass planet, Pos pos, double speedP, double throwingAngleP)
        {
            speed = speedP;
            throwingAngle = throwingAngleP;

            Console.WriteLine(pos.showPosition());
            Console.WriteLine(planet.diameter + " - " + planet.obj.position + " = " + planet.obj.weightObj);
        }
    }
}
