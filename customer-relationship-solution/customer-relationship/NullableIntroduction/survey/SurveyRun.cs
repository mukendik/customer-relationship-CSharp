﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace customer_relationship.NullableIntroduction.survey
{
    class SurveyRun
    {
        public IEnumerable<SurveyResponse> AllParticipants => (respondents ?? Enumerable.Empty<SurveyResponse>());
        public ICollection<SurveyQuestion> Questions => surveyQuestions;
        public SurveyQuestion GetQuestion(int index) => surveyQuestions[index];

        private List<SurveyQuestion> surveyQuestions = new List<SurveyQuestion>();
        public void AddQuestion(QuestionType type, string question) =>
        AddQuestion(new SurveyQuestion(type, question));
        public void AddQuestion(SurveyQuestion surveyQuestion) => surveyQuestions.Add(surveyQuestion);


        private List<SurveyResponse>? respondents;
        public void PerformSurvey(int numberOfRespondents)
        {
            int repondentsConsenting = 0;
            respondents = new List<SurveyResponse>();
            while (repondentsConsenting < numberOfRespondents)
            {
                var respondent = SurveyResponse.GetRandomId();
                if (respondent.AnswerSurvey(surveyQuestions))
                    repondentsConsenting++;
                respondents.Add(respondent);
            }
        }

    }
}
