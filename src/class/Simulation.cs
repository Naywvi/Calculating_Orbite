using src.Planet;
using src.Object;

namespace src.Simulation{

    public interface ObjectA{
        public class Planet{
            public PlanetClass constructorObjectA(){
                return new PlanetClass();
            }
        }
    }
    public interface ObjectB{
        public class Object{
            public Obj constructorObjectB(){
                return new Obj();
            }
        }
    }

    abstract class Simulation : ObjectA ,ObjectB{
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
        public void simulation(){
            var a = new ObjectA.Planet();
            var b = new ObjectB.Object();
            a.constructorObjectA();
        }
    }
}
