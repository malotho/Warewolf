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
namespace Warewolf.Tools.Specs.Toolbox.Storage.Dropbox
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class DeleteDropboxFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "DeleteDropbox.feature"
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DeleteDropbox", "\tIn order to delete from an dropbox Server\r\n\tAs a Warewolf User\r\n\tI want to be to" +
                    " delete files on a dropbox account", ProgrammingLanguage.CSharp, new string[] {
                        "Storage"});
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "DeleteDropbox")))
            {
                global::Warewolf.Tools.Specs.Toolbox.Storage.Dropbox.DeleteDropboxFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Open new Delete Dropbox Tool")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeleteDropbox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DoNotParallelize()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("MSTest:DoNotParallelize")]
        public virtual void OpenNewDeleteDropboxTool()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open new Delete Dropbox Tool", new string[] {
                        "MSTest:DoNotParallelize"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.And("I drag Delete Dropbox Tool onto the design surface", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
    testRunner.And("Dropbox Delete New is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("Dropbox Delete Edit is Disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("Delete Dropbox File is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.When("I Click Delete New", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Editing Delete Dropbox Tool")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeleteDropbox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DoNotParallelize()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("MSTest:DoNotParallelize")]
        public virtual void EditingDeleteDropboxTool()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing Delete Dropbox Tool", new string[] {
                        "MSTest:DoNotParallelize"});
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
 testRunner.And("I drag Delete Dropbox Tool onto the design surface", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
    testRunner.And("Dropbox Delete New is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("Dropbox Delete Edit is Disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("Delete Dropbox File is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.When("I Select \"Drop\" as the Delete source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("Dropbox Delete Edit is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.When("I click Dropbox Delete Edit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Change Delete Dropbox Source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeleteDropbox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DoNotParallelize()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("MSTest:DoNotParallelize")]
        public virtual void ChangeDeleteDropboxSource()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change Delete Dropbox Source", new string[] {
                        "MSTest:DoNotParallelize"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.And("I drag Delete Dropbox Tool onto the design surface", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
    testRunner.And("Dropbox Delete New is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("Dropbox Delete Edit is Disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.When("I Select \"Drop\" as the Delete source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then("Dropbox Delete Edit is Enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
 testRunner.And("I set Delete Dropbox File equals \"Home.txt\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.When("I change Delete source from \"Drop\" to \"BackupSource\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.And("Delete Dropbox File equals \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
