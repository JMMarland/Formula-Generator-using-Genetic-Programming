using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source.ParseTrees
{
    /// <summary>
    /// Interface <c>INode</c> sets the basis for all nodes of the 
    /// <c>ParseTree</c> class makes use of.
    /// </summary>
    public interface INode
    {
        /// <summary>
        /// The type of node the implementing class is.
        /// </summary>
        String Type { get; }

        /// <summary>
        /// The <c>INode</c> object that is the left child to this <c>INode</c> 
        /// instance.
        /// </summary>
        INode LeftChild { get; }

        /// <summary>
        /// The <c>INode</c> object that is the right child to this <c>INode</c> 
        /// instance.
        /// </summary>
        INode RightChild { get; }

        /// <summary>
        /// Returns the value that is represented by this <c>INode</c> instance.
        /// </summary>
        /// <returns></returns>
        double GetValue();
    }
}
