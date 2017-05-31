using System.Net.Http;
using System.Web.Mvc;
using PairingTest.Web.Interfaces;
using PairingTest.Web.Models;
using PairingTest.Web.Services;

namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly IQuestionnaireRestService _questionnaireRestService;

        public QuestionnaireController(IQuestionnaireRestService questionnaireRestService)
        {
            _questionnaireRestService = questionnaireRestService;
        }

        public QuestionnaireController(): this(new QuestionnaireRestService()) { }

          /* ASYNC ACTION METHOD... IF REQUIRED... */
//        public async Task<ViewResult> Index()
//        {
//        }

        public ActionResult Index()
        {
            var response = _questionnaireRestService.Get();

            if (response.IsSuccessStatusCode)
            {
                var model = response.Content.ReadAsAsync<QuestionnaireViewModel>().Result;
                return View(model);
            }

            return HttpNotFound();
        }
    }
}
