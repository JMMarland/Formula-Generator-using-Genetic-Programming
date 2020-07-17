using FormulaGenerator.Source;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FormulaGeneratorTests
{
    [TestClass]
    public class FormulaGenerationTests
    {
        [TestMethod]
        public void SimpleAdditionTest()
        {
            TrainerAndTester trainerAndTester = new TrainerAndTester();
            Random random = new Random();

            int randValueMin = 0;
            int randValueMax = 10;
            
            for (int i = 0; i < 20; i++)
            {
                double value1 = random.Next(randValueMin, randValueMax);
                double value2 = random.Next(randValueMin, randValueMax);
                double result = value1 + value2;

                trainerAndTester.AddInputOutputInstance(value1, value2, result);
            }

            trainerAndTester.Run();

            Formula formula = trainerAndTester.GetFormula();

            double testVal1 = 3;
            double testVal2 = 6;
            double expected = testVal1 + testVal2;
            double actual = formula.Run(testVal1, testVal2);

            Assert.AreEqual(expected, actual);
        }
    }
}
