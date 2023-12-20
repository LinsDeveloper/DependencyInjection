namespace DependencyInjection.Services.Contracts;

public interface IDeliveryFeeService
{
    public Task<decimal> GetDeliveryFeeAsync(string zipCode);
}