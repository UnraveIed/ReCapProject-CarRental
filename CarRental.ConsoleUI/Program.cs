// See https://aka.ms/new-console-template for more information
using CarRental.Business.Abstract;
using CarRental.Business.Concrete;
using CarRental.DataAccess.Abstract;
using CarRental.DataAccess.Concrete;
using CarRental.DataAccess.Concrete.EntityFramework.Repositories;

CarManager b = new(new UnitOfWork(new CarRental.DataAccess.Concrete.EntityFramework.Contexts.CarRentalContext()));

var selectedCar = await b.GetDetailAsync(2);

Console.WriteLine(selectedCar.ColorName);

//foreach (var car in await b.GetAll())
//{
//    Console.WriteLine(car.ModelYear);
//}
