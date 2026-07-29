using _29_July.Models;

namespace _29_July.Services
{
    public class VehicleService:IVehicleService
    {
        private static List<Vehicle> vehicles = new List<Vehicle>() { 

            new Vehicle{ Id=7054,Name="Car",No_of_wheels=4,Max_speed=100,Brand="Suzuki" },
             new Vehicle{ Id=9234,Name="Bus",No_of_wheels=6,Max_speed=130,Brand="Volvo" },
 new Vehicle{ Id=7084,Name="Car",No_of_wheels=4,Max_speed=130,Brand="WolksSwagan" },
  new Vehicle{ Id=7154,Name="Bike",No_of_wheels=2,Max_speed=180,Brand="Kawasaki" }

        };
       public  List<Vehicle> GetVehicles()
        {
            return (vehicles);

        }
       public Vehicle AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            return vehicle;

        }

        public Vehicle UpdateVehicle(int id, Vehicle vehicle)
        {
            var existing=vehicles.FirstOrDefault(x => x.Id == id);
           
            if(existing ==null)
            {
                return null;
            }
            existing.Max_speed = vehicle.Max_speed;
            return existing;
        }
        public List<Vehicle > GetVehicleByWheels(int wheels)
        {
            var result=vehicles.Where(c=>c.No_of_wheels==wheels).ToList();
            if (result == null) return null;
            return result;  
        }
    }
}
