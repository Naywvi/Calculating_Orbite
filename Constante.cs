using System.Numerics;

namespace src.Constante
{
    public class Const
    {
        private const int _gravity = 9;
        public int gravity
        {
            get => _gravity;
        }
        // This method calculates a direction vector from a position, an angle and a speed
        public Vector2 generateVectorDirection(int angle, int speed)
        {
            double angleRad = angle * Math.PI / 180; // convert angle to radian
            double x = speed * Math.Cos(angleRad);
            double y = speed * Math.Sin(angleRad);
            return new Vector2((int)x, (int)y);
        }
        // This method is used to calculate the distance between two objects | using coordinates and diameters between the two objects
        public int generateDistance(int x1, int y1, int diameter1, int x2, int y2, int diameter2)
        {
            int distance = (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + (Math.Pow((diameter1 + diameter2) / 2, 2)));
            return distance;
        }
        // This method calculates the gravitational force between two masses at a given distance
        public int generateGravityStrength(int mass1, int mass2, int distance)
        {
            return _gravity * mass1 * mass2 / distance * distance;
        }
    }

}