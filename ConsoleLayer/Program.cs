using Business.Concrete;
using Entity.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;

internal class Program
{
    private static void Main(string[] args)
    {
        //CarTest();
        //ColorTest();
        //BrandTest();
        CarManager carManager = new CarManager(new EfCarDal());
        foreach (var carINFO in carManager.GetAllCarInfo())
        {
            Console.WriteLine( 
            carINFO.CarName + "---" + carINFO.BrandName + "---" +
            carINFO.ColorName + "---" + carINFO.DailyPrice );
        }
        ;
    }

    private static void BrandTest()
    {
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        brandManager.Add(new Brand { Id = 1, Name = "Audi" });
        brandManager.Add(new Brand { Id = 2, Name = "Mercedes" });
        brandManager.Add(new Brand { Id = 3, Name = "Bmw" });
        brandManager.Add(new Brand { Id = 4, Name = "Toyota" });

        foreach (var brand in brandManager.GetAll())
        {
            Console.WriteLine(brand.Name);
        }
    }

    private static void ColorTest()
    {
        ColorManager colorManager = new ColorManager(new EfColorDal());
        colorManager.Add(new Color { ID = 1, Name = "Red" });
        colorManager.Add(new Color { ID = 2, Name = "Blue" });
        colorManager.Add(new Color { ID = 3, Name = "Black" });
        colorManager.Add(new Color { ID = 4, Name = "Magenta" });

        foreach (var color in colorManager.GetAll())
        {
            Console.WriteLine(color.Name);
        }
    }

    private static void CarTest()
    {
        CarManager carManager = new CarManager(new EfCarDal { });

        //carManager.Add(new Car
        //{
        //    ID = 1,
        //    BrandID = 1,
        //    ColorID = 1,
        //    DailyPrice = 100,
        //    Description = "Audi Car",
        //    ModelYear = 2019
        //});
        carManager.Add(new Car
        {
            ID = 2,
            BrandID = 2,
            ColorID = 2,
            DailyPrice = 100,
            Description = "CAR2",
            ModelYear = 2019
        });
        carManager.Add(new Car
        {
            ID = 3,
            BrandID = 3,
            ColorID = 3,
            DailyPrice = 100,
            Description = "CAR3",
            ModelYear = 2019
        });
        carManager.Add(new Car
        {
            ID = 4,
            BrandID = 4,
            ColorID = 4,
            DailyPrice = 100,
            Description = "CAR4",
            ModelYear = 2019
        });

        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.Description);
        }
    }
}