using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StoreManager.Models;

namespace StoreManager.Controllers;

public class InventoriesController : Controller
{
    private readonly StoreManagerContext _context;
    public InventoriesController(StoreManagerContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Inventories);
    }

    public IActionResult Show(int id)
    {
        Inventories inventory = _context.Inventories.Find(id);

        if(inventory == null)
        {
            return NotFound();
        }

        return View(inventory);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Inventories inventory)
    {
        if(!ModelState.IsValid) 
        {
            return View(inventory);
        }

        _context.Inventories.Add(inventory);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Inventories inventory = _context.Inventories.Find(id);

        if(inventory == null)
        {
            return NotFound();
        }

        return View(inventory);
    }

    [HttpPost]
    public IActionResult Update(Inventories inventory, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(inventory);
        }
        
        Inventories updateinventory = _context.Inventories.Find(inventory.Id);
        
        updateinventory.Address = inventory.Address;
        updateinventory.Capacity = inventory.Capacity;

        _context.Inventories.Update(updateinventory);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Inventories inventory = _context.Inventories.Find(id);

        if(inventory == null)
        {
            return NotFound();
        }
        
        _context.Inventories.Remove(_context.Inventories.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}
