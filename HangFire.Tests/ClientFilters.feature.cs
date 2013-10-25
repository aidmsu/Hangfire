﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18052
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HangFire.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ClientFiltersFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ClientFilters.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Client filters", "", ProgrammingLanguage.CSharp, new string[] {
                        "redis"});
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
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Client filters")))
            {
                HangFire.Tests.ClientFiltersFeature.FeatureSetup(null);
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
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line 5
    testRunner.Given("a client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Client filters are executed when I create a job")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ClientFiltersAreExecutedWhenICreateAJob()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Client filters are executed when I create a job", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 8
    testRunner.Given("the client filter \'test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Method"});
            table1.AddRow(new string[] {
                        "test::OnCreating"});
            table1.AddRow(new string[] {
                        "test::OnCreated"});
#line 10
     testRunner.Then("the client filter methods were executed in the following order:", ((string)(null)), table1, "Then ");
#line 14
      testRunner.And("the storage contains the job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Multiple client filters are executed depending on their order")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void MultipleClientFiltersAreExecutedDependingOnTheirOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple client filters are executed depending on their order", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 17
    testRunner.Given("the client filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
      testRunner.And("the client filter \'second\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Method"});
            table2.AddRow(new string[] {
                        "first::OnCreating"});
            table2.AddRow(new string[] {
                        "second::OnCreating"});
            table2.AddRow(new string[] {
                        "second::OnCreated"});
            table2.AddRow(new string[] {
                        "first::OnCreated"});
#line 20
     testRunner.Then("the client filter methods were executed in the following order:", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When client filter can cancel the creation of the job")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void WhenClientFilterCanCancelTheCreationOfTheJob()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When client filter can cancel the creation of the job", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 28
    testRunner.Given("the client filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
      testRunner.And("the client filter \'second\' that cancels the job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
      testRunner.And("the client filter \'third\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
     testRunner.Then("the storage does not contain the job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Method"});
            table3.AddRow(new string[] {
                        "first::OnCreating"});
            table3.AddRow(new string[] {
                        "second::OnCreating"});
            table3.AddRow(new string[] {
                        "first::OnCreated (with the canceled flag set)"});
#line 33
      testRunner.And("only the following client filter methods were executed:", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Client filter\'s OnCreated could be skipped if there was an exception")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ClientFilterSOnCreatedCouldBeSkippedIfThereWasAnException()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Client filter\'s OnCreated could be skipped if there was an exception", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 40
    testRunner.Given("the client filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
      testRunner.And("the client filter \'second\' that throws an exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Method"});
            table4.AddRow(new string[] {
                        "first::OnCreating"});
            table4.AddRow(new string[] {
                        "second::OnCreating"});
            table4.AddRow(new string[] {
                        "first::OnCreated"});
#line 43
     testRunner.Then("only the following client filter methods were executed:", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Client filter can handle the exception")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ClientFilterCanHandleTheException()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Client filter can handle the exception", ((string[])(null)));
#line 49
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 50
    testRunner.Given("the client filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
      testRunner.And("the client filter \'second\' that handles an exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
      testRunner.And("the client filter \'third\' that throws an exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Method"});
            table5.AddRow(new string[] {
                        "first::OnCreating"});
            table5.AddRow(new string[] {
                        "second::OnCreating"});
            table5.AddRow(new string[] {
                        "third::OnCreating"});
            table5.AddRow(new string[] {
                        "second::OnCreated"});
            table5.AddRow(new string[] {
                        "first::OnCreated"});
#line 54
     testRunner.Then("the client filter methods were executed in the following order:", ((string)(null)), table5, "Then ");
#line 61
      testRunner.And("no exception were thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Client exception filters are executed when there was an exception while creating " +
            "a job")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ClientExceptionFiltersAreExecutedWhenThereWasAnExceptionWhileCreatingAJob()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Client exception filters are executed when there was an exception while creating " +
                    "a job", ((string[])(null)));
#line 63
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 64
    testRunner.Given("the exception filter \'test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
     testRunner.When("there is a buggy filter (for example)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
      testRunner.And("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
     testRunner.Then("the client exception filter was executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
      testRunner.And("the CreateJobFailedException was thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Multiple exception filters are executed depending on their order")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void MultipleExceptionFiltersAreExecutedDependingOnTheirOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple exception filters are executed depending on their order", ((string[])(null)));
#line 70
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 71
    testRunner.Given("the exception filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 72
      testRunner.And("the exception filter \'second\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
     testRunner.When("there is a buggy filter (for example)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
      testRunner.And("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Filter"});
            table6.AddRow(new string[] {
                        "first"});
            table6.AddRow(new string[] {
                        "second"});
#line 75
     testRunner.Then("the client exception filters were executed in the following order:", ((string)(null)), table6, "Then ");
#line 79
      testRunner.And("the CreateJobFailedException was thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Exception filter can handle the exception")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Client filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ExceptionFilterCanHandleTheException()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Exception filter can handle the exception", ((string[])(null)));
#line 81
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 82
    testRunner.Given("the exception filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 83
      testRunner.And("the exception filter \'second\' that handles an exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
      testRunner.And("the exception filter \'third\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
     testRunner.When("there is a buggy filter (for example)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
      testRunner.And("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Filter"});
            table7.AddRow(new string[] {
                        "first"});
            table7.AddRow(new string[] {
                        "second"});
            table7.AddRow(new string[] {
                        "third"});
#line 87
     testRunner.Then("the following exceptions filter were executed:", ((string)(null)), table7, "Then ");
#line 92
      testRunner.And("no exception were thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
