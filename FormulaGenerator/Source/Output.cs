using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source
{
    public class Output
    {
        internal double Value => _value;
        public double _value;

        public Output(double value)
        {
            SetValue(value);
        }

        public void SetValue(double value)
        {
            _value = value;
        }
    }
}
