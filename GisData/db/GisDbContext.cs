using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GisData.db
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class GisDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Prognosis> Prognoses { get; set; }

        public GisDbContext() : base("gisDbContext")
        {

        }
    }

    public class City 
    {
        public long Id { get; set; }
        public long Gis_Id { get; set; }
        public string Name { get; set; }
    }

    public class Prognosis
    {
        public long Id { get; set; }
        public long City_Id { get; set; }
        public string Description { get; set; }
        public float Air_temp { get; set; }
        public float Comfort_temp { get; set; }
        public float Water_temp { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }        
    }

}
