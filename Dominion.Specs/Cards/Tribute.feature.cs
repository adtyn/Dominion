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
    [NUnit.Framework.DescriptionAttribute("Tribute")]
    public partial class TributeFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Tribute.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Tribute", "", ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Play tribute, revealing a treasure card and an action card")]
        public virtual void PlayTributeRevealingATreasureCardAndAnActionCard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Play tribute, revealing a treasure card and an action card", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("A new game with 3 players");
#line 5
testRunner.And("Player1 has a Tribute in hand instead of a Copper");
#line 6
testRunner.And("Player2 has a deck of Copper, Smithy, Estate, Estate, Copper");
#line 7
testRunner.When("Player1 plays a Tribute");
#line 8
testRunner.Then("Player1 should have 2 remaining actions");
#line 9
testRunner.And("Player1 should have 2 to spend");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Play tribute, revealing a curse card and a victory card")]
        public virtual void PlayTributeRevealingACurseCardAndAVictoryCard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Play tribute, revealing a curse card and a victory card", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
testRunner.Given("A new game with 3 players");
#line 13
testRunner.And("Player1 has a Tribute in hand instead of a Copper");
#line 14
testRunner.And("Player2 has a deck of Curse, Estate, Estate, Estate, Copper");
#line 15
testRunner.When("Player1 plays a Tribute");
#line 16
testRunner.Then("Player1 should have 6 cards in hand");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Play tribute, revealing two of the same card")]
        public virtual void PlayTributeRevealingTwoOfTheSameCard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Play tribute, revealing two of the same card", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
testRunner.Given("A new game with 3 players");
#line 20
testRunner.And("Player1 has a Tribute in hand instead of a Copper");
#line 21
testRunner.And("Player2 has a deck of Copper, Copper, Estate, Estate, Copper");
#line 22
testRunner.When("Player1 plays a Tribute");
#line 23
testRunner.Then("Player1 should have 2 to spend");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Play tribute, revealing two different treasure cards")]
        public virtual void PlayTributeRevealingTwoDifferentTreasureCards()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Play tribute, revealing two different treasure cards", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
testRunner.Given("A new game with 3 players");
#line 27
testRunner.And("Player1 has a Tribute in hand instead of a Copper");
#line 28
testRunner.And("Player2 has a deck of Copper, Silver, Estate, Estate, Copper");
#line 29
testRunner.When("Player1 plays a Tribute");
#line 30
testRunner.Then("Player1 should have 4 to spend");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Play tribute, revealing a copper and a great hall")]
        public virtual void PlayTributeRevealingACopperAndAGreatHall()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Play tribute, revealing a copper and a great hall", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
testRunner.Given("A new game with 3 players");
#line 34
testRunner.And("Player1 has a Tribute in hand instead of a Copper");
#line 35
testRunner.And("Player2 has a deck of Copper, GreatHall, Estate, Estate, Copper");
#line 36
testRunner.When("Player1 plays a Tribute");
#line 37
testRunner.Then("Player1 should have 2 to spend");
#line 38
testRunner.Then("Player1 should have 6 cards in hand");
#line 39
testRunner.Then("Player1 should have 2 remaining actions");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Play tribute, opponent has no deck or discards")]
        public virtual void PlayTributeOpponentHasNoDeckOrDiscards()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Play tribute, opponent has no deck or discards", ((string[])(null)));
#line 41
this.ScenarioSetup(scenarioInfo);
#line 42
testRunner.Given("A new game with 3 players");
#line 43
testRunner.And("Player1 has a Tribute in hand instead of a Copper");
#line 44
testRunner.And("Player2 has an empty deck");
#line 45
testRunner.When("Player1 plays a Tribute");
#line 46
testRunner.Then("All actions should be resolved");
#line 47
testRunner.And("Player1 should have 4 cards in hand");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion