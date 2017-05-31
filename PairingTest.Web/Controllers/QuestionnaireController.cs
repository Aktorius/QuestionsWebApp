﻿using System.Web.Mvc;
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

        public ViewResult Index()
        {
            return View(new QuestionnaireViewModel());
        }
    }
}
