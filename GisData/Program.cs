using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using GisData.db;

namespace GisData
{
    class Program
    {
        static void Main(string[] args)
        {
            GisService gisService = new GisService();
            gisService.getLocalData(); //Загружаем данные   
            
            GisDbContext gisDbContext = new GisDbContext();

            CityService cityService = new CityService(gisDbContext);
            
            foreach (KeyValuePair<long, string> city in gisService.Cities)
            {   
                if (cityService.FindByName(city.Value) == null){
                    City cityObj = cityService.CreateCity(city.Key, city.Value);
                    cityService.AddCity(cityObj);
                }                
            }

            //Debug.Write(gisService.GismeteoData);
        }
    }
}
