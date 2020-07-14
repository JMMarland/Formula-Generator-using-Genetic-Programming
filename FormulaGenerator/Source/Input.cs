using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source
{
    public class Input
    {
        private double[] _arguments = null;
        public double[] Arguments => _arguments;

        public int ArgumentCount => _arguments.Length;
        
        public Input(params double[] arguments)
        {
            SetArguments(arguments);
        }

        public void SetArguments(params double[] arguments)
        {
            _arguments = arguments;
        }
    }
}
