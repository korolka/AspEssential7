using Ex1.Model;
using Microsoft.AspNetCore.Mvc;

namespace Ex1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ModelClass modelClass1 = new ModelClass() {Id = 1, Name = "Vlad", Description= "first" };
            ModelClass modelClass2 = new ModelClass() { Id = 2, Name = "Artur", Description = "second" };
            ModelClass modelClass3 = new ModelClass() { Id = 3, Name = "Sergiy", Description = "third" };
            ModelClass modelClass4 = new ModelClass() { Id = 4, Name = "Andriy", Description = "fourt" };
            List<ModelClass>  listOfModel = new List<ModelClass>() { modelClass1,modelClass2, modelClass3, modelClass4 }; 

            return View(listOfModel);
        }
    }
}
