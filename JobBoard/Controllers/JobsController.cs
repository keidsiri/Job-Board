using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobsController : Controller
  {

    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<Job> allJobs = Job.GetAll();
      return View(allJobs);
    }

    [HttpGet("/jobs/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/jobs")]  //POST method sends data to the serve take data from user
    public ActionResult Create(string title, string description, string contact)
    {
      Job myJob = new Job(title, description, contact);
      return RedirectToAction("Index");
    }

    [HttpPost("/jobs/delete")]
    public ActionResult DeleteAll()
    {
      Job.ClearAll();
      return View();
    }

    [HttpGet("/jobs/{id}")]
    public ActionResult Show(int id)
    {
      Job foundItem = Job.Find(id);
      return View(foundItem);
    }

  }
}
