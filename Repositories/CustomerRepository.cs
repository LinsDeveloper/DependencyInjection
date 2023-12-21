using Dapper;
using DependencyInjection.Models;
using DependencyInjection.Repositories.Contracts;
using Microsoft.Data.SqlClient;


namespace DependencyInjection.Repositories;

public class CustomerRepository : ICustomerRepository
{
    //Para tornar a variável imultável, é definido readonly, para ser atribuida uma única vez.
    //readonly garante que será tribuida não somente no construtor, mas também uma única vez.
    private readonly SqlConnection _connection;
    public CustomerRepository(SqlConnection sqlConnection)
    {
        _connection = sqlConnection;    
    }
    public async Task<Customer?> GetByIdAsync(string customerId)
    {
        var query = "SELECT [Id], [Name], [Email] FROM CUSTOMER WHERE ID=@id";
        return await _connection.QueryFirstOrDefaultAsync<Customer>(query, new 
            { 
                id = customerId 
            });
    }
}