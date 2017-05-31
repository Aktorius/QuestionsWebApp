using System.Web.Mvc;
using NUnit.Framework;
using PairingTest.Web.Controllers;
using PairingTest.Web.Models;

namespace PairingTest.Unit.Tests.Web
{
    [TestFixture]
    public class QuestionnaireControllerTests
    {
        [Test]
        public void ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "Geography Questions";
            var questionnaireController = new QuestionnaireController();

            //Act
            var request = questionnaireController.Index();
                
            //Assert
            Assert.IsNotNull(request);
            var result = request as ViewResult;
            var model = (QuestionnaireViewModel)result.ViewData.Model;
            Assert.That(model.QuestionnaireTitle, Is.EqualTo(expectedTitle));
        }
    }
}