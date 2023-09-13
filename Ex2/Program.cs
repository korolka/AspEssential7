//«адание 2
//ќпределите частичное представление, в котором будет производитс€ визуализаци€ квадрата 4 на 4,
//состо€щего из 16 одинаковых изображений. »зображение дл€ сегмента квадрата должно хранитс€ в
//директории статических файлов. ѕодключите частичное представление в основное
namespace Ex2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=home}/{action=ShowSquare}");
            });

            app.Run();
        }
    }
}