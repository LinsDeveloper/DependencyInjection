using DependencyInjection.Models;

namespace DependencyInjection.Repositories.Contracts;

public interface ICustomerRepository
{
    Task<Customer?> GetByIdAsync(string customerId);
}