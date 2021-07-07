using Molder.Controllers;
using FluentAssertions;
using System.Diagnostics.CodeAnalysis;
using TechTalk.SpecFlow;
using System;
using MolderConsoleApp;
using Xunit.Abstractions;

namespace Molder.Configuration.Example.Steps
{
    [ExcludeFromCodeCoverage]
    [Binding]
    public class Steps
    {
        private VariableController variables;
        private ITestOutputHelper output;

        private Calculator _calculator = new Calculator();
        private int _result;
        public Steps(VariableController variables, ITestOutputHelper output)
        {
            this.variables = variables;
            this.output = output;
        }

        [StepDefinition(@"write variable ""(.+)""")]
        public void Output(string varName)
        {
            this.variables.Variables.Should().ContainKey(varName, $"переменная \"{varName}\" не существует");
            var value = variables.GetVariableValueText(varName);
            output.WriteLine($"Variable value is {value}");
        }

        [Given(@"я записываю первое значение ""(.+)""")]
        public void FirstNumber(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given(@"я записываю второе значение ""(.+)""")]
        public void SecondNumber(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When(@"оба значения записаны")]
        public void WhenTwoNumbersAdded()
        {
            _result = _calculator.Add();
        }
        [Then(@"результат должен быть ""(.+)""")]
        public void ResultIs(int result)
        {
            _result.Should().Be(result);
        }
    }
}