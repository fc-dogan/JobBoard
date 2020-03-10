using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobOpeningsController : Controller
  {
    [HttpGet("/jobopenings")]
    public ActionResult Index()
    {
      List<JobOpening> allJobOpenings = JobOpening.GetAll();
      return View(allJobOpenings);
    }

      [HttpGet("/jobopenings/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/jobopenings")]
    public ActionResult Create(string title, string description, List<Contact> contactinfo, string name, string email, string phone)
    { 
      Contact newContactInfo = new Contact(name, email, phone);
      
      JobOpening myJobOpening = new JobOpening(title, description, contactinfo);
      return RedirectToAction("Index");
    }
  }
}