using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees.Operators
{
    public class Addition : Operator
    {
        public override Operator Duplicate()
        {
            Addition addition = new Addition();
            addition.LeftChild = LeftChild;
            addition.RightChild = RightChild;
            return addition;
        }

        public override double GetValue()
        {
            return LeftChild.GetValue() + RightChild.GetValue();
        }
    }
}
