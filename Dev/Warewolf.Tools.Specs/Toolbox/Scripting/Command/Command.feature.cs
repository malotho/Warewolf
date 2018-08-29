﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Warewolf.Tools.Specs.Toolbox.Scripting.Command
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class CommandFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "Command.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Command", "\tIn order to execute command line scripts\r\n\tAs a Warewolf user\r\n\tI want a tool th" +
                    "at allows me to execute commands ", ProgrammingLanguage.CSharp, new string[] {
                        "Scripting"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Command")))
            {
                global::Warewolf.Tools.Specs.Toolbox.Scripting.Command.CommandFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute commands")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Command")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Scripting")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DoNotParallelize()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("MSTest:DoNotParallelize")]
        public virtual void ExecuteCommands()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute commands", new string[] {
                        "MSTest:DoNotParallelize"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("I have a command variable \"[[drive]]\" equal to \"C:\\\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "script"});
            table1.AddRow(new string[] {
                        "@echo off"});
            table1.AddRow(new string[] {
                        "REM Testing multiple commands"});
            table1.AddRow(new string[] {
                        "dir [[drive]]"});
#line 10
 testRunner.Given("I have these command scripts to execute in a single execution run", ((string)(null)), table1, "Given ");
#line 15
 testRunner.When("the command tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("the result of the command tool will be \"Volume in drive C has no label\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Command"});
            table2.AddRow(new string[] {
                        "String = String"});
#line 18
 testRunner.And("the debug inputs as", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table3.AddRow(new string[] {
                        "[[result]] = String"});
#line 21
 testRunner.And("the debug output as", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a command that requires user interaction like pause")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Command")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Scripting")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DoNotParallelize()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("MSTest:DoNotParallelize")]
        public virtual void ExecuteACommandThatRequiresUserInteractionLikePause()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a command that requires user interaction like pause", new string[] {
                        "MSTest:DoNotParallelize"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("I have this command script to execute \"pause\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.When("the command tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("the result of the command tool will be \"Press any key to continue . . .\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Command"});
            table4.AddRow(new string[] {
                        "pause"});
#line 31
 testRunner.And("the debug inputs as", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table5.AddRow(new string[] {
                        "[[result]] = Press any key to continue . . ."});
#line 34
 testRunner.And("the debug output as", ((string)(null)), table5, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a blank cmd")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Command")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Scripting")]
        public virtual void ExecuteABlankCmd()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a blank cmd", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 39
 testRunner.Given("I have this command script to execute \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
 testRunner.When("the command tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("the result of the command tool will be \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
 testRunner.And("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Command"});
            table6.AddRow(new string[] {
                        "\"\""});
#line 43
 testRunner.And("the debug inputs as", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table7.AddRow(new string[] {
                        "[[result]] ="});
#line 46
 testRunner.And("the debug output as", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute invalid cmd")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Command")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Scripting")]
        public virtual void ExecuteInvalidCmd()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute invalid cmd", ((string[])(null)));
#line 50
this.ScenarioSetup(scenarioInfo);
#line 51
 testRunner.Given("I have this command script to execute \"asdf\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 52
 testRunner.When("the command tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("the result of the command tool will be \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.And("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Command"});
            table8.AddRow(new string[] {
                        "asdf"});
#line 55
 testRunner.And("the debug inputs as", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table9.AddRow(new string[] {
                        "[[result]] ="});
#line 58
 testRunner.And("the debug output as", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute cmd with negative recordset index")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Command")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Scripting")]
        public virtual void ExecuteCmdWithNegativeRecordsetIndex()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute cmd with negative recordset index", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
 testRunner.Given("I have this command script to execute \"dir [[my(-1).dir]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
 testRunner.When("the command tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Command"});
            table10.AddRow(new string[] {
                        "dir [[my(-1).dir]] ="});
#line 66
 testRunner.And("the debug inputs as", ((string)(null)), table10, "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table11.AddRow(new string[] {
                        "[[result]] ="});
#line 69
 testRunner.And("the debug output as", ((string)(null)), table11, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a NULL cmd")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Command")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Scripting")]
        public virtual void ExecuteANULLCmd()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a NULL cmd", ((string[])(null)));
#line 73
this.ScenarioSetup(scenarioInfo);
#line 74
 testRunner.Given("I have a command variable \"[[command]]\" equal to \"NULL\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 75
 testRunner.And("I have this command script to execute \"dir c:\\[[command]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.When("the command tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("the execution has \"No\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a non existent variable cmd")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Command")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Scripting")]
        public virtual void ExecuteANonExistentVariableCmd()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a non existent variable cmd", ((string[])(null)));
#line 80
this.ScenarioSetup(scenarioInfo);
#line 81
 testRunner.Given("I have this command script to execute \"dir c:\\[[command]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 82
 testRunner.When("the command tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.Then("the result of the command tool will be \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.And("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute commands with star notation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Command")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Scripting")]
        public virtual void ExecuteCommandsWithStarNotation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute commands with star notation", ((string[])(null)));
#line 86
this.ScenarioSetup(scenarioInfo);
#line 87
 testRunner.Given("I have a command variable \"[[coms().command]]\" equal to \"bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 88
 testRunner.And("I have a command variable \"[[coms().command]]\" equal to \"dora\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("I have a command variable \"[[coms().command]]\" equal to \"bill\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("I have a command variable \"[[results().res]]\" equal to \"res1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.And("I have a command result equal to \"[[results(*).res]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "script"});
            table12.AddRow(new string[] {
                        "echo [[coms(*).command]]"});
#line 92
 testRunner.And("I have these command scripts to execute in a single execution run", ((string)(null)), table12, "And ");
#line 95
 testRunner.When("the command tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
 testRunner.Then("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Command"});
            table13.AddRow(new string[] {
                        "String = String"});
            table13.AddRow(new string[] {
                        "String = String"});
            table13.AddRow(new string[] {
                        "String = String"});
#line 97
 testRunner.And("the debug inputs as", ((string)(null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table14.AddRow(new string[] {
                        "[[results(1).res]] = bob"});
            table14.AddRow(new string[] {
                        "[[results(2).res]] = dora"});
            table14.AddRow(new string[] {
                        "[[results(3).res]] = bill"});
#line 102
 testRunner.And("the debug output as", ((string)(null)), table14, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute commands with star notation to append")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Command")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Scripting")]
        public virtual void ExecuteCommandsWithStarNotationToAppend()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute commands with star notation to append", ((string[])(null)));
#line 108
this.ScenarioSetup(scenarioInfo);
#line 109
 testRunner.Given("I have a command variable \"[[coms().command]]\" equal to \"bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 110
 testRunner.And("I have a command variable \"[[coms().command]]\" equal to \"dora\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.And("I have a command variable \"[[coms().command]]\" equal to \"bill\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.And("I have a command variable \"[[results().res]]\" equal to \"res1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.And("I have a command result equal to \"[[results().res]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "script"});
            table15.AddRow(new string[] {
                        "echo [[coms(*).command]]"});
#line 114
 testRunner.And("I have these command scripts to execute in a single execution run", ((string)(null)), table15, "And ");
#line 117
 testRunner.When("the command tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
 testRunner.Then("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Command"});
            table16.AddRow(new string[] {
                        "String = String"});
            table16.AddRow(new string[] {
                        "String = String"});
            table16.AddRow(new string[] {
                        "String = String"});
#line 119
 testRunner.And("the debug inputs as", ((string)(null)), table16, "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table17.AddRow(new string[] {
                        "[[results(4).res]] = bill"});
#line 124
 testRunner.And("the debug output as", ((string)(null)), table17, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
