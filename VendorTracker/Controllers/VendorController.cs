using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {

    }
  }
}