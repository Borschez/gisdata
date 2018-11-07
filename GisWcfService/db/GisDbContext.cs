using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GisData.db
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class GisDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Prognosis> Prognoses { get; set; }

        public GisDbContext(string context) : base(context)
        {

        }
    }
    [DataContract]
    public class City 
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long Gis_Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class Prognosis
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long City_Id { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public float Air_temp { get; set; }
        [DataMember]
        public float Comfort_temp { get; set; }
        [DataMember]
        public float Water_temp { get; set; }
        [DataMember]
        public float Humidity { get; set; }
        [DataMember]
        public float Pressure { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
    }

}
