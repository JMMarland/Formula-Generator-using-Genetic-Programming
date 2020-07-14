using FormulaGenerator.Source.ParseTrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormulaGenerator.Source
{
    public class TrainerAndTester
    {
        private List<InputOutputInstance> _inputOutputInstances = new List<InputOutputInstance>();

        private Formula _formula;

        public TrainerAndTester()
        {
        }

        public void AddInputOutputInstance(params double[] inputsOutput)
        {
            double[] inputs = new double[inputsOutput.Length - 1];

            for (int i = 0; i > inputsOutput.Length - 1; i++)
                inputs[i] = inputsOutput[i];

            double output = inputsOutput[inputsOutput.Length - 1];

            AddInputOutputInstance(new Input(inputs), new Output(output));
        }

        public void AddInputOutputInstance(Input input, Output output)
        {
            AddInputOutputInstance(new InputOutputInstance(input, output));
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

        public Formula GetFormula()
        {
            return _formula;
        }

        public void Run(double minAccuracy = 1)
        {
            List<Variable> inputNodes = new List<Variable>();
            int numberOfInputs = _inputOutputInstances[0].Input.ArgumentCount;

            for (int i = 0; i < numberOfInputs; i++)
                inputNodes.Add(new Variable());

            ParseTree parseTree = null;
            bool solutionNotFound = true;

            while(solutionNotFound)
            {
                parseTree = ParseTreeGenerator.NewRandom(inputNodes.ToArray());

                double numOfSuccesses = 0;
                double numOfFailures = 0;

                for (int i = 0; i < _inputOutputInstances.Count; i++)
                {
                    InputOutputInstance inputOutputInstance = _inputOutputInstances[i];

                    for (int j = 0; j < numberOfInputs; j++)
                        inputNodes[j].SetValue(inputOutputInstance.Input.Arguments[j]);

                    if (parseTree.Value == inputOutputInstance.Output.Value)
                        numOfSuccesses++;
                    else
                        numOfFailures++;
                }

                double successPercentage = numOfSuccesses / (numOfSuccesses + numOfFailures);

                if (successPercentage >= minAccuracy)
                    solutionNotFound = false;
            }

            _formula = new Formula(parseTree, inputNodes.ToArray());
        }
    }
}
