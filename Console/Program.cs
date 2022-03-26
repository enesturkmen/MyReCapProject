using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddCarTest();
            //GetAllTest();
            //AddBrandTest();
            //JoinTest();
            //ColorAddTest();
            //AddUserTest();
            //AddCustomerTest();

        }

        private static void AddCustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                UserId = 1,
                CompanyName = "Tuerkmen"
            });
        }

        private static void AddUserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                //UserId = 1,
                FirstName = "Cennet",
                LastName = "Bilgin",
                Email = "cennet@gmail.com",
                Password = "12345"
            });
        }

        private static void ColorAddTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color
            {
                ColorId = 1,
                ColorName = "White"
            });
        }

        private static void JoinTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.IsSuccess == true)
            {
                foreach (var car in result.Data)
                {
                    System.Console.WriteLine("{0} --- {1} --- {2} --- {3}", car.CarName, car.BrandName,
                                                                            car.ColorName, car.DailyPrice);
                }
            }
            
        }

        private static void AddBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand
            {
                BrandId = 1,
                BrandName = "Egea"
            });
        }

        private static void GetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.IsSuccess == true)
            {
                foreach (var p in result.Data)
                {
                    System.Console.WriteLine(p.CarName + "---" + p.ModelYear);
                }
            }
            
        }

        private static void AddCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                CarId = 2,
                BrandId = 2,
                ColorId = 2,
                CarName = "Fiat",
                DailyPrice = 450,
                Description = "UnAvailable",
                ModelYear = 2022
            });
        }
    }
}
