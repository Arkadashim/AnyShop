using AnyShop.Models;

namespace AnyShop.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; set; }
        Car getObjectCars(int carID);
    }
}
