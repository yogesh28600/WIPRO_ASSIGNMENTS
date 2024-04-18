namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDrivable car = new Car();
            // The below menthods implement polymorphism as the IDrivable object cthat is created will decide whether the method should be called from Car class or Bycycle class
            car.start();
            car.drive();
            car.stop();
        }
    }
}
