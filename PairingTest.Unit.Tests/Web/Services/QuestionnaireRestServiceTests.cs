using NUnit.Framework;
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
            var expectedTitle = "My expected quesitons";
            var questionnaireRestService = new QuestionnaireRestService();

            //Act
            var result = questionnaireRestService.Get();

            //Assert
            Assert.That(result.QuestionnaireTitle, Is.EqualTo(expectedTitle));
        }
    }
}
