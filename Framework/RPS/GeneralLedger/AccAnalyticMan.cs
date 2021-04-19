    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.AccAnalyticMan
{
    //RPS VERSION 1.0.0.0
    public partial class AccAnalyticMan:Screen
    {
        public AccAnalyticMan():base()
        {
            this.URL = "generalledger.accanalyticman";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ACCAnalyticManCollectionView  = new ACCAnalyticManCollectionView(this); 
            ACCAnalyticManEntityView  = new ACCAnalyticManEntityView(this); 
            ACCTransactionsAnalyticView  = new ACCTransactionsAnalyticView(this); 
            ACCAnalyticManCollectionView.InitializeControls(); 
            ACCAnalyticManEntityView.InitializeControls(); 
            ACCTransactionsAnalyticView.InitializeControls(); 
           
        }
      
            public ACCAnalyticManCollectionView ACCAnalyticManCollectionView {get; set; } 
            public ACCAnalyticManEntityView ACCAnalyticManEntityView {get; set; } 
            public ACCTransactionsAnalyticView ACCTransactionsAnalyticView {get; set; } 
    }
            
    public partial class ACCAnalyticManCollectionView : View
    {
        public ACCAnalyticManCollectionView(AccAnalyticMan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ACCAnalyticManCollectionView,ACCAnalyticManEntityView>( this,Screen.ACCAnalyticManEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0b364e23-387d-4074-837d-71815a853074",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ACCAnalyticManCollectionView,ACCAnalyticManEntityView>( params_MainConsult,this,Screen.ACCAnalyticManEntityView);
 

        }
        public IRPSButton<ACCAnalyticManCollectionView,ACCAnalyticManEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ACCAnalyticManCollectionView,ACCAnalyticManEntityView> MainConsult { get; set; } 
        public AccAnalyticMan Screen { get; set; }
        public ACCAnalyticManCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ACCAnalyticManEntityView : View
    {
        public ACCAnalyticManEntityView(AccAnalyticMan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ACCAnalyticManEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ACCAnalyticManEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ACCAnalyticManEntityView,ACCAnalyticManCollectionView>( this,Screen.ACCAnalyticManCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ACCAnalyticManEntityView,ACCAnalyticManCollectionView>( this,Screen.ACCAnalyticManCollectionView);
 
            JournalAna = RPSControlFactory.CreateRPSFormattedTextBox<ACCAnalyticManEntityView>("08862dc8-737d-406e-92d8-70f5d98b8ac6","","",true, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<ACCAnalyticManEntityView>("e290724f-266e-42e8-b084-f7e80e789692","","",true, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<ACCAnalyticManEntityView>("4daf4acc-c179-4ee2-89fd-22abb9d36280","","",true, this);
 
            SignType = RPSControlFactory.CreateRPSEnumComboBox<ACCAnalyticManEntityView>("ffe899a2-1a91-4f4d-b013-96c2b331d0d4","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<ACCAnalyticManEntityView>("50157a62-ceaf-40db-af35-ac35dab6adac","","",true, this);
 
            Extension = RPSControlFactory.CreateRPSTextBox<ACCAnalyticManEntityView>("93cd77b7-0313-4f52-ba76-5eccc92ec457","","",false, this);
 
            DuplicateCommandButton = RPSControlFactory.CreateRPSButton<ACCAnalyticManEntityView>( "b1304117-eeb3-4318-8210-3a70b0daa666","","",this);
 
            CollectionInit params_ACCTransactionsAnalytics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9503a74f-1076-4290-93d3-59042b9b7d1e",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsAnalytics = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsAnalyticsCollectionEditor<ACCAnalyticManEntityView,ACCTransactionsAnalyticView>,ACCAnalyticManEntityView,ACCTransactionsAnalyticView>( params_ACCTransactionsAnalytics,this,Screen.ACCTransactionsAnalyticView);
 

        }
        public IRPSSaveButton<ACCAnalyticManEntityView> SaveButton { get; set; } 
        public IRPSButton<ACCAnalyticManEntityView> DeleteButton { get; set; } 
        public IRPSButton<ACCAnalyticManEntityView,ACCAnalyticManCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ACCAnalyticManEntityView,ACCAnalyticManCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ACCAnalyticManEntityView> JournalAna { get; set; } 
        public IRPSComboBox<ACCAnalyticManEntityView> IDAccount { get; set; } 
        public IRPSTextBox<ACCAnalyticManEntityView> AccountingDate { get; set; } 
        public IRPSComboBox<ACCAnalyticManEntityView> SignType { get; set; } 
        public IRPSTextBox<ACCAnalyticManEntityView> Amount { get; set; } 
        public IRPSTextBox<ACCAnalyticManEntityView> Extension { get; set; } 
        public IRPSButton<ACCAnalyticManEntityView> DuplicateCommandButton { get; set; } 
        public ACCTransactionsAnalyticsCollectionEditor<ACCAnalyticManEntityView,ACCTransactionsAnalyticView> ACCTransactionsAnalytics { get; set; } 
        public AccAnalyticMan Screen { get; set; }
        public ACCAnalyticManEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ACCTransactionsAnalyticsCollectionEditor<ACCAnalyticManEntityView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCAnalyticManEntityView,ACCTransactionsAnalyticView> where ACCAnalyticManEntityView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsAnalyticsGridView<ACCAnalyticManEntityView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsAnalyticsGridView <ACCAnalyticManEntityView,ACCTransactionsAnalyticView> :  RPSGridView<ACCAnalyticManEntityView,ACCTransactionsAnalyticView> where ACCAnalyticManEntityView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsAnalyticsGridView(ACCAnalyticManEntityView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<ACCAnalyticManEntityView>("","#9503a74f-1076-4290-93d3-59042b9b7d1e .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<ACCAnalyticManEntityView>("","#9503a74f-1076-4290-93d3-59042b9b7d1e .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCAnalyticManEntityView>("","#9503a74f-1076-4290-93d3-59042b9b7d1e .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCAnalyticManEntityView>("","#9503a74f-1076-4290-93d3-59042b9b7d1e .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ACCAnalyticManEntityView> IDDimension { get; set; } 
        public IRPSGridComboBox<ACCAnalyticManEntityView> IDDimValue { get; set; } 
        public IRPSGridTextBox<ACCAnalyticManEntityView> Percentage { get; set; } 
        public IRPSGridTextBox<ACCAnalyticManEntityView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class ACCTransactionsAnalyticView : View
    {
        public ACCTransactionsAnalyticView(AccAnalyticMan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ACCTransactionsAnalyticView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ACCTransactionsAnalyticView,ACCAnalyticManEntityView>( this,Screen.ACCAnalyticManEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ACCTransactionsAnalyticView,ACCAnalyticManEntityView>( this,Screen.ACCAnalyticManEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ACCTransactionsAnalyticView,ACCAnalyticManEntityView>( this,Screen.ACCAnalyticManEntityView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<ACCTransactionsAnalyticView>("86307178-d87b-44b6-8504-1ac4d691b957","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<ACCTransactionsAnalyticView>("c0302f07-7b3d-4947-9e9c-7fd5188501d1","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsAnalyticView>("c14be60d-23fd-41e2-b565-a6b71d3bc251","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsAnalyticView>("ae91e91c-ca7b-4dca-a139-6a5388501cc8","","",true, this);
 

        }
        public IRPSButton<ACCTransactionsAnalyticView> DeleteButton { get; set; } 
        public IRPSButton<ACCTransactionsAnalyticView,ACCAnalyticManEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ACCTransactionsAnalyticView,ACCAnalyticManEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ACCTransactionsAnalyticView,ACCAnalyticManEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ACCTransactionsAnalyticView> IDDimension { get; set; } 
        public IRPSComboBox<ACCTransactionsAnalyticView> IDDimValue { get; set; } 
        public IRPSTextBox<ACCTransactionsAnalyticView> Percentage { get; set; } 
        public IRPSTextBox<ACCTransactionsAnalyticView> Amount { get; set; } 
        public AccAnalyticMan Screen { get; set; }
        public ACCTransactionsAnalyticView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}