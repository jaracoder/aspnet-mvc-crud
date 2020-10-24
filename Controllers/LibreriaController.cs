using Biblioteca.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Biblioteca.Controllers
{
    public class LibreriaController : Controller
    {

        static Libreria libreria = new Libreria();

        //
        // GET: /Biblioteca/
        public ActionResult Index()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var book in libreria.Libros) 
            {
                items.Add(new SelectListItem() { Text = book.Titulo , Value = book.Isbn });
            }
            ViewBag.Tipos = items;



            return View(libreria.Libros.ToList());
        }


        //
        // GET: /Biblioteca/Details/5
        public ActionResult Details(string id)
        {
            foreach (var libro in libreria.Libros) 
            {
                if (libro.Isbn == id) 
                {
                    return View(libro);
                }
            }

            return RedirectToAction("Index");
        }


        public ActionResult Create() 
        {
            return View();
        }


        //
        // POST: /Biblioteca/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                libreria.Libros.Add(
                    new Libro(collection["Isbn"], collection["Titulo"], collection["Autor"], int.Parse(collection["Anyo"]))
                );

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        //
        // GET: /Biblioteca/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }


        //
        // POST: /Biblioteca/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {
                foreach (var libro in libreria.Libros)
                {
                    if (libro.Isbn == id)
                    {
                        libro.Titulo = collection["Titulo"];
                        libro.Autor = collection["Autor"];
                        libro.Anyo = int.Parse(collection["Anyo"]);
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        //
        // GET: /Biblioteca/Delete/5
        public ActionResult Delete(string id)
        {
            for (int i = 0; i < libreria.Libros.Count; i++) 
            {
                if (libreria.Libros[i].Isbn == id)
                {
                    libreria.Libros.RemoveAt(i);
                }
            }

            return View();
        }


        //
        // POST: /Biblioteca/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
