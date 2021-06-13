using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RecipeBox.Models;
using System.Linq;


namespace RecipeBox.Controllers
{
    public class HomeController : Controller
    {
      private readonly RecipeBoxContext _db;
      public HomeController(RecipeBoxContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Recipe> recipes = _db.Recipes.ToList();

        return View(recipes);
      }

    }
}