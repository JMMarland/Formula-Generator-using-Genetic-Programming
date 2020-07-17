using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees.Operators
{
    public class Multiplication: Operator
    {
        public override double GetValue()
        {
            return LeftChild.GetValue() * RightChild.GetValue();
        }
    }
}
