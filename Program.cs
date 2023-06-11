using MyClassLibrary;

namespace ClassLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class Libraries
            //connect the  class library to application
            List<Vehicle> _vehicles = new List<Vehicle>();
            _vehicles.Add(new Land("Aston Martin"));
            _vehicles.Add(new Sea("SSLetzSea"));
            _vehicles.Add(new Air("Moiz"));
            _vehicles.Add(new Plane("Boeing 747"));
            _vehicles.Add(new Helicopter("Bell AH-1 Cobra"));

            foreach (Vehicle vehicle1s in _vehicles)
            {
                Console.WriteLine(vehicle1s);
            }
        }
    }
}