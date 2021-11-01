using System.Collections.Generic;
using Bar.Models;
using Bar.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bar.Controllers
{
  public class MesaController : Controller
  {
    private IMesaRepository repository;

    public MesaController(IMesaRepository repository)
    {
      this.repository = repository;
    }

    public ActionResult Index()
    {
      List<Mesa> mesas = repository.Read();
      return View(mesas);
      //return RedirectToAction("Index", "Controle", mesas);
    }
  }
}