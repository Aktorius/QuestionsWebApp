using System.Web.Mvc;
using NUnit.Framework;
using PairingTest.Web.Controllers;
using PairingTest.Web.Models;
using PairingTest.Web.Services;

namespace PairingTest.Unit.Tests.Web.Services
{
    [TestFixture]
    class QuestionnaireRestServiceTests
    {
        [Test]
        public void ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "Geography Questions";
            var questionnaireRestService = new QuestionnaireRestService();

            //Act
            var response = questionnaireRestService.Get();

            //Assert
            Assert.IsNotNull(response);
            Assert.That(response.QuestionnaireTitle, Is.EqualTo(expectedTitle));
        }
    }
}
