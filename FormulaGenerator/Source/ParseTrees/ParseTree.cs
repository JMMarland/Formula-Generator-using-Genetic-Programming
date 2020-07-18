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

        public ParseTree Duplicate()
        {
            ParseTree newTree = new ParseTree();

            INode currentNode = _head;
            INode newHead = null;
            Stack<INode> prevNodes = new Stack<INode>();

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

                    if (currentNode.Type == "VARIABLE" || currentNode.Type == "CONSTANT")
                    {
                        prevNodes.Push(currentNode);
                        newHead = currentNode;
                    }

                    else if (currentNode.Type == "OPERATOR")
                    {
                        Operator newOperator = ((Operator)currentNode).Duplicate();
                        newOperator.RightChild = prevNodes.Pop();
                        newOperator.LeftChild = prevNodes.Pop();
                        prevNodes.Push(newOperator);
                        newHead = newOperator;
                    }

                    currentNode = nodeStack.Pop();
                }
            }

            Console.WriteLine(prevNodes.Count);

            //if (prevNodes.Count != 1)
            //    throw new Exception();

            newTree.AddTreeOfNodes(newHead);

            return newTree;
        }
    }
}
