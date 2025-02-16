// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Lyratesting2Project1.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Update_Basic_Infomation")]
    public partial class Update_Basic_InfomationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Update_Basic_Infomation.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Update_Basic_Infomation", "After I log in my account, I want to update basic information.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update Basic information")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        [NUnit.Framework.TestCaseAttribute("Sam", "440402200706231234", "13800138000", "IT  engineer", "http://www.test.co.nz", "http://test.co.nz", "12345", "基础信息保存成功", null)]
        [NUnit.Framework.TestCaseAttribute("SamSamSamSamSamSamSam", "440402200706231234", "13800138000", "IT  engineer", "http://www.test.co.nz", "http://test.co.nz", "12345", "最多只能输入 18 个字符", null)]
        [NUnit.Framework.TestCaseAttribute("Sam", "1234567890", "13800138000", "IT  engineer", "http://www.test.co.nz", "http://test.co.nz", "12345", "请正确输入您的身份证号码", null)]
        [NUnit.Framework.TestCaseAttribute("Sam", "440402200706231234", "phoneno007", "IT  engineer", "http://www.test.co.nz", "http://test.co.nz", "12345", "请输入正确的手机号", null)]
        [NUnit.Framework.TestCaseAttribute("Sam", "440402200706231234", "13800138000", "IT  engineer IT  engineer", "http://www.test.co.nz", "http://test.co.nz", "12345", "最多只能输入 24 个字符", null)]
        [NUnit.Framework.TestCaseAttribute("Sam", "440402200706231234", "13800138000", "IT  engineer", "ttp://www.test.co.nz", "http://test.co.nz", "12345", "地址不正确，须以http://或者https://开头。", null)]
        [NUnit.Framework.TestCaseAttribute("Sam", "440402200706231234", "13800138000", "IT  engineer", "http://www.test.co.nz", "http//test.co.nz", "12345", "地址不正确，须以http://或者https://开头。", null)]
        [NUnit.Framework.TestCaseAttribute("Sam", "440402200706231234", "13800138000", "IT  engineer", "http://www.test.co.nz", "http://test.co.nz", "12345qq", "请输入正确的QQ号", null)]
        public virtual void UpdateBasicInformation(string realname, string iD, string phoneNo, string title, string personalWebsite, string weiBo, string qQ, string alert_Message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update Basic information", null, @__tags);
#line 5
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
#line 6
 testRunner.Given("I am in the  home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                            "username",
                            "password"});
                table12.AddRow(new string[] {
                            "test001",
                            "Test1234"});
#line 7
 testRunner.And("I can login my  account", ((string)(null)), table12, "And ");
#line hidden
#line 10
 testRunner.When(string.Format("I update \"{0}\" and \"{1}\" and \"{2}\" and \"{3}\" and \"{4}\" and \"{5}\" and \"{6}\"", realname, iD, phoneNo, title, personalWebsite, weiBo, qQ), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then(string.Format("the \"{0}\" alert_message can be seen", alert_Message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
