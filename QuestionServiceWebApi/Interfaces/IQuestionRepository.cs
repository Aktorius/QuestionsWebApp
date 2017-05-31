using QuestionServiceWebApi.Entities;

namespace QuestionServiceWebApi.Interfaces
{
    public interface IQuestionRepository
    {
        Questionnaire GetQuestionnaire();
    }
}