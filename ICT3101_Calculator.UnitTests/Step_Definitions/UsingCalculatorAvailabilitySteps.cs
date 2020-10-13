using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using ict3101lab1;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{   
    [Binding]
    public class UsingCalculatorAvailabilitySteps
    {
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        public UsingCalculatorAvailabilitySteps(Calculator calc)
        {
            this._calculator = calc;
        }
        //--------------------------------
        private double _result;
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            _result = _calculator.Add(p0, p1);
        }
        
        
        [Then(@"the MTBF result should be ""(.*)""")]
        public void ThenTheMTBFResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
    [Binding]
    public class UsingCalculatorAvailabilitySteps2
    {
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        public UsingCalculatorAvailabilitySteps2(Calculator calc)
        {
            this._calculator = calc;
        }
        //--------------------------------
        private double _result;
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1)
        {
            _result = _calculator.Subtract(p0, p1);
        }

        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
