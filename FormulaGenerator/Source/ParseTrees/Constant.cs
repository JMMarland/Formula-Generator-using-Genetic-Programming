using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees
{
    public class Constant : INode
    {
        public String Type => "CONSTANT";

        public INode LeftChild => null;
        public INode RightChild => null;

        internal double _value = 0;

        private bool _isChanged = false;

        public void SetValue(double value)
        {
            if (_isChanged)
                return;
            
            _value = value;
            _isChanged = true;
        }

        public double GetValue() => _value;
    }
}
