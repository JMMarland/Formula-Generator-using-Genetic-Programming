using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees
{
    internal abstract class Operator : INode
    {
        public INode LeftChild { get; set; }
        public INode RightChild { get; set; }

        public abstract double GetValue();
    }
}
