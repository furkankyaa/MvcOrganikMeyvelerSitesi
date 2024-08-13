using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOrganikSebzeler.Models.Entity;
namespace MvcOrganikSebzeler.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        MvcOrganikEntities db=new MvcOrganikEntities();
        public ActionResult Index()
        {
            var degerler=db.TBLURUNLER.ToList();
            return View(degerler);
        }
    }
}