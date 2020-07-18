using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees
{
    /// <summary>
    /// Abstract class <c>Operator</c> implements <c>INode</c> to set the basis
    /// from which operator nodes are built on.
    /// </summary>
    public abstract class Operator : INode
    {
        /// <summary>
        /// Represents the purpose of this <c>INode</c> class, to be an 
        /// OPERATOR.
        /// </summary>
        public String Type => "OPERATOR";

        /// <summary>
        /// The <c>INode</c> object that is the right child to this <c>Operator</c> 
        /// instance.
        /// </summary>
        public INode LeftChild { get; set; }

        /// <summary>
        /// The <c>INode</c> object that is the left child to this <c>Operator</c> 
        /// instance.
        /// </summary>
        public INode RightChild { get; set; }

        /// <summary>
        /// An abstract method which accesses the value that is represented by 
        /// this <c>Operator</c> instance.
        /// </summary>
        /// <returns>A double value that is represented by this <c>Operator</c> instance.</returns>
        public abstract double GetValue();

        /// <summary>
        /// Duplicates the <c>Operator</c> instance and creates a new instance
        /// with the same attributes and members contained.
        /// </summary>
        /// <returns></returns>
        public abstract Operator Duplicate();
    }
}
