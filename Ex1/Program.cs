//Задание 1
//Передайте в представление коллекцию определенных моделей, после чего при помощи foreach
//выведите информацию о каждом из элементов коллекции в виде списка
namespace Ex1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=home}/{action=index}");
            });

            app.Run();
        }
    }
}