using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;
using Entities;
using System;

namespace ConsoleUI
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetAll())

            {
                Console.WriteLine(item.DailyPrice);

            }
            carManager.Add(new Car { Name = "t", DailyPrice = 500 ,ColorId=1,BrandId=1});

        }




    }
}
