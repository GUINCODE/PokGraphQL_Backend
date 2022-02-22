using Ge2Co.GraphQL;
using Ge2Co.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var myAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataAppContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddGraphQLServer()
            .AddQueryType<Query>()
            // .AddMutationType<Mutation>()
            // .AddSubscriptionType<Subscription>()
            .AddProjections()
            .AddFiltering()
            .AddSorting()
            .AddInMemorySubscriptions();

// Enable CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins,
        builder =>
        {
            builder.WithOrigins("*")
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseWebSockets();
app.UseHttpsRedirection();
app.UseCors(myAllowSpecificOrigins);

app.UseAuthorization();
app.MapControllers();
app.MapGraphQL(); //permet de donner une route par defaut "/graphql" pour ouvrire l'ide Banana cake pop
app.UseGraphQLVoyager("/voyager");
app.UseGraphQLAltair("/altaire");
app.UseGraphQLGraphiQL("/graphiql");
app.Run();
