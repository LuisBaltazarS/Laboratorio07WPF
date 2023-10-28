using Bussiness;
using Data;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using System.Xml.Linq;

namespace MyWebApp.Controllers
{
    public class ClientController : Controller
    {
        // GET: ClientController
        public ActionResult Index()
        {

            BClient bussiness = new BClient();

            var clients = bussiness.ListClients();

            var model = clients.Select(x => new ClientModel
            {

                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                Phone = x.Phone,
                Active = x.Active


            });

            return View(model);
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {

            var bussiness = new BClient();
            var clients = bussiness.GetById(id);

            var model = new ClientModel
            {

                Id = clients[0].Id, 
                Name = clients[0].Name,
                Address = clients[0].Address,
                Phone = clients[0].Phone,
                Active = clients[0].Active

            };

            return View(model);
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                BClient bussiness = new BClient();

                bussiness.InsertClient(
                    collection["Name"],
                    collection["Address"],
                    collection["Phone"]
                   );

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {

            BClient bussiness = new BClient();

            var client = bussiness.GetById(id);      

            var model = new ClientModel
            {

                Id = client[0].Id,
                Name = client[0].Name,
                Address = client[0].Address,
                Phone = client[0].Phone,
                Active = client[0].Active


            };

            return View(model);
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                BClient bussiness = new BClient();

                bussiness.UpdateClient(
                    id,
                    collection["Address"],
                    collection["Phone"]
                   );

                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {

            BClient bussiness = new BClient();

            var client = bussiness.GetById(id);

            var model = new ClientModel
            {

                Id = client[0].Id,
                Name = client[0].Name,
                Address = client[0].Address,
                Phone = client[0].Phone,
                Active = client[0].Active


            };

            return View(model);
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {

                var bussiness = new BClient();

                bussiness.DeleteClient(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
