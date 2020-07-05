using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees.Operators
{
    internal class Addition : Operator
    {
        public override double GetValue()
        {
            return LeftChild.GetValue() + RightChild.GetValue();
        }
    }
}
