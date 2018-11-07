using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GisData.db
{
    class PrognosisService
    {
        private GisDbContext _gisDbContext = null;

        public PrognosisService(GisDbContext context)
        {
            _gisDbContext = context;
        }

        public static Prognosis ParsePrognosis(long cityId, string data)
        {
            JObject dataObject = JObject.Parse(data);

            JObject temperature = dataObject["temperature"].Value<JObject>();

            Prognosis result = new Prognosis
            {
                Date = DateTime.ParseExact(dataObject["date"].Value<JObject>()["UTC"].Value<string>(), "yyyy-MM-dd HH:mm:ss", null),
                City_Id = cityId,
                Description = dataObject["description"].Value<string>(),
                Air_temp = temperature["air"].Value<JObject>()["avg"].Value<JObject>()["C"].Value<float>(),
                Water_temp = temperature["water"].Value<JObject>()["min"].Value<JObject>()["C"].Value<float>(),
                Comfort_temp = temperature["comfort"].Value<JObject>()["min"].Value<JObject>()["C"].Value<float>(),
                Humidity = dataObject["humidity"].Value<JObject>()["percent"].Value<JObject>()["avg"].Value<float>(),
                Pressure = dataObject["pressure"].Value<JObject>()["mm_hg_atm"].Value<JObject>()["max"].Value<float>()
            };

            return result;
        }

        public Prognosis AddPrognosis(Prognosis prognosis)
        {
            Prognosis result = _gisDbContext.Prognoses.Add(prognosis);
            _gisDbContext.SaveChanges();

            return result;
        }

        public List<Prognosis> GetAllPrognoses()
        {
            return _gisDbContext.Prognoses.ToList();
        }

        public List<Prognosis> GetPrognosesByCity(long cityId)
        {
            return _gisDbContext.Prognoses.Where(x => x.City_Id == cityId).ToList();            
        }
    }
}
