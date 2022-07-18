using Core.DataAccess;
using DataAccess.Concreate.EntityFramework;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join col in context.Colors
                             on c.ColorId equals col.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             select new CarDetailDto { CarId = c.Id, CarName = c.Name, BrandName = b.BrandName, ColorName = col.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();

            }

        }

    }
}
