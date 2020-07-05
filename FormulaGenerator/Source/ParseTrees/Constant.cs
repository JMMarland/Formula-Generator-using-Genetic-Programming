using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees
{
    internal class Constant : INode
    {
        public INode LeftChild => null;
        public INode RightChild => null;

        private double _value = 0;

        public void SetValue(double value) => _value = value;

        public double GetValue() => _value;
    }
}
