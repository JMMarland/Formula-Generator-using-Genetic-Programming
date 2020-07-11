using FormulaGenerator.Source.ParseTrees;
using FormulaGenerator.Source.ParseTrees.Operators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FormulaGeneratorTests
{
    [TestClass]
    public class ParseTreeTests
    {
        private Operator GenSimpleOpHeadNode(Operator headNode, double leftValue, double rightValue)
        {
            Constant leftConstant = new Constant();
            Constant rightConstant = new Constant();

            leftConstant.SetValue(leftValue);
            rightConstant.SetValue(rightValue);

            headNode.LeftChild = leftConstant;
            headNode.RightChild = rightConstant;

            return headNode;
        }
        
        [TestMethod]
        public void AdditionTest()
        {
            double leftValue = 4;
            double rightValue = 7;

            ParseTree parseTree = new ParseTree();
            parseTree.AddTreeOfNodes(GenSimpleOpHeadNode(new Addition(), leftValue, rightValue));

            double expected = leftValue + rightValue;
            double actual = parseTree.Value;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            double leftValue = 24;
            double rightValue = 13;

            ParseTree parseTree = new ParseTree();
            parseTree.AddTreeOfNodes(GenSimpleOpHeadNode(new Subtraction(), leftValue, rightValue));

            double expected = leftValue - rightValue;
            double actual = parseTree.Value;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VariableTest()
        {
            double originalValue = 64;
            double newValue = 91;

            ParseTree parseTree = new ParseTree();
            Variable headNode = new Variable();

            headNode.SetValue(originalValue);
            headNode.SetValue(newValue);
            parseTree.AddTreeOfNodes(headNode);

            double expected = newValue;
            double actual = parseTree.Value;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConstantTest()
        {
            double originalValue = 68;
            double newValue = 24;

            ParseTree parseTree = new ParseTree();
            Constant headNode = new Constant();

            headNode.SetValue(originalValue);
            headNode.SetValue(newValue);
            parseTree.AddTreeOfNodes(headNode);

            double expected = originalValue;
            double actual = parseTree.Value;

            Assert.AreEqual(expected, actual);
        }
    }
}
