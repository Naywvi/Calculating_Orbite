using src.Planet;
using src.Object;

namespace src.Simulation{

    public interface A{
        public class Planet{
            public PlanetClass constructor(){
                return new PlanetClass();
            }
            //test method
            public void printer(){
                Console.WriteLine("test");
            }
        }
    }
    public interface B{
        public class Object{
            public Obj constructor(){
                return new Obj();
            }
            //Crée le constructor ici pour l'object
        }
    }

    abstract class Simulation : A,B{
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
            var a = new A.Planet();
            var b = new B.Object();
            a.constructor();
            a.printer();
        }
    }
}
