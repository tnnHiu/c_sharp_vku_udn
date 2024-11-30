using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// dotnet ef dbcontext scaffold
// "server=TNN-HIU-LEGION-;
// database = MyStock;
// uid=tnnh;pwd=10012003;
// TrustServerCertificate=True"
// Microsoft.EntityFrameworkCore.SqlServer
// --output-dir DataAccess


namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public IEnumerable<Car> GetCars() => CarManagement.Instance.GetCarList();
        public Car GetCarById(int carId) => CarManagement.Instance.GetCarById(carId);
        public void InsertCar(Car car) => CarManagement.Instance.AddNEw(car);
        public void UpdateCar(Car car) => CarManagement.Instance.Update(car);
        public void DeleteCar(Car car) => CarManagement.Instance.Remove(car);
    }
}
