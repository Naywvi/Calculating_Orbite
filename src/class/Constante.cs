// using System.Numerics;

// namespace src.Constante{
//     public class Const{
//         private const double _gravity = 9;
//         public double gravity{
//             get => _gravity;
//         }

//         // public Vector2 generateVectorDirection(Position position, double angle, double speed) <--------- pas compris le Position position


//         // This method calculates a direction vector from a position, an angle and a speed.
//         public Vector2 generateVectorDirection(double angle, double speed){
//             double angleRad = angle * Math.PI / 180; // convert angle to radian
//             double x = speed * Math.Cos(angleRad);
//             double y = speed * Math.Sin(angleRad);
//             return new Vector2((float)x, (float)y);
//         }

//         // This method is used to calculate the distance between two objects | using coordinates and diameters between the two objects
//         public double generateDistance(double x1, double y1, double diameter1,double x2, double y2, double diameter2){
//             double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + (Math.Pow((diameter1 + diameter2) / 2, 2)));
//             return distance;
//         }

//         // This method calculates the gravitational force between two masses at a given distance
//          public double generateGravityStrength(double mass1, double mass2, double distance){
//             return _gravity * mass1 * mass2 / Math.Pow(distance, 2);
//         }
//     }
// }

using System.Numerics;

namespace src.Constante
{
    public class Const
    {
        private const double _gravity = 9;
        public double gravity
        {
            get => _gravity;
        }

        // public Vector2 generateVectorDirection(Position position, double angle, double speed) <--------- pas compris le Position position


        // This method calculates a direction vector from a position, an angle and a speed.
        public Vector2 generateVectorDirection(double angle, double speed)
        {
            double angleRad = angle * Math.PI / 180; // convert angle to radian
            double x = speed * Math.Cos(angleRad);
            double y = speed * Math.Sin(angleRad);
            return new Vector2((float)x, (float)y);
        }

        // This method is used to calculate the distance between two objects | using coordinates and diameters between the two objects
        public double generateDistance(double x1, double y1, double diameter1, double x2, double y2, double diameter2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + (Math.Pow((diameter1 + diameter2) / 2, 2)));
            return distance;
        }

        // This method calculates the gravitational force between two masses at a given distance
        public double generateGravityStrength(double mass1, double mass2, double distance)
        {
            return _gravity * mass1 * mass2 / Math.Pow(distance, 2);
        }
        // this method calculates the Gravity Components 

        //ici le F va représenter le résultat de ma force gravitationnelle trouvée grâc au calcul du dessus
        double CalculateGravityComposantX(double F, double x1, double x2, double distance)
        {
            return F * (x2 - x1) / distance;
        }
        // cette methode sera à faire 2 fois pour avoir la composante X et celle de Y
        // ce calcul nous servira pour l'accélération ensuite (il nous faut les composant gravitationnels de x et y)

        (double, double) CalculateAcceleration(double Fx, double Fy, double m, out double ax, out double ay)
        {
            ax = Fx / m;
            ay = Fy / m;
            return (ax, ay);
        }


    }
}