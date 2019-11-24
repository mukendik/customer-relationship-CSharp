using System;
using System.Collections.Generic;


namespace customer_relationship.classes_objects
{
    public abstract class Expression
    {
        public abstract double Evaluate(Dictionary<string, object> vars);
    }
}
