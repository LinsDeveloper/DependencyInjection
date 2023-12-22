using DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

var connStr = builder.Configuration.AddConfigConnection();
builder.Services.AddSqlConnection(connStr);
builder.Services.AddServices();
builder.Services.AddResposories();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
