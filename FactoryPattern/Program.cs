namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the number of tires of the car you want to create.");
                 input = int.TryParse(Console.ReadLine(), out wheelCount);

            } while (input == false);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
            
        }
    }
}
