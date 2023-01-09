using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TestEH.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TestEHControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}