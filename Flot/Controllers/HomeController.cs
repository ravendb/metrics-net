using System.Web.Mvc;
using Raven.Imports.metrics;
using Raven.Imports.metrics.Util;

namespace Flot.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult GetSample()
        {
            var metrics = new Metrics();
            var content = Serializer.Serialize(metrics.AllSorted);
            return Content(content);
        }
    }
}
