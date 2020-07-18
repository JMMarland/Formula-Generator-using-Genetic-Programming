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

        [TestMethod]
        public void DuplicationTest()
        {
            double value1 = 65;
            double value2 = 34;
            double value3 = 45;

            Constant const1 = new Constant();
            Constant const2 = new Constant();
            Constant const3 = new Constant();

            const1.SetValue(value1);
            const2.SetValue(value2);
            const3.SetValue(value3);

            Operator operator1 = new Addition();
            Operator operator2 = new Division();

            operator1.LeftChild = const1;
            operator1.RightChild = const2;
            operator2.LeftChild = operator1;
            operator2.RightChild = const3;

            ParseTree original = new ParseTree();
            original.AddTreeOfNodes(operator2);
            ParseTree duplicate = original.Duplicate();

            double expected = original.Value;
            double actual = duplicate.Value;

            Assert.AreEqual(expected, actual);
        }
    }
}
