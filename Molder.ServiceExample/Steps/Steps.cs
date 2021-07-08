using Molder.Controllers;
using System.Diagnostics.CodeAnalysis;
using TechTalk.SpecFlow;
using System;
using Xunit.Abstractions;
using FluentAssertions;

namespace DatabaseExample.Steps
{
    [ExcludeFromCodeCoverage]
    [Binding]
    public class Steps
    {
        private VariableController variables;
        private ITestOutputHelper output;

        public Steps(VariableController variables, ITestOutputHelper output)
        {
            this.variables = variables;
            this.output = output;
        }

        [StepDefinition(@"write variable ""(.+)""")]
        public void Output(string varName)
        {
            var value = variables.GetVariableValueText(varName);
            output.WriteLine($"Variable value is {value}");
        }
    }
}