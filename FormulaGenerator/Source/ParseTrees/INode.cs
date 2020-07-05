using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees
{
    internal interface INode
    {
        INode LeftChild { get; }
        INode RightChild { get; }

        double GetValue();
    }
}
