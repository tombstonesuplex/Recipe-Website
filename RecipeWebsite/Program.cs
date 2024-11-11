namespace RecipeWebsite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);   
            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();


            var app = builder.Build();
            if (app.Environment.IsDevelopment()) { app.UseSwagger(); app.UseSwaggerUI(); }
            app.UseHttpsRedirection();
            app.MapControllers();
            app.Run();
        }


    }
}
}


