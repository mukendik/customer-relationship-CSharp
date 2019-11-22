using System;
using System.Collections.Generic;
using System.Text;

namespace customer_relationship.NullableIntroduction.survey
{
    class SurveyRun
    {
        private List<SurveyQuestion> surveyQuestions = new List<SurveyQuestion>();
        public void AddQuestion(QuestionType type, string question) =>
        AddQuestion(new SurveyQuestion(type, question));
        public void AddQuestion(SurveyQuestion surveyQuestion) => surveyQuestions.Add(surveyQuestion);
    }
}
