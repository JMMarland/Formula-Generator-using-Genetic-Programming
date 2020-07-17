using FormulaGenerator.Source.ParseTrees.Operators;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees
{
    internal class ParseTreeGenerator
    {
        private static Random _random = new Random();
        
        private static Operator RandomOperator()
        {
            Operator[] operators =
                {
                new Addition(),
                new Subtraction(),
                new Multiplication(),
                new Division()
            };

            return operators[_random.Next(operators.Length)];
        }

        private static Constant RandomIntConstant(int maximum)
        {
            return RandomIntConstant(0, maximum);
        }

        private static Constant RandomIntConstant(int minimum, int maximum)
        {
            Constant constant = new Constant();
            constant.SetValue(_random.Next(minimum, maximum));
            return constant;
        }

        private static List<Variable> ShuffleArrayToList(Variable[] array)
        {
            List<Variable> list = new List<Variable>();

            while (array.Length > list.Count)
            {
                Variable variable = array[_random.Next(array.Length)];

                if (list.Contains(variable))
                    continue;

                list.Add(variable);
            }

            return list;
        }
        
        public static ParseTree NewRandom(Variable[] inputs)
        {
            ParseTree parseTree = new ParseTree();
            List<Variable> inputList = ShuffleArrayToList(inputs);

            Operator headNode = null;
            Operator prevNode = null;
            bool isNotFinished = true;

            for (int i = 0; isNotFinished; i++)
            {
                if (headNode == null)
                {
                    headNode = RandomOperator();

                    if (prevNode != null)
                    {
                        if (_random.Next(2) == 0)
                            headNode.LeftChild = prevNode;
                        else
                            headNode.RightChild = prevNode;
                    }
                }

                if (headNode.LeftChild == null && headNode.RightChild != null)
                {
                    headNode.LeftChild = inputList[i];
                }

                else if (headNode.LeftChild != null && headNode.RightChild == null)
                {
                    headNode.RightChild = inputList[i];
                }

                else if (headNode.LeftChild == null && headNode.RightChild == null)
                {
                    if (_random.Next(2) == 0)
                        headNode.LeftChild = inputList[i];
                    else
                        headNode.RightChild = inputList[i];
                    continue;
                }

                if (inputList.Count - i <= 1)
                    isNotFinished = false;
                else
                {
                    prevNode = headNode;
                    headNode = null;
                }
            }

            parseTree.AddTreeOfNodes(headNode);

            return parseTree;
        }
    }
}
