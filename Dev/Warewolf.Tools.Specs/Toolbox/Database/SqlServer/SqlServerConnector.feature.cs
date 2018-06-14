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
namespace Warewolf.Tools.Specs.Toolbox.Database.SqlServer
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SqlServerConnectorFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "SqlServerConnector.feature"
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
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SqlServerConnector", "    In order to manage my database services\r\n\r\n    As a Warewolf User\r\n\r\n    I wa" +
                    "nt to be shown the database service setup", ProgrammingLanguage.CSharp, new string[] {
                        "Database"});
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "SqlServerConnector")))
            {
                global::Warewolf.Tools.Specs.Toolbox.Database.SqlServer.SqlServerConnectorFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Passing Timeouts to SQL Server")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SqlServerConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Database")]
        public virtual void PassingTimeoutsToSQLServer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Passing Timeouts to SQL Server", ((string[])(null)));
#line 9
this.ScenarioSetup(scenarioInfo);
#line 10
    testRunner.Given("I have a workflow \"Test Sql With Timeouts\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2244 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input Data or[[Variable]]",
                        "Parameter",
                        "Empty is Null"});
#line 11
 testRunner.And("\"Test Sql With Timeouts\" contains \"TestSqlExecutesWithTimeouts\" from server \"loca" +
                    "lhost\" with mapping as", ((string)(null)), table2244, "And ");
#line 13
 testRunner.When("\"Test Sql With Timeouts\" is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
    testRunner.Then("the workflow containing the Sql Server connector has \"An\" execution error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2245 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table2245.AddRow(new string[] {
                        ""});
#line 16
    testRunner.And("The Sql Server step \"TestSqlExecutesWithTimeouts\" in Workflow \"Test Sql With Time" +
                    "outs\" debug outputs appear as", ((string)(null)), table2245, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Opening Saved workflow with SQL Server tool")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SqlServerConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Database")]
        public virtual void OpeningSavedWorkflowWithSQLServerTool()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Opening Saved workflow with SQL Server tool", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
   testRunner.Given("I open workflow with database connector", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
    testRunner.And("Sql Server Source is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
    testRunner.And("Sql Server Source is \"testingDBSrc\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("Sql Server Action is \"dbo.Pr_CitiesGetCountries\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("Sql Server Inputs Are Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2246 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input",
                        "Value",
                        "Empty is Null"});
            table2246.AddRow(new string[] {
                        "Prefix",
                        "[[Prefix]]",
                        "false"});
#line 28
    testRunner.And("Sql Server Inputs appear as", ((string)(null)), table2246, "And ");
#line 31
 testRunner.And("Validate Sql Server is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2247 = new TechTalk.SpecFlow.Table(new string[] {
                        "Mapped From",
                        "Mapped To"});
            table2247.AddRow(new string[] {
                        "CountryID",
                        "[[dbo_Pr_CitiesGetCountries().CountryID]]"});
            table2247.AddRow(new string[] {
                        "Description",
                        "[[dbo_Pr_CitiesGetCountries().Description]]"});
#line 32
    testRunner.Then("Sql Server Outputs appear as", ((string)(null)), table2247, "Then ");
#line 36
 testRunner.And("Sql Server Recordset Name equals \"dbo_Pr_CitiesGetCountries\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Change SQL Server Source on Existing tool")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SqlServerConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Database")]
        public virtual void ChangeSQLServerSourceOnExistingTool()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change SQL Server Source on Existing tool", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 39
    testRunner.Given("I open workflow with database connector", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
    testRunner.And("Sql Server Source is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
    testRunner.And("Sql Server Source is \"testingDBSrc\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("Sql Server Action is \"dbo.Pr_CitiesGetCountries\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("Sql Server Inputs Are Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2248 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input",
                        "Value",
                        "Empty is Null"});
            table2248.AddRow(new string[] {
                        "Prefix",
                        "[[Prefix]]",
                        "false"});
#line 46
    testRunner.And("Sql Server Inputs appear as", ((string)(null)), table2248, "And ");
#line 49
 testRunner.And("Validate Sql Server is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2249 = new TechTalk.SpecFlow.Table(new string[] {
                        "Mapped From",
                        "Mapped To"});
            table2249.AddRow(new string[] {
                        "CountryID",
                        "[[dbo_Pr_CitiesGetCountries().CountryID]]"});
            table2249.AddRow(new string[] {
                        "Description",
                        "[[dbo_Pr_CitiesGetCountries().Description]]"});
#line 50
    testRunner.Then("Sql Server Outputs appear as", ((string)(null)), table2249, "Then ");
#line 54
 testRunner.And("Sql Server Recordset Name equals \"dbo_Pr_CitiesGetCountries\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.When("Source is changed from to \"GreenPoint\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then("Sql Server Action is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
    testRunner.And("Sql Server Inputs Are Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
    testRunner.And("Validate Sql Server is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Changing SQL Server Actions")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SqlServerConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Database")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ChangingSqlServerFunctions")]
        public virtual void ChangingSQLServerActions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Changing SQL Server Actions", new string[] {
                        "ChangingSqlServerFunctions"});
#line 61
this.ScenarioSetup(scenarioInfo);
#line 63
    testRunner.Given("I open workflow with database connector", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
    testRunner.And("Sql Server Source is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
    testRunner.And("Sql Server Source is \"testingDBSrc\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("Sql Server Action is \"dbo.Pr_CitiesGetCountries\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.And("Sql Server Inputs Are Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2250 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input",
                        "Value",
                        "Empty is Null"});
            table2250.AddRow(new string[] {
                        "Prefix",
                        "[[Prefix]]",
                        "false"});
#line 69
    testRunner.And("Sql Server Inputs appear as", ((string)(null)), table2250, "And ");
#line 72
 testRunner.And("Validate Sql Server is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2251 = new TechTalk.SpecFlow.Table(new string[] {
                        "Mapped From",
                        "Mapped To"});
            table2251.AddRow(new string[] {
                        "CountryID",
                        "[[dbo_Pr_CitiesGetCountries().CountryID]]"});
            table2251.AddRow(new string[] {
                        "Description",
                        "[[dbo_Pr_CitiesGetCountries().Description]]"});
#line 73
    testRunner.Then("Sql Server Outputs appear as", ((string)(null)), table2251, "Then ");
#line 77
 testRunner.And("Sql Server Recordset Name equals \"dbo_Pr_CitiesGetCountries\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.When("Action is changed from to \"dbo.ImportOrder\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.And("Sql Server Inputs Are Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2252 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input",
                        "Value",
                        "Empty is Null"});
            table2252.AddRow(new string[] {
                        "ProductId",
                        "[[ProductId]]",
                        "false"});
#line 81
    testRunner.And("Sql Server Inputs appear as", ((string)(null)), table2252, "And ");
#line 84
 testRunner.And("Validate Sql Server is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Change SQL Server Recordset Name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SqlServerConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Database")]
        public virtual void ChangeSQLServerRecordsetName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change SQL Server Recordset Name", ((string[])(null)));
#line 86
this.ScenarioSetup(scenarioInfo);
#line 87
    testRunner.Given("I open workflow with database connector", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 89
    testRunner.And("Sql Server Source is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
    testRunner.And("Sql Server Source is \"testingDBSrc\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.And("Sql Server Action is \"dbo.Pr_CitiesGetCountries\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("Sql Server Inputs Are Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2253 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input",
                        "Value",
                        "Empty is Null"});
            table2253.AddRow(new string[] {
                        "Prefix",
                        "[[Prefix]]",
                        "false"});
#line 94
    testRunner.And("Sql Server Inputs appear as", ((string)(null)), table2253, "And ");
#line 97
 testRunner.And("Validate Sql Server is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2254 = new TechTalk.SpecFlow.Table(new string[] {
                        "Mapped From",
                        "Mapped To"});
            table2254.AddRow(new string[] {
                        "CountryID",
                        "[[dbo_Pr_CitiesGetCountries().CountryID]]"});
            table2254.AddRow(new string[] {
                        "Description",
                        "[[dbo_Pr_CitiesGetCountries().Description]]"});
#line 98
    testRunner.Then("Sql Server Outputs appear as", ((string)(null)), table2254, "Then ");
#line 102
 testRunner.And("Sql Server Recordset Name equals \"dbo_Pr_CitiesGetCountries\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.When("Recordset Name is changed to \"Pr_Cities\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2255 = new TechTalk.SpecFlow.Table(new string[] {
                        "Mapped From",
                        "Mapped To"});
            table2255.AddRow(new string[] {
                        "CountryID",
                        "[[Pr_Cities().CountryID]]"});
            table2255.AddRow(new string[] {
                        "Description",
                        "[[Pr_Cities().Description]]"});
#line 104
 testRunner.Then("Sql Server Outputs appear as", ((string)(null)), table2255, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("No SQL Server Action to be loaded Error")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SqlServerConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Database")]
        public virtual void NoSQLServerActionToBeLoadedError()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No SQL Server Action to be loaded Error", ((string[])(null)));
#line 109
this.ScenarioSetup(scenarioInfo);
#line 111
    testRunner.Given("I have a workflow \"NoStoredProceedureToLoad\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2256 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input Data or[[Variable]]",
                        "Parameter",
                        "Empty is Null"});
#line 112
 testRunner.And("\"NoStoredProceedureToLoad\" contains \"Testing/SQL/NoSqlStoredProceedure\" from serv" +
                    "er \"localhost\" with mapping as", ((string)(null)), table2256, "And ");
#line 114
 testRunner.When("\"NoStoredProceedureToLoad\" is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 115
    testRunner.Then("the workflow containing the Sql Server connector has \"An\" execution error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2257 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table2257.AddRow(new string[] {
                        "Error: The selected database does not contain actions to perform"});
#line 117
    testRunner.And("The Sql Server step \"Testing/SQL/NoSqlStoredProceedure\" in Workflow \"NoStoredProc" +
                    "eedureToLoad\" debug outputs appear as", ((string)(null)), table2257, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Passing Null Input values to SQL Server")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SqlServerConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Database")]
        public virtual void PassingNullInputValuesToSQLServer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Passing Null Input values to SQL Server", ((string[])(null)));
#line 121
this.ScenarioSetup(scenarioInfo);
#line 122
    testRunner.Given("I have a workflow \"PassingNullInputValue\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2258 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input Data or[[Variable]]",
                        "Parameter",
                        "Empty is Null"});
            table2258.AddRow(new string[] {
                        "[[value]]",
                        "a",
                        "True"});
#line 123
 testRunner.And("\"PassingNullInputValue\" contains \"Acceptance Testing Resources/GreenPoint\" from s" +
                    "erver \"localhost\" with mapping as", ((string)(null)), table2258, "And ");
#line 126
 testRunner.When("\"PassingNullInputValue\" is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 127
    testRunner.Then("the workflow containing the Sql Server connector has \"An\" execution error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2259 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table2259.AddRow(new string[] {
                        "Error: Scalar value { value } is NULL"});
#line 129
    testRunner.And("The Sql Server step \"Acceptance Testing Resources/GreenPoint\" in Workflow \"Passin" +
                    "gNullInputValue\" debug outputs appear as", ((string)(null)), table2259, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Mapped To Recordsets incorrect")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SqlServerConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Database")]
        public virtual void MappedToRecordsetsIncorrect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mapped To Recordsets incorrect", ((string[])(null)));
#line 133
this.ScenarioSetup(scenarioInfo);
#line 135
    testRunner.Given("I have a workflow \"BadSqlParameterName\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2260 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input Data or[[Variable]]",
                        "Parameter",
                        "Empty is Null"});
            table2260.AddRow(new string[] {
                        "",
                        "a",
                        "True"});
#line 136
 testRunner.And("\"BadSqlParameterName\" contains \"Acceptance Testing Resources/GreenPoint\" from ser" +
                    "ver \"localhost\" with mapping as", ((string)(null)), table2260, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2261 = new TechTalk.SpecFlow.Table(new string[] {
                        "Mapped From",
                        "Mapped To"});
            table2261.AddRow(new string[] {
                        "id",
                        "[[dbo_leon bob proc().id]]"});
            table2261.AddRow(new string[] {
                        "some column Name",
                        "[[dbo_leon bob proc().some column Name]]"});
#line 139
 testRunner.And("And \"BadSqlParameterName\" contains \"Acceptance Testing Resources/GreenPoint\" from" +
                    " server \"localhost\" with Mapping To as", ((string)(null)), table2261, "And ");
#line 143
 testRunner.When("\"BadSqlParameterName\" is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 144
    testRunner.Then("the workflow containing the Sql Server connector has \"An\" execution error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2262 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table2262.AddRow(new string[] {
                        "Error: Sql Error: parse error"});
#line 146
    testRunner.And("The Sql Server step \"Acceptance Testing Resources/GreenPoint\" in Workflow \"BadSql" +
                    "ParameterName\" debug outputs appear as", ((string)(null)), table2262, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Parameter not found in the collection")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SqlServerConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Database")]
        public virtual void ParameterNotFoundInTheCollection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Parameter not found in the collection", ((string[])(null)));
#line 152
this.ScenarioSetup(scenarioInfo);
#line 154
    testRunner.Given("I have a workflow \"BadMySqlParameterName\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2263 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input Data or[[Variable]]",
                        "Parameter",
                        "Empty is Null"});
            table2263.AddRow(new string[] {
                        "",
                        "`p_startswith`",
                        "false"});
#line 155
 testRunner.And("\"BadMySqlParameterName\" contains \"Testing/MySql/MySqlParameters\" from server \"loc" +
                    "alhost\" with mapping as", ((string)(null)), table2263, "And ");
#line 158
 testRunner.When("\"BadMySqlParameterName\" is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 159
    testRunner.Then("the workflow containing the Sql Server connector has \"An\" execution error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2264 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table2264.AddRow(new string[] {
                        "Parameter \"p_startswith\" not found in the collection"});
#line 161
    testRunner.And("The Sql Server step \"Testing/MySql/MySqlParameters\" in Workflow \"BadMySqlParamete" +
                    "rName\" debug outputs appear as", ((string)(null)), table2264, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Recordset has invalid character")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SqlServerConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Database")]
        public virtual void RecordsetHasInvalidCharacter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recordset has invalid character", ((string[])(null)));
#line 166
this.ScenarioSetup(scenarioInfo);
#line 168
    testRunner.Given("I have a workflow \"MappingHasIncorrectCharacter\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2265 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input Data or[[Variable]]",
                        "Parameter",
                        "Empty is Null"});
            table2265.AddRow(new string[] {
                        "1",
                        "charValue",
                        "True"});
#line 169
 testRunner.And("\"MappingHasIncorrectCharacter\" contains \"Acceptance Testing Resources/GreenPoint\"" +
                    " from server \"localhost\" with mapping as", ((string)(null)), table2265, "And ");
#line 172
 testRunner.When("\"MappingHasIncorrectCharacter\" is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 173
    testRunner.Then("the workflow containing the Sql Server connector has \"An\" execution error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2266 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table2266.AddRow(new string[] {
                        "[[dbo_ConvertTo, Int().result]] : Recordset name has invalid format"});
#line 175
    testRunner.And("The Sql Server step \"Acceptance Testing Resources/GreenPoint\" in Workflow \"Mappin" +
                    "gHasIncorrectCharacter\" debug outputs appear as", ((string)(null)), table2266, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("SqlServer backward Compatiblity")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SqlServerConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Database")]
        public virtual void SqlServerBackwardCompatiblity()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SqlServer backward Compatiblity", ((string[])(null)));
#line 180
this.ScenarioSetup(scenarioInfo);
#line 181
    testRunner.Given("I have a workflow \"DataMigration\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2267 = new TechTalk.SpecFlow.Table(new string[] {
                        "Input to Service",
                        "From Variable",
                        "Output from Service",
                        "To Variable"});
            table2267.AddRow(new string[] {
                        "[[ProductId]]",
                        "productId",
                        "[[dbo_GetCountries().CountryID]]",
                        "dbo_GetCountries().CountryID"});
            table2267.AddRow(new string[] {
                        "",
                        "",
                        "[[dbo_GetCountries().Description]]",
                        "dbo_GetCountries().Description"});
#line 182
 testRunner.And("\"DataMigration\" contains \"DataCon\" from server \"localhost\" with mapping as", ((string)(null)), table2267, "And ");
#line 186
 testRunner.When("\"DataMigration\" is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 187
    testRunner.Then("the workflow \"DataMigration\" execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute Sql Server With Timeout")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SqlServerConnector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Database")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ExecuteSqlServerWithTimeout")]
        public virtual void ExecuteSqlServerWithTimeout()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute Sql Server With Timeout", new string[] {
                        "ExecuteSqlServerWithTimeout"});
#line 190
this.ScenarioSetup(scenarioInfo);
#line 191
    testRunner.Given("I have workflow \"SqlServerWorkflowForTimeout\" with \"SqlServerActivity\" SqlServer " +
                    "database connector", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 192
    testRunner.And("Sql Server Source is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 193
    testRunner.And("I Select \"NewSqlServerSource\" as SqlServer Source for \"SqlServerActivity\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 194
    testRunner.And("I Select \"dbo.Pr_CitiesGetCountries_Delayed\" as Server Action for \"SqlServerActiv" +
                    "ity\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 195
 testRunner.And("Sql Command Timeout is \"60\" milliseconds for \"SqlServerActivity\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 196
 testRunner.And("Validate Sql Server is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 197
    testRunner.And("I click Sql Generate Outputs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 198
    testRunner.And("I click Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 199
    testRunner.And("Sql Command Timeout is \"1\" milliseconds for \"SqlServerActivity\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 200
 testRunner.When("Sql Workflow \"SqlServerWorkflowForTimeout\" containing dbTool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 201
    testRunner.And("the workflow \"SqlServerWorkflowForTimeout\" execution has \"AN\" error \"SQL Error: E" +
                    "xecution Timeout Expired\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
