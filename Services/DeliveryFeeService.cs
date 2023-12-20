using DependencyInjection.Services.Contracts;
using RestSharp;

namespace DependencyInjection.Services;

public class DeliveryFeeService : IDeliveryFeeService
{
    async Task<decimal> IDeliveryFeeService.GetDeliveryFeeAsync(string zipCode)
    {
        var client = new RestClient(baseUrl: "https://api.myorg.com");
        var request = new RestRequest()
            .AddJsonBody(obj:new 
            {
                ZipCode = zipCode
            });
        
        var response = await client.PostAsync<decimal>(request);
        return response == 0 ? 5 : response;
        
    }
}