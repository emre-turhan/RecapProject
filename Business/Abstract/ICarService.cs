using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        DataResult<Car> GetByID(int id);
        DataResult<List<Car>> GetAll();
        DataResult<List<Car>> GetCarsByBrandID(int id);
        DataResult<List<Car>> GetCarsByColorID(int id);
        IResult Add(Car car);

        IResult Update(Car car);

        IResult Delete(Car car);

        DataResult<List<CarDetailDto>> GetAllCarInfo(); 
    }
}
