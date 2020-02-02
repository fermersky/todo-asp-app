using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoApp.DAL;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly TodoContext db;

        public HomeController()
        {
            this.db = new TodoContext();
        }

        public ActionResult Index() => View();
        public ActionResult Add() => View();
        public ActionResult Edit(int id)
        {
            var todo = db.Todos.FirstOrDefault(t => t.Id == id);

            ViewBag.CategoryList = new SelectList(db.Todos.Select(t => new { Category = t.Category }).Distinct());

            return View(todo);
        }
    }
}
