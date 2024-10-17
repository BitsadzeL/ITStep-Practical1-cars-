using System.Xml.Schema;

namespace practical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"../../../vehicles.csv");
            List<Car> allCars = Car.parse(input);
            List<Car> mercedeses = Car.GetAllMercedes(allCars);
            List<Car> economyCars=Car.Get10EconomyCars(allCars);
            
            foreach (Car car in mercedeses)
            {
                Console.WriteLine(car.ToString());
            }     
        }
    }
}
