﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.3.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Molder.DatabaseExample
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "SqlServer")]
    public partial class DatabaseExamplesFeature : object, Xunit.IClassFixture<DatabaseExamplesFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "SqlServer"};
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "DatabaseExample.feature"
#line hidden
        
        public DatabaseExamplesFeature(DatabaseExamplesFeature.FixtureData fixtureData, Molder_DatabaseExample_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DatabaseExamples", null, ProgrammingLanguage.CSharp, new string[] {
                        "SqlServer"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
 #line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "DataSource",
                        "InitialCatalog",
                        "UserID",
                        "Password"});
            table1.AddRow(new string[] {
                        "{{SOURCE}}",
                        "{{DATABASE}}",
                        "{{LOGIN}}",
                        "{{PASSWORD}}"});
#line 4
  testRunner.Given("я подключаюсь к БД MS SQL Server с названием \"DataBase\":", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="SELECT *")]
        [Xunit.TraitAttribute("FeatureTitle", "DatabaseExamples")]
        [Xunit.TraitAttribute("Description", "SELECT *")]
        public virtual void SELECT()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SELECT *", null, tagsOfScenario, argumentsOfScenario);
#line 9
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
 this.FeatureBackground();
#line hidden
#line 10
  testRunner.Given("я выполняю \"SELECT\" запрос в БД \"DataBase\" и сохраняю результат в переменную \"res" +
                        "ult\":", "SELECT * FROM Book", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 14
  testRunner.Then("write variable \"result\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="SELECT WHERE")]
        [Xunit.TraitAttribute("FeatureTitle", "DatabaseExamples")]
        [Xunit.TraitAttribute("Description", "SELECT WHERE")]
        public virtual void SELECTWHERE()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SELECT WHERE", null, tagsOfScenario, argumentsOfScenario);
#line 16
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
 this.FeatureBackground();
#line hidden
#line 17
  testRunner.Given("я выполняю \"SELECT\" запрос в БД \"DataBase\" и сохраняю результат в переменную \"res" +
                        "ult\":", "SELECT NAME FROM Book WHERE NAME LIKE \'F%\'", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 21
  testRunner.Then("write variable \"result\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create and Drop Table")]
        [Xunit.TraitAttribute("FeatureTitle", "DatabaseExamples")]
        [Xunit.TraitAttribute("Description", "Create and Drop Table")]
        public virtual void CreateAndDropTable()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create and Drop Table", null, tagsOfScenario, argumentsOfScenario);
#line 25
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
 this.FeatureBackground();
#line hidden
#line 26
 testRunner.Given("я выполняю запрос в БД \"DataBase\" с сохранением количества обработанных записей в" +
                        " переменную \"tmp\":", "CREATE TABLE TEST\r\n(\r\nID INT NOT NULL,\r\nNAME NCHAR(10)\r\n)", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 34
 testRunner.Given("я выполняю \"INSERT\" запрос в БД \"DataBase\" и не сохраняю результат:", "INSERT INTO TEST(ID, NAME) VALUES (0,\'aS12!\')", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 38
 testRunner.Then("я выполняю \"SELECT\" запрос в БД \"DataBase\" и сохраняю результат в переменную \"tes" +
                        "t\":", "SELECT * FROM TEST", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 42
 testRunner.Then("write variable \"test\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
 testRunner.And("я выполняю запрос в БД \"DataBase\" с сохранением количества обработанных записей в" +
                        " переменную \"tmp\":", "DROP TABLE TEST", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create, Insert from Molder.Generator and Drop Table")]
        [Xunit.TraitAttribute("FeatureTitle", "DatabaseExamples")]
        [Xunit.TraitAttribute("Description", "Create, Insert from Molder.Generator and Drop Table")]
        public virtual void CreateInsertFromMolder_GeneratorAndDropTable()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create, Insert from Molder.Generator and Drop Table", null, tagsOfScenario, argumentsOfScenario);
#line 48
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
 this.FeatureBackground();
#line hidden
#line 49
 testRunner.Given("я выполняю запрос в БД \"DataBase\" с сохранением количества обработанных записей в" +
                        " переменную \"tmp\":", "CREATE TABLE TEST\r\n(\r\nID INT NOT NULL,\r\nNAME VARCHAR(20)\r\n)", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 57
 testRunner.Given("я сохраняю случайный набор цифр длиной 2 знаков в переменную \"tmp1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 58
 testRunner.Given("я сохраняю случайный набор букв и цифр длиной 2 знаков в переменную \"tmp2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 59
 testRunner.Given("я выполняю \"INSERT\" запрос в БД \"DataBase\" и не сохраняю результат:", "INSERT INTO TEST(ID, NAME) VALUES ({{tmp1}},{{tmp2}})", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 63
 testRunner.Then("я выполняю \"SELECT\" запрос в БД \"DataBase\" и сохраняю результат в переменную \"tes" +
                        "t\":", "SELECT * FROM TEST", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
 testRunner.Then("write variable \"test\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.And("я выполняю запрос в БД \"DataBase\" с сохранением количества обработанных записей в" +
                        " переменную \"tmp\":", "DROP TABLE TEST", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create, Insert from Table and Drop Table")]
        [Xunit.TraitAttribute("FeatureTitle", "DatabaseExamples")]
        [Xunit.TraitAttribute("Description", "Create, Insert from Table and Drop Table")]
        public virtual void CreateInsertFromTableAndDropTable()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create, Insert from Table and Drop Table", null, tagsOfScenario, argumentsOfScenario);
#line 73
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
 this.FeatureBackground();
#line hidden
#line 74
 testRunner.Given("я выполняю запрос в БД \"DataBase\" с сохранением количества обработанных записей в" +
                        " переменную \"tmp\":", "CREATE TABLE TEST\r\n(\r\nID INT NOT NULL,\r\nNAME NCHAR(10)\r\n)", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "ID",
                            "NAME"});
                table2.AddRow(new string[] {
                            "0",
                            "456asd"});
                table2.AddRow(new string[] {
                            "5",
                            "rest1"});
#line 82
 testRunner.Then("я добавляю записи в таблицу \"TEST\" в БД \"DataBase\":", ((string)(null)), table2, "Then ");
#line hidden
#line 86
 testRunner.Then("я выполняю \"SELECT\" запрос в БД \"DataBase\" и сохраняю результат в переменную \"tes" +
                        "t\":", "SELECT * FROM TEST", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 90
 testRunner.Then("write variable \"test\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 91
 testRunner.And("я выполняю запрос в БД \"DataBase\" с сохранением количества обработанных записей в" +
                        " переменную \"tmp\":", "DROP TABLE TEST", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="DropTable")]
        [Xunit.TraitAttribute("FeatureTitle", "DatabaseExamples")]
        [Xunit.TraitAttribute("Description", "DropTable")]
        public virtual void DropTable()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DropTable", null, tagsOfScenario, argumentsOfScenario);
#line 95
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
 this.FeatureBackground();
#line hidden
#line 96
 testRunner.Given("я выполняю запрос в БД \"DataBase\" с сохранением количества обработанных записей в" +
                        " переменную \"tmp\":", "DROP TABLE TEST", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.3.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                DatabaseExamplesFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                DatabaseExamplesFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
