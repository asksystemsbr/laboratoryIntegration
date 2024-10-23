
using ApiIntegracaoLab.Config;
using ApiIntegracaoLab.Mapper;

namespace ApiIntegracao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAutoMapper(typeof(MapperProfile));
            
            builder.Services.Configure<CosmosConfig>(builder.Configuration.GetSection("CosmosConfig"));
            builder.Services.Configure<LabDbConfig>(builder.Configuration.GetSection("LabDBConfig"));

            builder.Services.AddSingleton<CosmosDbService>(options =>
            {
                var cosmosDbSettings = builder.Configuration.GetSection("CosmosConfig");
                string account = cosmosDbSettings["EndpointUri"];
                string key = cosmosDbSettings["PrimaryKey"];
                string databaseId = "LabLog";
                string containerId = "Log";

                return new CosmosDbService(account, key, databaseId, containerId);
            });

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
        }
    }
}
