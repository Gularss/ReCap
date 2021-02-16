using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetailDtos();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + " " + car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);

                }
            }

            Console.WriteLine("----------------------------");
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result2 = rentalManager.Add(new Rental
            {
                Id = 1,
                CarId = 2,
                CustomerId = 1,
                RentDate = new DateTime(2008, 6, 1, 7, 47, 0),
                ReturnDate = new DateTime(2008, 6, 1, 7, 47, 0)
            });

            Console.WriteLine(result2.Message);

            //UserAddedMethod();

            //Car carById = carManager.GetById(1);
            //Console.WriteLine(carById.DailyPrice);

            //Car carToAdd = new Car()
            //{
            //    Id = 5,
            //    BrandId = 2,
            //    ColorId = 3,
            //    DailyPrice = 100000,
            //    ModelYear = 2021,
            //    Description = "Son model"
            //};
            //carManager.Add(carToAdd);
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id + " " + car.ModelYear + " " + car.Description);

            //}

            //Car carToUpdate = new Car()
            //{
            //    Id = 1,
            //    BrandId = 3,
            //    ColorId = 1,
            //    DailyPrice = 40000,
            //    Description = "Güncel Versiyon",
            //    ModelYear = 2005
            //};
            //carManager.Update(carToUpdate);
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id + " " + car.ModelYear + " " + car.Description);

            //}


            //Console.WriteLine("Hello World!");

            ////Delete Car 2
            //Console.WriteLine("Silmek istediğiniz aracın Id sini giriniz:");
            //int v = Convert.ToInt32(Console.ReadLine());
            //int delNo = v;
            //Car carToDelete = carManager.GetById(delNo);
            //carManager.Delete(carToDelete);
            //Console.WriteLine("Araç silindi: " + carToDelete.Id + ":" + carToDelete.Description + "\n");

        }

        private static void UserAddedMethod()
        {
            Customer customerToAdd1 = new Customer()
            {
                Id = 1,
                UserId = 1,
                CompanyName = "A"
            };
            Customer customerToAdd2 = new Customer()
            {
                Id = 2,
                UserId = 2,
                CompanyName = "B"
            };

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(customerToAdd1);
            customerManager.Add(customerToAdd2);
        }
    }
}
