using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using GisData.db;

namespace GisWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class GisService : IGisService
    {
        private string dbContext;
        private GisDbContext gisDbContext;
        private CityService cityService; 


        public GisService() : base()
        {
            dbContext = ConfigurationManager.AppSettings.Get("db.context");
            gisDbContext = new GisDbContext(dbContext);
            cityService = new CityService(gisDbContext);

        }

        public List<City> GetAllCities()
        {
            return cityService.GetAllCities();
        }

        public List<Prognosis> GetAllPrognoses()
        {
            throw new NotImplementedException();
        }

        public List<Prognosis> GetPrognosesByCity(long cityId)
        {
            throw new NotImplementedException();
        }
    }
}
