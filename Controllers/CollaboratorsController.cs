using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StoreManager.Models;

namespace StoreManager.Controllers;

public class CollaboratorsController : Controller
{
    private readonly StoreManagerContext _context;
    public CollaboratorsController(StoreManagerContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Collaborators);
    }

    public IActionResult Show(int id)
    {
        Collaborators colaborator = _context.Collaborators.Find(id);

        if(colaborator == null)
        {
            return NotFound();
        }

        return View(colaborator);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Collaborators colaborator)
    {
        if(!ModelState.IsValid) 
        {
            return View(colaborator);
        }

        _context.Collaborators.Add(colaborator);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Collaborators colaborator = _context.Collaborators.Find(id);

        if(colaborator == null)
        {
            return NotFound();
        }

        return View(colaborator);
    }

    [HttpPost]
    public IActionResult Update(Collaborators colaborator, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(colaborator);
        }
        
        Collaborators updatecolaborator = _context.Collaborators.Find(colaborator.Id);
        
        updatecolaborator.Name = colaborator.Name;
        updatecolaborator._Function = colaborator._Function;
        updatecolaborator.Gender = colaborator.Gender;

        _context.Collaborators.Update(updatecolaborator);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Collaborators colaborator = _context.Collaborators.Find(id);

        if(colaborator == null)
        {
            return NotFound();
        }
        
        _context.Collaborators.Remove(_context.Collaborators.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}
