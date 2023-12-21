using Dapper;
using DependencyInjection.Models;
using DependencyInjection.Repositories.Contracts;
using Microsoft.Data.SqlClient;


namespace DependencyInjection.Repositories;

public class PromoCodeRepository : IPromoCodeRepository
{
    private readonly SqlConnection _connection;

    public PromoCodeRepository(SqlConnection sqlConnection)
    {
        _connection = sqlConnection;
    }
    public async Task<PromoCode?> GetPromoCodeAsync(string promoCode)
    {
        const string query = "SELECT * FROM PROMO_CODES WHERE CODE=@code";
        return await _connection.QueryFirstOrDefaultAsync<PromoCode>(query, new { code = promoCode });
    }
}