// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Bowling.SpecFlowXUnit.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PunkteberechnungFeature : Xunit.IClassFixture<PunkteberechnungFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Punkteberechnung.feature"
#line hidden
        
        public PunkteberechnungFeature(PunkteberechnungFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("de-AT"), "Punkteberechnung", "    Als Spieler\r\n    Will ich, dass das System meine Punktezahl berechnet\r\n    Da" +
                    "mit ich weiss wie gut ich bin", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioTearDown()
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
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Keine Punkte")]
        [Xunit.TraitAttribute("FeatureTitle", "Punkteberechnung")]
        [Xunit.TraitAttribute("Description", "Keine Punkte")]
        public virtual void KeinePunkte()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Keine Punkte", null, ((string[])(null)));
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 testRunner.Given("eine neue Bowling-Partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Gegeben sei ");
#line 8
 testRunner.When("alle meine Kugeln in der Seitenrinne landen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Wenn ");
#line 9
    testRunner.Then("soll meine Punktzahl 0 sein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dann ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Anfänger-Spiel")]
        [Xunit.TraitAttribute("FeatureTitle", "Punkteberechnung")]
        [Xunit.TraitAttribute("Description", "Anfänger-Spiel")]
        public virtual void Anfanger_Spiel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Anfänger-Spiel", null, ((string[])(null)));
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
    testRunner.Given("eine neue Bowling-Partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Gegeben sei ");
#line 13
    testRunner.When("ich 2 und 7 werfe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Wenn ");
#line 14
    testRunner.And("ich 3 und 4 werfe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Und ");
#line 15
    testRunner.And("ich 8 mal 1 und 1 werfe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Und ");
#line 16
 testRunner.Then("soll meine Punktzahl 32 sein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dann ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Weiteres Anfänger-Spiel")]
        [Xunit.TraitAttribute("FeatureTitle", "Punkteberechnung")]
        [Xunit.TraitAttribute("Description", "Weiteres Anfänger-Spiel")]
        public virtual void WeiteresAnfanger_Spiel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Weiteres Anfänger-Spiel", null, ((string[])(null)));
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 19
    testRunner.Given("eine neue Bowling-Partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Gegeben sei ");
#line 20
    testRunner.When("ich folgende Serie werfe: 2,7,3,4,1,1,5,1,1,1,1,1,1,1,1,1,1,1,5,1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Wenn ");
#line 21
 testRunner.Then("soll meine Punktzahl 40 sein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dann ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Nur Strikes")]
        [Xunit.TraitAttribute("FeatureTitle", "Punkteberechnung")]
        [Xunit.TraitAttribute("Description", "Nur Strikes")]
        public virtual void NurStrikes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Nur Strikes", null, ((string[])(null)));
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 24
 testRunner.Given("eine neue Bowling-Partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Gegeben sei ");
#line 25
 testRunner.When("ich nur Strikes werfe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Wenn ");
#line 26
 testRunner.Then("soll meine Punktzahl 300 sein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dann ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Ein einziger Spare")]
        [Xunit.TraitAttribute("FeatureTitle", "Punkteberechnung")]
        [Xunit.TraitAttribute("Description", "Ein einziger Spare")]
        public virtual void EinEinzigerSpare()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ein einziger Spare", null, ((string[])(null)));
#line 28
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 29
    testRunner.Given("eine neue Bowling-Partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Gegeben sei ");
#line 30
    testRunner.When("ich folgende Serie werfe: 3,7,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Wenn ");
#line 31
    testRunner.Then("soll meine Punktzahl 29 sein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dann ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Nur Spares")]
        [Xunit.TraitAttribute("FeatureTitle", "Punkteberechnung")]
        [Xunit.TraitAttribute("Description", "Nur Spares")]
        public virtual void NurSpares()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Nur Spares", null, ((string[])(null)));
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 34
    testRunner.Given("eine neue Bowling-Partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Gegeben sei ");
#line 35
    testRunner.When("ich 10 mal 1 und 9 werfe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Wenn ");
#line 36
    testRunner.And("ich 1 werfe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Und ");
#line 37
    testRunner.Then("soll meine Punktzahl 110 sein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dann ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PunkteberechnungFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PunkteberechnungFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
