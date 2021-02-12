using System;
using System.Collections.Generic;
using System.Text;
using GameProject2.Abstract;
using GameProject2.Entities;
using MernisServiceReference;

namespace GameProject2.Adapter
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(gamer.NationalityId, gamer.FirstName, gamer.LastName, gamer.YearOfBirth))).Result.Body.TCKimlikNoDogrulaResult;
     
    }
    }
}
