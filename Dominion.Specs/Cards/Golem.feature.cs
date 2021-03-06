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
    [NUnit.Framework.DescriptionAttribute("Golem")]
    public partial class GolemFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Golem.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Golem", "", ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Play Golem but reveal no actions")]
        public virtual void PlayGolemButRevealNoActions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Play Golem but reveal no actions", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("A new game with 3 players");
#line 5
testRunner.And("Player1 has a Golem in hand instead of a Copper");
#line 6
testRunner.When("Player1 plays a Golem");
#line 7
testRunner.Then("All actions should be resolved");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Play Golem but reveal only one action")]
        public virtual void PlayGolemButRevealOnlyOneAction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Play Golem but reveal only one action", ((string[])(null)));
#line 9
this.ScenarioSetup(scenarioInfo);
#line 10
testRunner.Given("A new game with 3 players");
#line 11
testRunner.And("Player1 has a Golem in hand instead of a Copper");
#line 12
testRunner.And("Player1 has a deck of Woodcutter, Estate, Copper, Copper, Copper");
#line 13
testRunner.When("Player1 plays a Golem");
#line 14
testRunner.Then("All actions should be resolved");
#line 15
testRunner.And("Player1 should have 2 to spend");
#line 16
testRunner.And("Player1 should have in play: Golem, Woodcutter");
#line 17
testRunner.And("Player1 should have a discard pile of Estate, Copper, Copper, Copper");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Play Golem and reveal two of the same action")]
        public virtual void PlayGolemAndRevealTwoOfTheSameAction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Play Golem and reveal two of the same action", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
testRunner.Given("A new game with 3 players");
#line 21
testRunner.And("Player1 has a Golem in hand instead of a Copper");
#line 22
testRunner.And("Player1 has a deck of Village, Estate, Copper, Village, Copper, Copper");
#line 23
testRunner.When("Player1 plays a Golem");
#line 24
testRunner.Then("Player1 should have 4 remaining actions");
#line 25
testRunner.Then("Player1 should have 6 cards in hand");
#line 26
testRunner.And("Player1 should have in play: Golem, Village, Village");
#line 27
testRunner.Then("Player1 should have a discard pile of Estate, Copper");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player reveals Golem when resolving Golem and the revealed Golem is ignored")]
        public virtual void PlayerRevealsGolemWhenResolvingGolemAndTheRevealedGolemIsIgnored()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player reveals Golem when resolving Golem and the revealed Golem is ignored", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
testRunner.Given("A new game with 3 players");
#line 31
testRunner.And("Player1 has a Golem in hand instead of a Copper");
#line 32
testRunner.And("Player1 has a deck of Village, Golem, Village, Copper, Copper");
#line 33
testRunner.When("Player1 plays a Golem");
#line 34
testRunner.Then("Player1 should have 4 remaining actions");
#line 35
testRunner.Then("Player1 should have 6 cards in hand");
#line 36
testRunner.Then("Player1 should have a Golem on top of the discard pile");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player plays Golem, reveals two different actions and must choose which to play f" +
            "irst")]
        public virtual void PlayerPlaysGolemRevealsTwoDifferentActionsAndMustChooseWhichToPlayFirst()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player plays Golem, reveals two different actions and must choose which to play f" +
                    "irst", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 39
testRunner.Given("A new game with 3 players");
#line 40
testRunner.And("Player1 has a Golem in hand instead of a Copper");
#line 41
testRunner.And("Player1 has a deck of Village, Estate, Copper, Militia, Copper, Copper");
#line 42
testRunner.When("Player1 plays a Golem");
#line 43
testRunner.Then("Player1 must select a revealed card from: Village, Militia");
#line 44
testRunner.And("Player1 should have a discard pile of Estate, Copper");
#line 45
testRunner.And("Player1 should have in play: Golem");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player plays Golem, reveals two different actions and the chosen action is resolv" +
            "ed first")]
        public virtual void PlayerPlaysGolemRevealsTwoDifferentActionsAndTheChosenActionIsResolvedFirst()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player plays Golem, reveals two different actions and the chosen action is resolv" +
                    "ed first", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
testRunner.Given("A new game with 3 players");
#line 49
testRunner.And("Player1 has a Golem in hand instead of a Copper");
#line 50
testRunner.And("Player1 has a deck of Village, Estate, Copper, Nobles, Copper, Copper");
#line 51
testRunner.When("Player1 plays a Golem");
#line 52
testRunner.When("Player1 selects Nobles from the revealed cards");
#line 53
testRunner.Then("Player1 must choose from DrawCards, GainActions");
#line 54
testRunner.And("Player1 should have in play: Golem, Nobles");
#line 55
testRunner.And("Player1 should have 0 remaining actions");
#line 56
testRunner.And("Player1 should have 4 cards in hand");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
