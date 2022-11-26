using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StoreManager.Models;

namespace StoreManager.Controllers;

public class ProvidersController : Controller
{
    public ProvidersController()
    {

    }

    public IActionResult Index()
    {
        return View();
    }
}
