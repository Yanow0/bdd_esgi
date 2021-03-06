using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private readonly Calculator _calculator = new Calculator();
        private string _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the operation is (.*)")]
        public void GivenTheOperationIs(string operation)
        {
            _calculator.operation = operation.Split(',');
        }

        [Given("the numbers are (.*)")]
        public void GivenTheNumbersAre(string numbers)
        {
            _calculator.nNumbers = Array.ConvertAll(numbers.Split(','), int.Parse);  
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Multiply();
        }

        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            _result = _calculator.Divide();
        }

        [When("the numbers are added")]
        public void WhenTheNumbersAreAdded()
        {
            _result = _calculator.AddN();
        }

        [When("the numbers are multiplied")]
        public void WhenTheNumbersAreMultiplied()
        {
            _result = _calculator.MultiplyN();
        }

        [When("the numbers are divided")]
        public void WhenTheNumbersAreDivided()
        {
            _result = _calculator.DivideN();
        }

        [When("the operation is calculated")]
        public void WhenTheOperationIsCalculated()
        {
            _result = _calculator.CalculateOperation();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            _result.Should().Be(result);
        }
    }
}
