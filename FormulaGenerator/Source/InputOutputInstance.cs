using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaGenerator.Source
{
    public class InputOutputInstance
    {
        public Input Input => _input;
        public Output Output => _output;
        
        private Input _input;
        private Output _output;

        public InputOutputInstance(Input input, Output output)
        {
            SetInput(input);
            SetOutput(output);
        }

        public void SetInput(Input input)
        {
            _input = input;
        }

        public void SetOutput(Output output)
        {
            _output = output;
        }
    }
}
