using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees.Operators
{
    public class Division : Operator
    {
        public override Operator Duplicate()
        {
            Division division = new Division();
            division.LeftChild = LeftChild;
            division.RightChild = RightChild;
            return division;
        }

        public override double GetValue()
        {
            return LeftChild.GetValue() / RightChild.GetValue();
        }
    }
}
