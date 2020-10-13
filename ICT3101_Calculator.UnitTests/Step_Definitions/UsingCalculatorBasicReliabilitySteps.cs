using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using ict3101lab1;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        public UsingCalculatorBasicReliabilitySteps(Calculator calc)
        {
            this._calculator = calc;
        }
        //--------------------------------
        private double _result;
        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press CFI")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressCFI(int p0, int p1, int p2)
        {
            _result = _calculator.failInten(p0, p1, p2);
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press AF")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressAF(int p0, int p1, int p2)
        {
            _result = _calculator.expectFail(p0, p1, p2);
        }
        
        [Then(@"the CFI result should be ""(.*)""")]
        public void ThenTheCFIResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the AF result should be ""(.*)""")]
        public void ThenTheAFResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
