using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    public class CarManager : ICarService
    {
        ICarDal carDal;

        public CarManager(ICarDal carDal)
        {
            this.carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length < 2 || car.DailyPrice <= 0)
                Console.WriteLine("Car could not be added due to business rules");
            carDal.Add(car);
            return new SuccessResult();
        }

        public IResult Delete(Car car)
        {
            carDal.Delete(car);
            return new SuccessResult();
        }

        public DataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(carDal.GetAll());
        }

        public DataResult<List<CarDetailDto>> GetAllCarInfo()
        {
            return new SuccessDataResult<List<CarDetailDto>>(carDal.getAllCarDetails());
        }

        public DataResult<Car> GetByID(int id)
        {
            return new SuccessDataResult<Car>(carDal.get(c=> c.ID == id));
        }

        public DataResult<List<Car>> GetCarsByBrandID(int id)
        {
            return new SuccessDataResult<List<Car>>(carDal.GetAll(c => c.BrandID == id));
        }

        public DataResult<List<Car>> GetCarsByColorID(int id)
        {
            return new SuccessDataResult<List<Car>>(carDal.GetAll(c => c.ColorID == id));
        }

        public IResult Update(Car car)
        {
            carDal.Update(car);
            return new SuccessResult();
        }
    }
}
