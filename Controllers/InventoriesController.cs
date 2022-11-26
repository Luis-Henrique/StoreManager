using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StoreManager.Models;

namespace StoreManager.Controllers;

public class InventoriesController : Controller
{
    public InventoriesController()
    {

    }

    public IActionResult Index()
    {
        return View();
    }
}
