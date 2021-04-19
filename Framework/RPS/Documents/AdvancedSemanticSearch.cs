    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.AdvancedSemanticSearch
{
    //RPS VERSION 1.0.0.0
    public partial class AdvancedSemanticSearch:Screen
    {
        public AdvancedSemanticSearch():base()
        {
            this.URL = "documents.advancedsemanticsearch";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AdvancedSemanticSearchQueryView  = new AdvancedSemanticSearchQueryView(this); 
            AdvancedSemanticSearchQueryView.InitializeControls(); 
           
        }
      
            public AdvancedSemanticSearchQueryView AdvancedSemanticSearchQueryView {get; set; } 
    }
            
    public partial class AdvancedSemanticSearchQueryView : View
    {
        public AdvancedSemanticSearchQueryView(AdvancedSemanticSearch screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Simple = RPSControlFactory.CreateRPSOption<AdvancedSemanticSearchQueryView>( "e97fb4d8-949d-485c-ad33-87f9fa647a22","","",this);
 
            TextToSearch = RPSControlFactory.CreateRPSEnumComboBox<AdvancedSemanticSearchQueryView>("0149cca9-de4c-4b16-93d0-e04f11f638b6","","",false, this);
 
            ApplySuggestion = RPSControlFactory.CreateRPSButton<AdvancedSemanticSearchQueryView>( "59b34a2e-a75b-43d6-bd2b-7c3e377ab474","","",this);
 
            Advanced = RPSControlFactory.CreateRPSOption<AdvancedSemanticSearchQueryView>( "dbe75d02-d121-495a-ab2d-be03bc69cafb","","",this);
 
            AllWordsToSearch = RPSControlFactory.CreateRPSTextBox<AdvancedSemanticSearchQueryView>("d5cbc016-6fcd-414f-a1f6-1c3896758679","","",false, this);
 
            ExactPhraseToSearch = RPSControlFactory.CreateRPSTextBox<AdvancedSemanticSearchQueryView>("82c84271-15bd-4bc2-ad6e-294c1a9cf584","","",false, this);
 
            AnyWordsToSearch = RPSControlFactory.CreateRPSTextBox<AdvancedSemanticSearchQueryView>("63c796d5-d972-46f7-8e26-13cfb03fe707","","",false, this);
 
            NoneWordsToSearch = RPSControlFactory.CreateRPSTextBox<AdvancedSemanticSearchQueryView>("b354a943-029a-40cd-8694-1a85797c8f08","","",false, this);
 
            UseSynonyms = RPSControlFactory.CreateRPSCheckBox<AdvancedSemanticSearchQueryView>("0c5650d1-5bac-4b93-9704-8db4369e741c","","",false, this);
 
            ShowRelevantTerms = RPSControlFactory.CreateRPSCheckBox<AdvancedSemanticSearchQueryView>("05e978eb-5578-44aa-8605-2af239aaec84","","",false, this);
 

        }
        public IRPSOption<AdvancedSemanticSearchQueryView> Simple { get; set; } 
        public IRPSComboBox<AdvancedSemanticSearchQueryView> TextToSearch { get; set; } 
        public IRPSButton<AdvancedSemanticSearchQueryView> ApplySuggestion { get; set; } 
        public IRPSOption<AdvancedSemanticSearchQueryView> Advanced { get; set; } 
        public IRPSTextBox<AdvancedSemanticSearchQueryView> AllWordsToSearch { get; set; } 
        public IRPSTextBox<AdvancedSemanticSearchQueryView> ExactPhraseToSearch { get; set; } 
        public IRPSTextBox<AdvancedSemanticSearchQueryView> AnyWordsToSearch { get; set; } 
        public IRPSTextBox<AdvancedSemanticSearchQueryView> NoneWordsToSearch { get; set; } 
        public IRPSCheckbox<AdvancedSemanticSearchQueryView> UseSynonyms { get; set; } 
        public IRPSCheckbox<AdvancedSemanticSearchQueryView> ShowRelevantTerms { get; set; } 
        public AdvancedSemanticSearch Screen { get; set; }
        public AdvancedSemanticSearchQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}