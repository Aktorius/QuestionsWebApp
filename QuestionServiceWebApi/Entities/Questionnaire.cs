using System.Collections.Generic;
using System.Runtime.Serialization;

namespace QuestionServiceWebApi.Entities
{
    [DataContract]
    public class Questionnaire
    {
        [DataMember]
        public string QuestionnaireTitle { get; set; }
        [DataMember]
        public IList<string> QuestionsText { get; set; }
    }
}