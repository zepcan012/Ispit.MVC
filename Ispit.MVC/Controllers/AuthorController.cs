using Ispit.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Ispit.MVC.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            var authors = new List<Author> {
                new Author{
                    Id = 1,
                    Name = "Tamsyn Muir",
                    Age = 41,
                    Bio = "Autorica The Locked Tomb serijala koji su je proslavili"
                },

                new Author{
                    Id = 2,
                    Name = "Agatha Christie",
                    Age = 85,
                    Bio = "Autorica kriminalističkih romana"
                },

                new Author{
                    Id = 3,
                    Name = "Mark Twain",
                    Age = 74,
                    Bio = "Jedan od najvećih američkih autora 19. stoljeća, proslavio se knjigom Pustolovine Toma Sawyera"
                },

                new Author{
                    Id = 4,
                    Name = "Emily Dickinson",
                    Age = 56,
                    Bio = "Najpoznatija američka pjesnikinja 19. stoljeća, napisala je preko 1800 pjesama tijekom svoga života"
                },

                new Author{
                    Id = 5,
                    Name = "Ransom Riggs",
                    Age = 47,
                    Bio = "Autor koji se proslavio knjigom Dom gospođe Pelegrine za čudnovatu djecu po kojoj je snimljen film"
                }
            };
            return View(authors);
        } 
    }
}
