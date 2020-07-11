using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees
{
    public interface INode
    {
        String Type { get; }

        INode LeftChild { get; }
        INode RightChild { get; }

        double GetValue();
    }
}
