using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entity.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentaCarDBContext>, ICarDal
    {
        public List<CarDetailDto> getAllCarDetails()
        {
            using (RentaCarDBContext context = new RentaCarDBContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors on c.ColorID equals co.ID
                             join b in context.Brands on  c.BrandID equals b.Id
                             select new CarDetailDto
                             {
                                BrandName = b.Name,
                                CarName = c.Description,
                                ColorName = co.Name,
                                DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }


}

