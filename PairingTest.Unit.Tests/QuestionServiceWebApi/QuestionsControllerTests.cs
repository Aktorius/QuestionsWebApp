using System.Web.Http.Results;
using Moq;
using NUnit.Framework;
using PairingTest.Unit.Tests.QuestionServiceWebApi.Stubs;
using QuestionServiceWebApi.Controllers;
using QuestionServiceWebApi.Entities;
using QuestionServiceWebApi.Interfaces;

namespace PairingTest.Unit.Tests.QuestionServiceWebApi
{
    [TestFixture]
    public class QuestionsControllerTests
    {
        private Mock<IQuestionRepository> _questionRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _questionRepositoryMock = new Mock<IQuestionRepository>();
        }

        [Test]
        public void ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "My expected questions";
            var expectedQuestions = new Questionnaire() {QuestionnaireTitle = expectedTitle};

            _questionRepositoryMock.Setup(x => x.GetQuestionnaire()).Returns(expectedQuestions);
            
            var questionsController = new QuestionsController(_questionRepositoryMock.Object);

            //Act
            var actionResult = questionsController.Get();
            var response = actionResult as OkNegotiatedContentResult<Questionnaire>;

            //Assert
            Assert.IsNotNull(response);
            var questions = response.Content;
            Assert.That(questions.QuestionnaireTitle, Is.EqualTo(expectedTitle));
        }
    }
}