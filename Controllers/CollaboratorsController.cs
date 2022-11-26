using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StoreManager.Models;

namespace StoreManager.Controllers;

public class CollaboratorsController : Controller
{
    public CollaboratorsController()
    {

    }

    public IActionResult Index()
    {
        return View();
    }
}
