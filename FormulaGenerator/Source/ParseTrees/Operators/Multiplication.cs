using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees.Operators
{
    public class Multiplication: Operator
    {
        public override Operator Duplicate()
        {
            Multiplication multiplication = new Multiplication();
            multiplication.LeftChild = LeftChild;
            multiplication.RightChild = RightChild;
            return multiplication;
        }

        public override double GetValue()
        {
            return LeftChild.GetValue() * RightChild.GetValue();
        }
    }
}
