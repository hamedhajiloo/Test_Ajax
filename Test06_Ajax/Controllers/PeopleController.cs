using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test06_Ajax.Models;

namespace Test06_Ajax.Controllers
{
    public partial class PeopleController : Controller
    {
        private Person[] personData = {
                new Person {FirstName = "Adam", LastName = "Freeman", Role = Role.Admin},
                new Person {FirstName = "Jacqui", LastName = "Griffyth", Role= Role.User},
                new Person {FirstName = "John", LastName = "Smith", Role = Role.User},
                new Person {FirstName = "Anne", LastName = "Jones", Role = Role.Guest}
        };
        // GET: Pople
        public virtual ActionResult Index()
        {
            return View();
        }
        public virtual ActionResult GetPeople()
        {
            return View();
        }


        //[HttpPost]
        //public ActionResult GetPeople(string selectedRole)
        //{
        //    if (selectedRole == null || selectedRole == "All")
        //    {
        //        return View(personData);
        //    }
        //    else
        //    {
        //        Role selected = (Role)Enum.Parse(typeof(Role),
        //        selectedRole);
        //        return View(personData.Where(p => p.Role == selected));
        //    }
        //}

        public virtual PartialViewResult GetPeopleData(string selectedRole = "All")
        {
            IEnumerable<Person> data = personData;
            if (selectedRole != "All")
            {
                Role selected = (Role)Enum.Parse(typeof(Role),
                selectedRole);
                data = personData.Where(p => p.Role == selected);
            }
            return PartialView(data);
        }
        //public ActionResult GetPeople(string selectedRole = "All")
        //{
        //    return View((object)selectedRole);
        //}

    }
}