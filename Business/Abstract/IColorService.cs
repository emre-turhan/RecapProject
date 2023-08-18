using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        DataResult<Color> GetByID(int id);
        DataResult<List<Color>> GetAll();
        IResult Add(Color car);

        IResult Update(Color car);

        IResult Delete(Color car);
    }
}
