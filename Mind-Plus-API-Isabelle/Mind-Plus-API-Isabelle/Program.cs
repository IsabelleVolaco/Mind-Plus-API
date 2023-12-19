using Mind_Plus_API_Isabelle.Contracts;
using Mind_Plus_API_Isabelle.Repository;

namespace Mind_Plus_API_Isabelle
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

            builder.Services.AddTransient<IEmployeesRepository, EmployeesRepository>();
            builder.Services.AddTransient<ILoginRepository, LoginRepository>();
            builder.Services.AddTransient<IFormsRepository, FormsRepository>();

            builder.Services.AddSwaggerGen();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAuthentication()
  /*
                .AddBasic(BasicScheme, _ => { })
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                { ...}
  */
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