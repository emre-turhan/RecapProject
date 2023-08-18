using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal colordal;

        public ColorManager(IColorDal colordal)
        {
            this.colordal = colordal;
        }

        public IResult Add(Color color)
        {

            colordal.Add(color);
            return new SuccessResult();
        }

        public IResult Delete(Color color)
        {
            colordal.Delete(color);
            return new SuccessResult();
        }

        public DataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>( colordal.GetAll());
        }

        public DataResult<Color> GetByID(int id)
        {
            return new SuccessDataResult<Color>(colordal.get(c => c.ID == id));
        }

        public DataResult<List<Color>> GetCarsByBrandID(int id)
        {
            return new SuccessDataResult<List<Color>>(colordal.GetAll(c => c.ID == id));
        }

        public DataResult<List<Color>> GetCarsByColorID(int id)
        {
            return new SuccessDataResult<List<Color>>(colordal.GetAll(c => c.ID == id));
        }

        public IResult Update(Color color)
        {
            colordal.Update(color);
            return new SuccessResult();
        }
    }
}
