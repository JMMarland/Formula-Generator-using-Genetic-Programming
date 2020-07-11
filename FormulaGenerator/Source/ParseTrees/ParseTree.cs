using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees
{
    public class ParseTree
    {
        private INode _head;

        private List<Variable> _variables = new List<Variable>();
        private List<Constant> _constants = new List<Constant>();
        private List<Operator> _operators = new List<Operator>();

        public double Value => _head.GetValue();

        public void AddTreeOfNodes(INode head)
        {
            _head = head;
            ParseNodes(_head);
        }

        private void ParseNodes(INode head)
        {
            INode currentNode = head;

            List<INode> visited = new List<INode>();
            Stack<INode> nodeStack = new Stack<INode>();

            while (nodeStack.Count != 0 && HasNotBeenVisited(visited, currentNode))
            {
                if (currentNode.LeftChild != null && HasNotBeenVisited(visited, currentNode.LeftChild))
                {
                    nodeStack.Push(currentNode);
                    currentNode = currentNode.LeftChild;
                }

                else if (currentNode.RightChild != null && HasNotBeenVisited(visited, currentNode.RightChild))
                {
                    nodeStack.Push(currentNode);
                    currentNode = currentNode.RightChild;
                }

                else
                {
                    visited.Add(currentNode);

                    if (currentNode.Type == "VARIABLE")
                        _variables.Add((Variable)currentNode);

                    else if (currentNode.Type == "CONSTANT")
                        _constants.Add((Constant)currentNode);

                    else if (currentNode.Type == "OPERATOR")
                        _operators.Add((Operator)currentNode);

                    currentNode = nodeStack.Pop();
                }
            }
        }

        private bool HasNotBeenVisited(List<INode> visitedList, INode node)
        {
            if (visitedList.Contains(node))
                return false;

            return true;
        }
    }
}
