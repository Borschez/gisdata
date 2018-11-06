using System.Collections.Generic;
using GisData.db;
using System.Configuration;

namespace GisData
{
    class Program
    {
        static void Main(string[] args)
        {
            GisService gisService = new GisService();
            gisService.GetLocalData(); //Загружаем данные   

            string dbContext = ConfigurationManager.AppSettings.Get("db.context");
            GisDbContext gisDbContext = new GisDbContext(dbContext);// подключаемся к БД

            CityService cityService = new CityService(gisDbContext);
            PrognosisService prognosisService = new PrognosisService(gisDbContext);
            
            foreach (KeyValuePair<long, string> city in gisService.Cities)
            {   
                if (cityService.FindByName(city.Value) == null){
                    City cityObj = cityService.CreateCity(city.Key, city.Value);
                    cityService.AddCity(cityObj);                    
                }
                Prognosis prognosis = PrognosisService.ParsePrognosis(city.Key, gisService.GetPrognosisData(city.Key));
                prognosisService.AddPrognosis(prognosis);
            }
        }
    }
}
