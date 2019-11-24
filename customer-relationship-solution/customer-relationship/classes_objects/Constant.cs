using System;
using System.Collections.Generic;
using System.Text;

namespace customer_relationship.classes_objects
{
    class Constant : Expression
    {
        double value;
        public Constant(double value)
        {
            this.value = value;
        }
        public override double Evaluate(Dictionary<string, object> vars)
        {
            return value;
        }
    }
}
