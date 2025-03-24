using Formula1.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Controllers
{
    public class DriverController
    {
        Formula1Context context = new Formula1Context();
        public async Task<List<Driver>> GetAllDrivers()
        {
            var drivers = await context.Drivers.ToListAsync();
            return drivers;
        }
        public async Task<Driver> GetDriverById(int driverId)
        {
            var drivers = await context.Drivers.FirstOrDefaultAsync(d => d.DriverId == driverId);
            return drivers;
        }
        public async Task<Driver> GetDriverByLastName(string lastName)
        {
            var drivers = await context.Drivers.FirstOrDefaultAsync(d => d.LastName == lastName);
            return drivers;           
        }
        public async Task<List<Driver>> GetDriversByNationality(string nationality)
        {
            var drivers=await context.Drivers.Where(d=>d.Nationality == nationality)
                                             .ToListAsync();
            return drivers;
        }
    }
}
