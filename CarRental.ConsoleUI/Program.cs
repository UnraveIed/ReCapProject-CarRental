// See https://aka.ms/new-console-template for more information
using CarRental.Business.Abstract;
using CarRental.Business.Concrete;
using CarRental.DataAccess.Abstract;
using CarRental.DataAccess.Concrete;
using CarRental.DataAccess.Concrete.EntityFramework.Repositories;
using CarRental.Entities.Concrete;

CarManager car = new(new UnitOfWork(new CarRental.DataAccess.Concrete.EntityFramework.Contexts.CarRentalContext()));
ColorManager c = new(new UnitOfWork(new CarRental.DataAccess.Concrete.EntityFramework.Contexts.CarRentalContext()));
BrandManager b = new(new UnitOfWork(new CarRental.DataAccess.Concrete.EntityFramework.Contexts.CarRentalContext()));

//await CarOperations(car);
//await ColorOperations(c);
//await BrandOperations(b);

foreach (var item in await car.GetCarDetail())
{
    Console.WriteLine(item.CarId);
    Console.WriteLine(item.ColorName);
    Console.WriteLine(item.BrandName);
    Console.WriteLine(item.DailyPrice);
}


static async Task CarOperations(CarManager car)
{
    Car car1 = new()
    {
        BrandId = 2,
        ColorId = 3,
        DailyPrice = 245000.00M,
        Description = "Kullanisli",
        ModelYear = 2005,
    };

    var addedCar = await car.AddAsync(car1);
    Console.WriteLine(addedCar.Description + " eklendi");


    var updateCar = car1;
    car1.Description = "Degisti";
    var updatedCar = await car.UpdateAsync(updateCar);
    Console.WriteLine(updatedCar.Description + " guncellendi");

    await car.DeleteAsync(updatedCar);
}

static async Task ColorOperations(ColorManager c)
{
    Color color1 = new()
    {
        Name = "Yesil"
    };

    var addedColor = await c.AddAsync(color1);
    Console.WriteLine(addedColor.Name + " eklendi");

    var updateColor = addedColor;
    updateColor.Name = "Yeşils";
    var updatedColor = await c.UpdateAsync(updateColor);
    Console.WriteLine(updatedColor.Name + " guncellendi");

    await c.DeleteAsync(updatedColor);
}

static async Task BrandOperations(BrandManager b)
{
    Brand brand1 = new()
    {
        Name = "Toyota"
    };

    var addedBrand = await b.AddAsync(brand1);
    Console.WriteLine(addedBrand.Name + " eklendi");


    var updateBrand = brand1;
    brand1.Name = "Degisti";
    var updatedBrand = await b.UpdateAsync(updateBrand);
    Console.WriteLine(updatedBrand.Name + " guncellendi");

    await b.DeleteAsync(updatedBrand);
}