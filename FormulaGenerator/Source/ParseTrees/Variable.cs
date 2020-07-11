using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees
{
    public class Variable : Constant
    {
        public new String Type => "VARIABLE";

        public new void SetValue(double value)
        {
            _value = value;
        }
    }
}
