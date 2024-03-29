﻿using System;
using System.Collections.Generic;
using System.Text;

namespace customer_relationship.NullableIntroduction.survey
{
 

    public class SurveyQuestion
    {
        public  string QuestionText { get; }

        public QuestionType TypeOfQuestion { get; }

        public SurveyQuestion(QuestionType typeOfQuestion, string text) =>
                (TypeOfQuestion, QuestionText) = (typeOfQuestion, text);

        public string ShowQuestion() => QuestionText;
        
    }
}
