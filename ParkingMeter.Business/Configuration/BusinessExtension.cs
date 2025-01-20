using Microsoft.Extensions.DependencyInjection;
using ParkingMeter.Business.Abstract;
using ParkingMeter.Business.Concrete;
using ParkingMeter.Repository.Shared.Abstract;
using ParkingMeter.Repository.Shared.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMeter.Business.Configuration
{
    public static class BusinessExtension
    {
        public static void BusinessDI(this IServiceCollection services)
        {
            services.AddScoped<IParkSlotService, ParkSlotService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped<IParkingService, ParkingService>();
        }

        public static void RepositoryDI(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
