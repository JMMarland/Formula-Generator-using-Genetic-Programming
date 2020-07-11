using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees
{
    public abstract class Operator : INode
    {
        public String Type => "OPERATOR";

        public INode LeftChild { get; set; }
        public INode RightChild { get; set; }

        public abstract double GetValue();
    }
}
