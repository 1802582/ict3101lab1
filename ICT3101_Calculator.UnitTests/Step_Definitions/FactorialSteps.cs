using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using ict3101lab1;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class FactorialSteps
    {
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        public FactorialSteps(Calculator calc)
        {
            this._calculator = calc;
        }
        //--------------------------------
        private double _result;
        [When(@"I have entered ""(.*)"" into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressfactorial(int p0)
        {
            _result = _calculator.Fac(p0);
        }

        [Then(@"the Factorial result should be ""(.*)""")]
        public void ThenTheFactorialResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }


    }
}
