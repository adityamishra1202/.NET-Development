using _29_July.Models;

namespace _29_July.Services
{
    public interface IVehicleService
    {
        List<Vehicle> GetVehicles();
        Vehicle AddVehicle(Vehicle vehicle);

        Vehicle UpdateVehicle(int id, Vehicle vehicle);
        List<Vehicle> GetVehicleByWheels(int wheels); 

    }
}
