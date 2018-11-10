using System.Collections.Generic;
using GisData.db;
using System.Configuration;
using System;
using System.Threading;

namespace GisData
{
    class Program
    {
        static void Main(string[] args)
        {
            GisService gisService = new GisService();
            //gisService.GetLocalData(); //Загружаем данные с локального источника  
            gisService.GetData(); //Загружаем данные с сайта

            string dbContext = ConfigurationManager.AppSettings.Get("db.context");
            GisDbContext gisDbContext = new GisDbContext(dbContext);// подключаемся к БД

            CityService cityService = new CityService(gisDbContext);
            PrognosisService prognosisService = new PrognosisService(gisDbContext);

            do
            {
                // Если передаем аргумент при запуске, то считаем что это периодичность чтения данных, 
                // иначе - проходим один раз и завершаем выполнение
                int period = (args.Length > 0) ? Int32.Parse(args[0]): 0;
                foreach (KeyValuePair<long, string> city in gisService.Cities)
                {
                    if (cityService.FindByName(city.Value) == null)
                    {
                        City cityObj = cityService.CreateCity(city.Key, city.Value);
                        cityService.AddCity(cityObj);
                    }
                    Prognosis prognosis = PrognosisService.ParsePrognosis(city.Key, gisService.GetPrognosisData(city.Key));
                    prognosisService.AddPrognosis(prognosis);
                }

                Thread.Sleep(period * 1000);
            } while (true && args.Length > 0);            
        }
    }
}
