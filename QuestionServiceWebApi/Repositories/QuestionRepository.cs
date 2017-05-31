using QuestionServiceWebApi.DataSources;
using QuestionServiceWebApi.Entities;
using QuestionServiceWebApi.Interfaces;

namespace QuestionServiceWebApi.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        
        public Questionnaire GetQuestionnaire()
        {
            return DataSource.Current.Questionnaire;
        }
    }
}