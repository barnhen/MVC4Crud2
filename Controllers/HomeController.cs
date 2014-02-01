using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC4Crud2.Models;

namespace MVC4Crud2.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext db = new ContactContext(); //barnhen
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View(db.Contacts.ToList());
            //return View();
        }

        //barnhen begin
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Buscar()
        {
            try
            {

                return Json(db.Contacts.ToList());
            }
            catch
            {
                return View();
            }
        }
        //barnhen end

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //barnhen begin


        /*
        public ActionResult GridDemoData(int page, int rows,string search, string sidx, string sord)
        {
            var manageContacts = new Contact();
            int currentPage = Convert.ToInt32(page) - 1;
            int totalRecords = 0;

            var data = manageContacts.GetContactPaged
        (currentPage, rows, out totalRecords);

            var totalPages = (int)Math.Ceiling(totalRecords / (float)rows);
            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,

                rows = (
                           from m in data
                           select new
                           {
                               id = m.ContactID,
                               cell = new object[]
                                      {
                                           m.Title,
                                           m.FirstName,
                                           m.LastName
                                      }
                           }).ToArray()
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
        public ActionResult PerformCRUDAction(Contact contact)
        {
            var manageContacts = new ManageContacts();

            bool result = false;
            switch (Request.Form["oper"])
            {
                case "add":
                    contact.AddDate = DateTime.Now.Date;
                    contact.ModifiedDate = DateTime.Now;
                    result = manageContacts.AddContact(contact);
                    break;
                case "edit":
                    int id = Int32.Parse(Request.Form["id"]);
                    result = manageContacts.UpdateContact(contact, id);
                    break;
                case "del":
                    id = Int32.Parse(Request.Form["id"]);
                    result = manageContacts.DeleteContact(id);
                    break;
                default:
                    break;
            }
            return Json(result);
        }
         */
        //barnhen end
    }
         
}
