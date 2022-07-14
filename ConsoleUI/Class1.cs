using Business.Concreate;
using DataAccess.Concreate.InMemory;
using System;

namespace ConsoleUI
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var item in carManager.GetAll())

            {
                Console.WriteLine(item.Description);

            }

        }




    }
}
