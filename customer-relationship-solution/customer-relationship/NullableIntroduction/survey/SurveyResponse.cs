using System;
using System.Collections.Generic;
using System.Text;

namespace customer_relationship.NullableIntroduction.survey
{
    class SurveyResponse
    {
        public int Id { get; }
        public SurveyResponse(int id) => Id = id;
    }
}
