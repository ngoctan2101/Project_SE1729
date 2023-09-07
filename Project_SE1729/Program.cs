internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        builder.Services.AddSession();
        var app = builder.Build();

        app.MapControllerRoute(
           name: "default",
           pattern: "/{controller=Product}/{action=ListProduct}/{id?}"
           );
        app.UseSession();
        app.Run();
    }
}