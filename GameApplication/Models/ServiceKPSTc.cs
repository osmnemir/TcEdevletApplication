namespace GameApplication.Models
{
    public class ServiceKPSTc
    {
        public async Task<bool> OnGetService(Parameters parameters)
        {
            bool result = false;
            var client = new KPSTc.KPSPublicSoapClient(KPSTc.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response = await client.TCKimlikNoDogrulaAsync(parameters.TCKimlikNo, parameters.Ad, parameters.Soyad, parameters.DogumYili);


            return result = response.Body.TCKimlikNoDogrulaResult;
        }




    }

    }
