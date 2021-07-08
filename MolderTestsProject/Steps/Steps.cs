using Molder.Controllers;
using FluentAssertions;
using System.Diagnostics.CodeAnalysis;
using TechTalk.SpecFlow;
using System;
using MolderConsoleApp;
using Xunit.Abstractions;
using Molder.Extensions;

namespace Molder.Configuration.Example.Steps
{
    [ExcludeFromCodeCoverage]
    [Binding]
    public class Steps
    {
        private VariableController variableController;
        private ITestOutputHelper output;

        private Calculator _calculator = new Calculator();
        private int _result;
        public Steps(VariableController variables, ITestOutputHelper output)
        {
            this.variableController = variables;
            this.output = output;
        }

        [StepDefinition(@"write variable ""(.+)""")]
        public void Output(string varName)
        {
            this.variableController.Variables.Should().ContainKey(varName, $"переменная \"{varName}\" не существует");
            var value = variableController.GetVariableValueText(varName);
            output.WriteLine($"Variable value is {value}");
        }

        [Given(@"я записываю первое значение ""(.+)""")]
        public void FirstNumber(string number)
        {
            var tmp = variableController.ReplaceVariables(number) ?? number;
        }

        [Given(@"я записываю второе значение ""(.+)""")]
        public void SecondNumber(string number)
        {
            var tmp = variableController.ReplaceVariables(number) ?? number;
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
        [StepDefinition("bla bla (.+)")]
        public void Bla(string varName)
        {
            var tmp = variableController.ReplaceVariables(varName) ?? varName;
            output.WriteLine(tmp);
        }
    }
}