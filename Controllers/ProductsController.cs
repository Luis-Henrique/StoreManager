using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StoreManager.Models;

namespace StoreManager.Controllers;

public class ProductsController : Controller
{
    public ProductsController()
    {

    }

    public IActionResult Index()
    {
        return View();
    }
}
