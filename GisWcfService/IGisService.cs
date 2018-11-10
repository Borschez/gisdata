using GisData.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GisWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGisService
    {
        [OperationContract]
        List<City> GetAllCities();

        [OperationContract]
        List<Prognosis> GetAllPrognoses();

        [OperationContract]
        List<Prognosis> GetPrognosesByCity(long cityId);

        [OperationContract]
        Prognosis GetLatestPrognosisByCity(long cityId);
        // TODO: Add your service operations here
    }
    
}
