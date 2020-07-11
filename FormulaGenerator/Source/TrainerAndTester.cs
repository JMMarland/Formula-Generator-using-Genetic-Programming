using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormulaGenerator.Source
{
    public class TrainerAndTester
    {
        private List<InputOutputInstance> _inputOutputInstances = new List<InputOutputInstance>();

        public TrainerAndTester()
        {
        }

        public void AddInputOutputInstance(Input input, Output output)
        {
            _inputOutputInstances.Add(new InputOutputInstance(input, output));
        }

        public void AddInputOutputInstance(InputOutputInstance inputOutputInstance)
        {
            _inputOutputInstances.Add(inputOutputInstance);
        }

        public void AddInputOutputInstanceArray(InputOutputInstance[] inputOutputInstances)
        {
            List<InputOutputInstance> inputOutputInstanceList = inputOutputInstances.OfType<InputOutputInstance>().ToList();
            _inputOutputInstances.AddRange(inputOutputInstanceList);
        }

        public InputOutputInstance[] GetInputOutputInstances()
        { 
            return _inputOutputInstances.ToArray();
        }
    }
}
