using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine(car.CarId + " " + car.CarName + " " + car.BrandName +  " " + car.ColorName + " " + car.DailyPrice);

            }

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
    }
}
