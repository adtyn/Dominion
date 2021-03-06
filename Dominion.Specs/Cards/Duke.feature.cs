// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.3.5.2
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Dominion.Specs.Cards
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.5.2")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Duke")]
    public partial class DukeFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Duke.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Duke", "", ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Duke is worth zero points if there are no duchies in the deck")]
        public virtual void DukeIsWorthZeroPointsIfThereAreNoDuchiesInTheDeck()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Duke is worth zero points if there are no duchies in the deck", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("A new game with 3 players");
#line 5
testRunner.And("Player1 has a hand of Copper, Copper, Copper, Copper, Copper");
#line 6
testRunner.And("Player1 has a deck of Copper, Copper, Copper, Copper, Duke");
#line 7
testRunner.When("The game is scored");
#line 8
testRunner.Then("Player1 should have 0 victory points");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Duke is worth one point if there is one duchy in the deck")]
        public virtual void DukeIsWorthOnePointIfThereIsOneDuchyInTheDeck()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Duke is worth one point if there is one duchy in the deck", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
testRunner.Given("A new game with 3 players");
#line 12
testRunner.And("Player1 has a hand of Copper, Copper, Copper, Copper, Copper");
#line 13
testRunner.And("Player1 has a deck of Copper, Duchy, Copper, Copper, Duke");
#line 14
testRunner.When("The game is scored");
#line 15
testRunner.Then("Player1 should have 4 victory points");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Duke is worth five points if there are five duchies in the deck")]
        public virtual void DukeIsWorthFivePointsIfThereAreFiveDuchiesInTheDeck()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Duke is worth five points if there are five duchies in the deck", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
testRunner.Given("A new game with 3 players");
#line 19
testRunner.And("Player1 has a hand of Duchy, Duchy, Duchy, Duchy, Duchy");
#line 20
testRunner.And("Player1 has a deck of Duke, Copper, Copper, Copper, Copper");
#line 21
testRunner.When("The game is scored");
#line 22
testRunner.Then("Player1 should have 20 victory points");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
