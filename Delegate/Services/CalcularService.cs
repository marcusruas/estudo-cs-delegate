namespace Delegate.Services
{
    public class CalcularService
    {
        public static double Max(double x, double y){
            return (x > y) ? x : y;
        }

        public static double Sum(double x, double y){
            return x + y;
        }

        public static double square(double x){
            return x * x;
        }
    }
}