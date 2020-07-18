using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees.Operators
{
    public class Subtraction : Operator
    {
        public override Operator Duplicate()
        {
            Subtraction subtraction = new Subtraction();
            subtraction.LeftChild = LeftChild;
            subtraction.RightChild = RightChild;
            return subtraction;
        }

        public override double GetValue()
        {
            return LeftChild.GetValue() - RightChild.GetValue();
        }
    }
}
