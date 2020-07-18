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

        [TestMethod]
        public void ModerateAdditionTest()
        {
            TrainerAndTester trainerAndTester = new TrainerAndTester();
            Random random = new Random();

            int randValueMin = 0;
            int randValueMax = 30;

            for (int i = 0; i < 20; i++)
            {
                double value1 = random.Next(randValueMin, randValueMax);
                double value2 = random.Next(randValueMin, randValueMax);
                double value3 = random.Next(randValueMin, randValueMax);
                double result = value1 + value2 + value3;

                trainerAndTester.AddInputOutputInstance(value1, value2, value3, result);
            }

            trainerAndTester.Run();

            Formula formula = trainerAndTester.GetFormula();

            double testVal1 = 45;
            double testVal2 = 36;
            double testVal3 = 67;
            double expected = testVal1 + testVal2 + testVal3;
            double actual = formula.Run(testVal1, testVal2, testVal3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SimpleSubtractionTest()
        {
            TrainerAndTester trainerAndTester = new TrainerAndTester();
            Random random = new Random();

            int randValueMin = 0;
            int randValueMax = 10;

            for (int i = 0; i < 20; i++)
            {
                double value1 = random.Next(randValueMin, randValueMax);
                double value2 = random.Next(randValueMin, randValueMax);
                double result = value1 - value2;

                trainerAndTester.AddInputOutputInstance(value1, value2, result);
            }

            trainerAndTester.Run();

            Formula formula = trainerAndTester.GetFormula();

            double testVal1 = 8;
            double testVal2 = 2;
            double expected = testVal1 - testVal2;
            double actual = formula.Run(testVal1, testVal2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ModerateSubtractionTest()
        {
            TrainerAndTester trainerAndTester = new TrainerAndTester();
            Random random = new Random();

            int randValueMin = 0;
            int randValueMax = 30;

            for (int i = 0; i < 20; i++)
            {
                double value1 = random.Next(randValueMin, randValueMax);
                double value2 = random.Next(randValueMin, randValueMax);
                double value3 = random.Next(randValueMin, randValueMax);
                double result = value1 - value2 - value3;

                trainerAndTester.AddInputOutputInstance(value1, value2, value3, result);
            }

            trainerAndTester.Run();

            Formula formula = trainerAndTester.GetFormula();

            double testVal1 = 75;
            double testVal2 = 32;
            double testVal3 = 12;
            double expected = testVal1 - testVal2 - testVal3;
            double actual = formula.Run(testVal1, testVal2, testVal3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SimpleMultiplicationTest()
        {
            TrainerAndTester trainerAndTester = new TrainerAndTester();
            Random random = new Random();

            int randValueMin = 0;
            int randValueMax = 10;

            for (int i = 0; i < 20; i++)
            {
                double value1 = random.Next(randValueMin, randValueMax);
                double value2 = random.Next(randValueMin, randValueMax);
                double result = value1 * value2;

                trainerAndTester.AddInputOutputInstance(value1, value2, result);
            }

            trainerAndTester.Run();

            Formula formula = trainerAndTester.GetFormula();

            double testVal1 = 10;
            double testVal2 = 25;
            double expected = testVal1 * testVal2;
            double actual = formula.Run(testVal1, testVal2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ModerateMultiplicationTest()
        {
            TrainerAndTester trainerAndTester = new TrainerAndTester();
            Random random = new Random();

            int randValueMin = 0;
            int randValueMax = 30;

            for (int i = 0; i < 20; i++)
            {
                double value1 = random.Next(randValueMin, randValueMax);
                double value2 = random.Next(randValueMin, randValueMax);
                double value3 = random.Next(randValueMin, randValueMax);
                double result = value1 * value2 * value3;

                trainerAndTester.AddInputOutputInstance(value1, value2, value3, result);
            }

            trainerAndTester.Run();

            Formula formula = trainerAndTester.GetFormula();

            double testVal1 = 67;
            double testVal2 = 48;
            double testVal3 = 26;
            double expected = testVal1 * testVal2 * testVal3;
            double actual = formula.Run(testVal1, testVal2, testVal3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SimpleDivisionTest()
        {
            TrainerAndTester trainerAndTester = new TrainerAndTester();
            Random random = new Random();

            int randValueMin = 0;
            int randValueMax = 10;

            for (int i = 0; i < 20; i++)
            {
                double value1 = random.Next(randValueMin, randValueMax);
                double value2 = random.Next(randValueMin, randValueMax);
                double result = value1 / value2;

                trainerAndTester.AddInputOutputInstance(value1, value2, result);
            }

            trainerAndTester.Run();

            Formula formula = trainerAndTester.GetFormula();

            double testVal1 = 25;
            double testVal2 = 5;
            double expected = testVal1 / testVal2;
            double actual = formula.Run(testVal1, testVal2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ModerateDivisionTest()
        {
            TrainerAndTester trainerAndTester = new TrainerAndTester();
            Random random = new Random();

            int randValueMin = 0;
            int randValueMax = 30;

            for (int i = 0; i < 20; i++)
            {
                double value1 = random.Next(randValueMin, randValueMax);
                double value2 = random.Next(randValueMin, randValueMax);
                double value3 = random.Next(randValueMin, randValueMax);
                double result = value1 / value2 / value3;

                trainerAndTester.AddInputOutputInstance(value1, value2, value3, result);
            }

            trainerAndTester.Run();

            Formula formula = trainerAndTester.GetFormula();

            double testVal1 = 89;
            double testVal2 = 32;
            double testVal3 = 5;
            double expected = testVal1 / testVal2 / testVal3;
            double actual = formula.Run(testVal1, testVal2, testVal3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SimpleOperationMixTest()
        {
            TrainerAndTester trainerAndTester = new TrainerAndTester();
            Random random = new Random();

            int randValueMin = 0;
            int randValueMax = 30;

            for (int i = 0; i < 20; i++)
            {
                double value1 = random.Next(randValueMin, randValueMax);
                double value2 = random.Next(randValueMin, randValueMax);
                double value3 = random.Next(randValueMin, randValueMax);
                double value4 = random.Next(randValueMin, randValueMax);
                double result = value1 + value2 * value3 / value4;

                trainerAndTester.AddInputOutputInstance(value1, value2, value3, value4, result);
            }

            trainerAndTester.Run();

            Formula formula = trainerAndTester.GetFormula();

            double testVal1 = 29;
            double testVal2 = 98;
            double testVal3 = 67;
            double testVal4 = 63;
            double expected = testVal1 + testVal2 * testVal3 / testVal4;
            double actual = formula.Run(testVal1, testVal2, testVal3, testVal4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConstantOperationMixTest()
        {
            TrainerAndTester trainerAndTester = new TrainerAndTester();
            Random random = new Random();

            int randValueMin = 0;
            int randValueMax = 30;

            double constant = random.Next(randValueMin, randValueMax);

            for (int i = 0; i < 20; i++)
            {
                double value1 = random.Next(randValueMin, randValueMax);
                double value2 = random.Next(randValueMin, randValueMax);
                double value3 = random.Next(randValueMin, randValueMax);
                double result = (value1 / value2 * value3) + constant;

                trainerAndTester.AddInputOutputInstance(value1, value2, value3, result);
            }

            trainerAndTester.Run();

            Formula formula = trainerAndTester.GetFormula();

            double testVal1 = 29;
            double testVal2 = 98;
            double testVal3 = 67;
            double expected = (testVal1 / testVal2 * testVal3) + constant;
            double actual = formula.Run(testVal1, testVal2, testVal3);

            Assert.AreEqual(expected, actual);
        }
    }
}
