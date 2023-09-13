//«адание
//—оздайте сервис, который будет выводить текущее врем€ на сервере. ѕодключите его с помощью
//внедрени€ зависимостей в мастер-страницу. –азработайте три страницы с произвольным содержимым,
//две из которых будут наследоватьс€ от этой мастер-страницы, а треть€ не будет иметь мастер-страницы
using AspEssential.Services;
namespace AspEssential
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<ITimeNow, ClassTime>();
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