using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ABP_Web_MVC.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABP_Web_MVCControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}