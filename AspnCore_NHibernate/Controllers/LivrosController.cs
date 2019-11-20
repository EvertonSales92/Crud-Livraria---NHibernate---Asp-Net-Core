using Microsoft.AspNetCore.Mvc;
using NHibernate;
using System.Linq;

namespace AspnCore_NHibernate.Controllers
{
    public class LivrosController : Controller
    {

        private readonly ISession _session;
        public LivrosController(ISession session)
        {
            _session = session;
        }

        public IActionResult Index()
        {
            var list = _session.Query<Models.Livro>().ToList();
            return View(list);
        }
    }
}