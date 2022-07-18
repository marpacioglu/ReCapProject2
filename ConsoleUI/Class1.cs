using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;
using Entities;
using Entities.Concreate;
using System;

namespace ConsoleUI
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            //CarDetailTest();

            // UserAdd();
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Console.WriteLine(rentalManager.Add(new Rental { CarId = 4, RentDate = new DateTime(2022, 07, 06), CustomerId = 1 }).Message);
        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User u1 = new User();
            u1.FirstName = "dfsdf";
            u1.LastName = "dfsdf";
            u1.Email = "dfdsfs@hotmail.com";
            u1.Password = "123";
            u1.Status = true;


            userManager.Add(u1);
        }

        private static void CarDetailTest()
        {
           /* CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetail())

            {
                Console.WriteLine(item.CarId + " " + item.CarName + " " + item.ColorName + " " + item.BrandName + " " + item.DailyPrice);

            }*/
        }
    }
}
