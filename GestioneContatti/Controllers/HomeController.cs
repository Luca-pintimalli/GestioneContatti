using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GestioneContatti.Models;
using GestioneContatti.Services;

namespace GestioneContatti.Controllers;

public enum ShowType
{
    People = 1,
    Companies=2,
    All=3
}



public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IContactService _contactService; 

    public HomeController(ILogger<HomeController> logger, IContactService contactService)
    {
        _logger = logger;
        _contactService = contactService;
    }

    public async  Task<IActionResult> Index([FromQuery] ShowType type = ShowType.All)
    {
        if(type == ShowType.All)
            return View(await _contactService.GetAll());
        if (type == ShowType.Companies)
            return View(await _contactService.GetCompanies());
        return View(await _contactService.GetPeople());


    }




    public IActionResult AddPerson()
    {
        return View();
    }




    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddPerson(PersonModel model)
    {
        if (ModelState.IsValid)
        {
            await _contactService.AddPerson(model.FirstName, model.LastName);
            return RedirectToAction("Index");
        }

        return View(model);

    }


    public IActionResult AddCompany()
    {
        return View();
    }


    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> AddCompany(CompanyModel model)
    {
        if (ModelState.IsValid)
        {
            await _contactService.AddCompany(model.Name);
            return RedirectToAction("Index");
        }
        return View(model);
    }



    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

