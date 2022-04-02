using Bookworm.WebApi;
using GraphQL.MicrosoftDI;
using GraphQL.Server;
using GraphQL.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// add Book schema
builder.Services.AddSingleton<ISchema, BookSchema>(services => new BookSchema(new SelfActivatingServiceProvider(services)));

// register graphQL
builder.Services.AddGraphQL(options =>
{
    options.EnableMetrics = true;
}).AddSystemTextJson();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseGraphQLAltair();
}

//app.UseGraphQL<BookSchema>();
app.UseGraphQL<ISchema>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
