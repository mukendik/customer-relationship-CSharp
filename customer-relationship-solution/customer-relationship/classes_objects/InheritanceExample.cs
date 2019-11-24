using System;
using System.Collections.Generic;
using System.Text;

namespace customer_relationship.classes_objects
{
    class InheritanceExample
    {
        public static void ExampleUsage()
        {
            Expression e = new Operation(
            new VariableReference("x"),
            '*',
            new Operation(
            new VariableReference("y"),
            '+',
            new Constant(2)
            )
            );
            
        }
    }
}
