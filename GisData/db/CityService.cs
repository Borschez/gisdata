using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GisData.db
{
    public class CityService
    {
        private GisDbContext _gisDbContext = null;

        public CityService(GisDbContext context)
        {
            _gisDbContext = context;
        }

        public City AddCity(City city)
        {
            City result = _gisDbContext.Cities.Add(city);            
            _gisDbContext.SaveChanges();

            return result;
        }
        
        public City CreateCity(long gis_id, string name)
        {
            City city = new City
            {
                Gis_Id = gis_id,
                Name = name
            };

            return city;
        }

        public bool IsCityExist(City city)
        {

            var queryLondonCustomers = from cityT in _gisDbContext.Cities
                                       where city.Name == "Москва"
                                       select cityT;
            
            return _gisDbContext.Entry(city).State == System.Data.Entity.EntityState.Unchanged;
        }

        public City FindByName(string name)
        {
            var result = _gisDbContext.Cities.Where(x => x.Name == name).FirstOrDefault();
            
            return result;
        }
    }
}
