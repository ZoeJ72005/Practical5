using System.Collections.Generic;
using System.Web.Mvc;
using S1L04.Models;

namespace S1L04.Controllers
{
    public class PeopleController : Controller
    {
        // Static list to store people
        private static List<PersonModel> people = new List<PersonModel>();

        // GET: People
        public ActionResult ListPeople()
        {
            return View(people);
        }

        // GET: Create new person
        public ActionResult Create()
        {
            return View();
        }

        // POST: Add a new person
        [HttpPost]
        public ActionResult AddPerson(PersonModel person)
        {
            if (ModelState.IsValid)
            {
                people.Add(person); // Add the new person to the list
            }
            return RedirectToAction("ListPeople"); // Redirect to refresh the view
        }

        // POST: Delete a person by index
        [HttpPost]
        public ActionResult DeletePerson(int index)
        {
            if (index >= 0 && index < people.Count)
            {
                people.RemoveAt(index); // Remove the person at the specified index
            }
            return RedirectToAction("ListPeople"); // Redirect to refresh the view
        }
    }
}