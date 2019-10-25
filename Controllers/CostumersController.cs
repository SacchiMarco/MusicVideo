using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CostumersController : Controller
    {
        
        // GET: Costumers
        public ActionResult Costumers()
        {
            
            return View(this.MyList());
        }

        public ActionResult Costumer( int id)
        {
            var list = this.MyList();

            foreach (Costumers costumer in list)
            {
                if (costumer.Id.Equals(id))
                {
                    return View(costumer);
                }
            }
            
            return View("Error");
        }

        private List<Costumers> MyList()
        {
            var costumersList = new List<Costumers>
            {
                new Costumers() {Name = "Michael Goodman", Id = 1},
                new Costumers() {Name = "Fritz Eschmann", Id = 2},
                new Costumers() {Name = "Lila Pause", Id = 3}
            };
            return costumersList;
        }
    }
}