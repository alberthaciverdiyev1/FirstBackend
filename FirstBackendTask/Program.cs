namespace FirstBackendTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllerRoute(
                name: "Default",
                pattern:"{controller=home}/{action=index}" ) ;
            


            app.Run();
        }
    }
}