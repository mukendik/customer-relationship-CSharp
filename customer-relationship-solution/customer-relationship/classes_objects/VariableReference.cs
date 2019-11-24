using System;
using System.Collections.Generic;
using System.Text;

namespace customer_relationship.classes_objects
{
    public class VariableReference : Expression
    {
        string name;
        public VariableReference(string name)
        {
            this.name = name;
        }
        public override double Evaluate(Dictionary<string, object> vars)
        {
            object value = vars[name];
            if (value == null)
            {
                throw new Exception("Unknown variable: " + name);
            }
            return Convert.ToDouble(value);
        }
    }
}
