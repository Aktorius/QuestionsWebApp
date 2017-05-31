using System.Collections.Generic;
using QuestionServiceWebApi.Entities;

namespace QuestionServiceWebApi.DataSources
{
    public class DataSource
    {
        private static DataSource _instance;

        public static DataSource Current
        {
            get
            {
                if (_instance == null)
                    _instance = new DataSource();

                return _instance;
            }
        }

        public Questionnaire Questionnaire { get; set; }

        private DataSource()
        {
            Questionnaire = new Questionnaire
            {
                QuestionnaireTitle = "Geography Questions",
                QuestionsText = new List<string>
                {
                    "What is the capital of Cuba?",
                    "What is the capital of France?",
                    "What is the capital of Poland?",
                    "What is the capital of Germany?"
                }
            };
        }
    }
}