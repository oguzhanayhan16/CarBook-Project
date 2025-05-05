using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.ViewModels;
using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.CarPricingInterface
{
   public interface ICarPricingRepository
    {
        List<CarPricing> GetCarPricingWithCar();
        List<CarPricingViewModel> GetCarPricingWithTimePeriod1();
    }
}
