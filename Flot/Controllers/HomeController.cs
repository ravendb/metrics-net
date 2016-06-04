using System.Web.Mvc;
using metrics;
using metrics.Util;

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
