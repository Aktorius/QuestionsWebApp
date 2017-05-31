using System.Web.Http;
using QuestionServiceWebApi.Entities;
using QuestionServiceWebApi.Interfaces;
using QuestionServiceWebApi.Repositories;

namespace QuestionServiceWebApi.Controllers
{
    [RoutePrefix("api/questions")]
    public class QuestionsController : ApiController
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionsController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public QuestionsController() : this(new QuestionRepository())
        {
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            var questions = _questionRepository.GetQuestionnaire();

            if (questions == null)
                return NotFound();

            return Ok(questions);
        }

        [HttpGet]
        [Route("{id}")]
        public string Get(int id)
        {
            return "";
        }

        [HttpPost]
        [Route("")]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut]
        [Route("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
        }
    }
}
