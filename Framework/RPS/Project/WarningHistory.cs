    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.WarningHistory
{
    //RPS VERSION 1.0.0.0
    public partial class WarningHistory:Screen
    {
        public WarningHistory():base()
        {
            this.URL = "project.warninghistory";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            WarningHistoryQueryView  = new WarningHistoryQueryView(this); 
            WarningHistoryQueryView.InitializeControls(); 
           
        }
      
            public WarningHistoryQueryView WarningHistoryQueryView {get; set; } 
    }
            
    public partial class WarningHistoryQueryView : View
    {
        public WarningHistoryQueryView(WarningHistory screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIEmployee = RPSControlFactory.CreateRPSComboBox<WarningHistoryQueryView>("b08299af-2ce7-431f-a0c5-7f2849b27878","","",false, this);
 
            UIAssignedTo = RPSControlFactory.CreateRPSCheckBox<WarningHistoryQueryView>("b2eb4849-c844-489c-bba0-113d413f0be7","","",false, this);
 
            UIReportedBy = RPSControlFactory.CreateRPSCheckBox<WarningHistoryQueryView>("7dd42191-7afb-4119-959a-2baffeb16266","","",false, this);
 
            UIManager = RPSControlFactory.CreateRPSCheckBox<WarningHistoryQueryView>("6e7d76eb-2ae9-4c19-81e9-2c791642c597","","",false, this);
 
            UIPendingTickets = RPSControlFactory.CreateRPSCheckBox<WarningHistoryQueryView>("efc7385c-be7f-4e52-90c6-04ad79bff94f","","",false, this);
 
            UISite = RPSControlFactory.CreateRPSComboBox<WarningHistoryQueryView>("a1f18f6e-bea5-4ef4-ab5a-1dd388437c9c","","",false, this);
 
            UILstProject = RPSControlFactory.CreateRPSCollectionComboBox<WarningHistoryQueryView>("1cec31b6-ec65-49e0-b868-e7816fad6286","","",false, this);
 
            UILstProjectTask = RPSControlFactory.CreateRPSCollectionComboBox<WarningHistoryQueryView>("6357cab1-4ba1-469e-ba1a-d5d8814a3220","","",false, this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<WarningHistoryQueryView>("a30ae917-3765-416c-8732-e8e7e17c8bd1","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<WarningHistoryQueryView>("6c384c14-a0a8-400e-a0ca-0707ee55cbe5","","",false, this);
 
            UIWarning = RPSControlFactory.CreateRPSComboBox<WarningHistoryQueryView>("9831587b-26df-4bd5-a1b7-12faa67ebc94","","",false, this);
 
            UIDescription = RPSControlFactory.CreateRPSTextBox<WarningHistoryQueryView>("ec6220d8-36cd-4b19-8557-3e4082547459","","",false, this);
 
            UIWarningType = RPSControlFactory.CreateRPSCollectionComboBox<WarningHistoryQueryView>("a28fd41b-fd94-4e13-acf6-86a4bc3b27b0","","",false, this);
 
            SituationWarning = RPSControlFactory.CreateRPSComboBox<WarningHistoryQueryView>("c79264f3-2727-4527-86be-669ba404fe8d","","",false, this);
 
            CollectionInit params_WarningHistory = new CollectionInit(){IDDescriptor = "f4bd9635-7371-4f70-b386-38c9e315b0bc",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f0b4c6d4-a76f-4d92-ad53-9bfcfed16157",CSSSelectorGrid="",XPathGrid=""};
            WarningHistory = RPSControlFactory.RPSCreateCollectionWithGrid<WarningHistoryCollectionEditor<WarningHistoryQueryView>,WarningHistoryQueryView>( params_WarningHistory,this);
 
            CollectionInit params_WarningHistorySolution = new CollectionInit(){IDDescriptor = "f4bd9635-7371-4f70-b386-38c9e315b0bc",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e4cf0dc6-0dcc-4333-ad91-c32fdc784a2b",CSSSelectorGrid="",XPathGrid=""};
            WarningHistorySolution = RPSControlFactory.RPSCreateCollectionWithGrid<WarningHistorySolutionCollectionEditor<WarningHistoryQueryView>,WarningHistoryQueryView>( params_WarningHistorySolution,this);
 

        }
        public IRPSComboBox<WarningHistoryQueryView> UIEmployee { get; set; } 
        public IRPSCheckbox<WarningHistoryQueryView> UIAssignedTo { get; set; } 
        public IRPSCheckbox<WarningHistoryQueryView> UIReportedBy { get; set; } 
        public IRPSCheckbox<WarningHistoryQueryView> UIManager { get; set; } 
        public IRPSCheckbox<WarningHistoryQueryView> UIPendingTickets { get; set; } 
        public IRPSComboBox<WarningHistoryQueryView> UISite { get; set; } 
        public IRPSCollectionComboBox<WarningHistoryQueryView> UILstProject { get; set; } 
        public IRPSCollectionComboBox<WarningHistoryQueryView> UILstProjectTask { get; set; } 
        public IRPSTextBox<WarningHistoryQueryView> UIDateFrom { get; set; } 
        public IRPSTextBox<WarningHistoryQueryView> UIDateTo { get; set; } 
        public IRPSComboBox<WarningHistoryQueryView> UIWarning { get; set; } 
        public IRPSTextBox<WarningHistoryQueryView> UIDescription { get; set; } 
        public IRPSCollectionComboBox<WarningHistoryQueryView> UIWarningType { get; set; } 
        public IRPSComboBox<WarningHistoryQueryView> SituationWarning { get; set; } 
        public WarningHistoryCollectionEditor<WarningHistoryQueryView> WarningHistory { get; set; } 
        public WarningHistorySolutionCollectionEditor<WarningHistoryQueryView> WarningHistorySolution { get; set; } 
        public WarningHistory Screen { get; set; }
        public WarningHistoryQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class WarningHistoryCollectionEditor<WarningHistoryQueryView>:RPSCollectionEditor<WarningHistoryQueryView> where WarningHistoryQueryView : class, IView
    {
        public  WarningHistoryGridView<WarningHistoryQueryView> GridView {get;set;}
    }
    public partial class WarningHistoryGridView <WarningHistoryQueryView> :  RPSGridView<WarningHistoryQueryView> where WarningHistoryQueryView : class, IView
    {
        public WarningHistoryGridView(WarningHistoryQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            EntryDate = RPSControlFactory.CreateRPSGridTextBox<WarningHistoryQueryView>("","#f0b4c6d4-a76f-4d92-ad53-9bfcfed16157 .ag-row[role='row']@ROWINDEX [col-id='cWarning_EntryDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<WarningHistoryQueryView> EntryDate { get; set; } 
                     
    }
 
        public partial class WarningHistorySolutionCollectionEditor<WarningHistoryQueryView>:RPSCollectionEditor<WarningHistoryQueryView> where WarningHistoryQueryView : class, IView
    {
        public  WarningHistorySolutionGridView<WarningHistoryQueryView> GridView {get;set;}
    }
    public partial class WarningHistorySolutionGridView <WarningHistoryQueryView> :  RPSGridView<WarningHistoryQueryView> where WarningHistoryQueryView : class, IView
    {
        public WarningHistorySolutionGridView(WarningHistoryQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            WarningSolution_EntryDate = RPSControlFactory.CreateRPSGridTextBox<WarningHistoryQueryView>("","#e4cf0dc6-0dcc-4333-ad91-c32fdc784a2b .ag-row[role='row']@ROWINDEX [col-id='cWarningSolution_EntryDate']","",false, this.CurrentView);
 
            WarningSolution_EntryTime = RPSControlFactory.CreateRPSGridTextBox<WarningHistoryQueryView>("","#e4cf0dc6-0dcc-4333-ad91-c32fdc784a2b .ag-row[role='row']@ROWINDEX [col-id='cWarningSolution_EntryTime']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<WarningHistoryQueryView> WarningSolution_EntryDate { get; set; } 
        public IRPSGridTextBox<WarningHistoryQueryView> WarningSolution_EntryTime { get; set; } 
                     
    }
 
    }
  
    

}