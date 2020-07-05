using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees
{
    internal class ParseTree
    {
        private INode _head;

        private List<INode> _constants = new List<INode>();
        private List<INode> _operators = new List<INode>();
    }
}
