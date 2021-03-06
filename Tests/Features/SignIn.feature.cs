﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("SignInPage", Description="\tIn order to view my basket\r\n\tAs a user\r\n\tI want to log in to my amazon account", SourceFile="Features\\SignIn.feature", SourceLine=0)]
    public partial class SignInPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SignIn.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SignInPage", "\tIn order to view my basket\r\n\tAs a user\r\n\tI want to log in to my amazon account", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
#line 7
#line 8
 testRunner.Given("I navigate to log in page for amazon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        public virtual void SignIn_ValidSubmission(string validEmail, string validPassword, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SignIn - Valid submission", exampleTags);
#line 10
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 11
 testRunner.When(string.Format("I enter {0}  to email input", validEmail), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.And(string.Format("I enter {0} to password input", validPassword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("I click submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.Then("I am redirected to home page as a logged user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("SignIn - Valid submission, testforamazonkk@gmail.com", SourceLine=16)]
        public virtual void SignIn_ValidSubmission_TestforamazonkkGmail_Com()
        {
            this.SignIn_ValidSubmission("testforamazonkk@gmail.com", "zxcvbnm", ((string[])(null)));
#line hidden
        }
        
        public virtual void SignIn_InvalidSubmission(string invalidEmail, string invalidPassword, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SignIn - Invalid submission", exampleTags);
#line 19
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 20
 testRunner.When(string.Format("I enter {0}  to email input", invalidEmail), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.And(string.Format("I enter {0} to password input", invalidPassword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("I click submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.Then("an error message is displayed for email", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("SignIn - Invalid submission, wrong@mail.com", SourceLine=25)]
        public virtual void SignIn_InvalidSubmission_WrongMail_Com()
        {
            this.SignIn_InvalidSubmission("wrong@mail.com", "wrongpassword", ((string[])(null)));
#line hidden
        }
        
        public virtual void SignIn_ValidEmailInvalidPasswordSubmission(string validEmail, string invalidPassword, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SignIn - Valid email, invalid password submission", exampleTags);
#line 28
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 29
 testRunner.When(string.Format("I enter {0}  to email input", validEmail), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.And(string.Format("I enter {0} to password input", invalidPassword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("I click submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.Then("an error message is displayed for password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("SignIn - Valid email, invalid password submission, testforamazonkk@gmail.com", SourceLine=34)]
        public virtual void SignIn_ValidEmailInvalidPasswordSubmission_TestforamazonkkGmail_Com()
        {
            this.SignIn_ValidEmailInvalidPasswordSubmission("testforamazonkk@gmail.com", "wrongpassword", ((string[])(null)));
#line hidden
        }
        
        public virtual void SignIn_InvalidEmailValidPasswordSubmission(string invalidEmail, string validPassword, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SignIn - Invalid email, valid password submission", exampleTags);
#line 37
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 38
 testRunner.When(string.Format("I enter {0}  to email input", invalidEmail), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.And(string.Format("I enter {0} to password input", validPassword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("I click submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.Then("an error message is displayed for email", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("SignIn - Invalid email, valid password submission, wrong@mail.com", SourceLine=43)]
        public virtual void SignIn_InvalidEmailValidPasswordSubmission_WrongMail_Com()
        {
            this.SignIn_InvalidEmailValidPasswordSubmission("wrong@mail.com", "zxcvbnm", ((string[])(null)));
#line hidden
        }
        
        public virtual void SignIn_InvalidEmailPasswordLeftEmpty(string validEmail, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SignIn - Invalid email, password left empty", exampleTags);
#line 46
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 47
 testRunner.When(string.Format("I enter {0}  to email input", validEmail), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.And("I leave password empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("I click submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.Then("an error message is displayed for empty password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("SignIn - Invalid email, password left empty, testforamazonkk@gmail.com", SourceLine=52)]
        public virtual void SignIn_InvalidEmailPasswordLeftEmpty_TestforamazonkkGmail_Com()
        {
            this.SignIn_InvalidEmailPasswordLeftEmpty("testforamazonkk@gmail.com", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("SignIn - Empty inputs submission", SourceLine=54)]
        public virtual void SignIn_EmptyInputsSubmission()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SignIn - Empty inputs submission", ((string[])(null)));
#line 55
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 56
 testRunner.When("I click submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.Then("an error message is displayed for both inputs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
