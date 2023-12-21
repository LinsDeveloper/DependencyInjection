using DependencyInjection.Models;

namespace DependencyInjection.Repositories.Contracts;

public interface IPromoCodeRepository
{
    Task<PromoCode?> GetPromoCodeAsync(string promoCode);
}