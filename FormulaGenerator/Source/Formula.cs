using FormulaGenerator.Source.ParseTrees;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source
{
    public class Formula
    {
        private ParseTree _parseTree;
        private Variable[] _inputNodes;
        
        internal Formula(ParseTree parseTree, Variable[] inputNodes)
        {
            _parseTree = parseTree;
            _inputNodes = inputNodes;
        }

        public double Run(params double[] inputs)
        {
            for (int i = 0; i < _inputNodes.Length; i++)
                _inputNodes[i].SetValue(inputs[i]);

            return _parseTree.Value;
        }
    }
}
