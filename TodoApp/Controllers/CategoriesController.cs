using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoApp.DAL;

namespace TodoApp.Controllers
{
    public class CategoriesController : ApiController
    {
        private TodoContext db = new TodoContext();

        // GET: api/Categories
        public IEnumerable<string> GetCategories()
        {
            return db.Todos.Select(t => t.Category).Distinct();
        }
    }
}
