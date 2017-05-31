using System;
using System.Net.Http;
using PairingTest.Web.Interfaces;
using QuestionServiceWebApi.Controllers;

namespace PairingTest.Web.Services
{
    public class QuestionnaireRestService : IQuestionnaireRestService
    {
        private readonly QuestionsController _apiController;

        public QuestionnaireRestService()
        {
            _apiController = new QuestionsController();
        }

        public HttpResponseMessage Get()
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri("http://localhost:50014/")
            };

            var response = client.GetAsync("api/questions").Result;
            
            return response;
        }
    }
}