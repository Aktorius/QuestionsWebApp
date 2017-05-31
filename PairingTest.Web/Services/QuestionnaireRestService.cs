using PairingTest.Web.Interfaces;
using PairingTest.Web.Models;
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

        public QuestionnaireViewModel Get()
        {
            var response = _apiController.Get();

            var content = new QuestionnaireViewModel()
            {
                QuestionnaireTitle = response.QuestionnaireTitle,
                QuestionsText = response.QuestionsText
            };

            return content;
        }
    }
}