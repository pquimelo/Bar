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
      ViewBag.Mesas = mesas;
      foreach (var item in mesas)
      {
        if (item.Status == 1)
        {
          item.TextoStatus = "Disponível";
        }
        else
        {
          item.TextoStatus = "Em uso";
        }
      }
      return View();
      //return RedirectToAction("Index", "Controle", mesas);
    }

    public ActionResult Painel(int id)
    {
      List<Mesa> dados = repository.Read(id);
      ViewBag.Dados = dados;
      foreach (var item in dados)
      {
        ViewBag.NomeCliente = item.NomeCliente;
        ViewBag.Data = item.Data;
      }
      return View();
    }
  }
}