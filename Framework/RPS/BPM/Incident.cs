    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.Incident
{
    //RPS VERSION 1.0.0.0
    public partial class Incident:Screen
    {
        public Incident():base()
        {
            this.URL = "bpm.incident";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            IncidentCollectionView  = new IncidentCollectionView(this); 
            IncidentEntityView  = new IncidentEntityView(this); 
            IncidentCollectionView.InitializeControls(); 
            IncidentEntityView.InitializeControls(); 
           
        }
      
            public IncidentCollectionView IncidentCollectionView {get; set; } 
            public IncidentEntityView IncidentEntityView {get; set; } 
    }
            
    public partial class IncidentCollectionView : View
    {
        public IncidentCollectionView(Incident screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<IncidentCollectionView,IncidentEntityView>( this,Screen.IncidentEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "397faf0d-e2a8-49ba-a513-04dc0ffde407",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<IncidentCollectionView,IncidentEntityView>( params_MainConsult,this,Screen.IncidentEntityView);
 

        }
        public IRPSButton<IncidentCollectionView,IncidentEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<IncidentCollectionView,IncidentEntityView> MainConsult { get; set; } 
        public Incident Screen { get; set; }
        public IncidentCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class IncidentEntityView : View
    {
        public IncidentEntityView(Incident screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<IncidentEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<IncidentEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<IncidentEntityView,IncidentCollectionView>( this,Screen.IncidentCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<IncidentEntityView,IncidentCollectionView>( this,Screen.IncidentCollectionView);
 
            CodIncident = RPSControlFactory.CreateRPSTextBox<IncidentEntityView>("29dbd763-1830-4084-8ddf-75b8e57c844e","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<IncidentEntityView>("0a24c44b-7df8-4055-8e8d-1adeb5df06fb","","",false, this);
 
            State = RPSControlFactory.CreateRPSEnumComboBox<IncidentEntityView>("eb56283a-dc9f-4d2d-8244-879ed3588d0d","","",true, this);
 
            IDProcess = RPSControlFactory.CreateRPSComboBox<IncidentEntityView>("18bb1b8f-558a-4923-9f1a-a4e84e3d7f03","","",true, this);
 
            IDProcessTask = RPSControlFactory.CreateRPSComboBox<IncidentEntityView>("5f250f92-03f7-4fd2-b401-9e887d09da99","","",true, this);
 
            IDIncidentCategory = RPSControlFactory.CreateRPSComboBox<IncidentEntityView>("6227989e-7c63-4438-9f16-b6efea66835f","","",true, this);
 
            OpenedBy = RPSControlFactory.CreateRPSComboBox<IncidentEntityView>("f8923d18-011a-4d32-bd3e-35530c784bca","","",true, this);
 
            OpeningDate = RPSControlFactory.CreateRPSTextBox<IncidentEntityView>("591995ae-1de6-4b03-a0f8-890e072a7baa","","",true, this);
 
            OpeningTime = RPSControlFactory.CreateRPSTextBox<IncidentEntityView>("6bbb3afd-90fd-4717-ba96-1b14e6208ac6","","",true, this);
 
            ClosedBy = RPSControlFactory.CreateRPSComboBox<IncidentEntityView>("dc3afb78-a98a-44b3-85d6-c462cd38a698","","",false, this);
 
            CloseDate = RPSControlFactory.CreateRPSTextBox<IncidentEntityView>("cfbaa60e-5f71-4a52-8275-a1ee9036659e","","",false, this);
 
            CloseTime = RPSControlFactory.CreateRPSTextBox<IncidentEntityView>("39ccc115-d14a-4cee-ae8f-f30fc3151d4b","","",false, this);
 
            IsBlocking = RPSControlFactory.CreateRPSCheckBox<IncidentEntityView>("de9531e5-b359-4b02-afd7-22b9aa7b75a9","","",false, this);
 
            Priority = RPSControlFactory.CreateRPSEnumComboBox<IncidentEntityView>("60e538be-a514-4691-beea-6d25e8db79fe","","",false, this);
 
            IDIncidentType = RPSControlFactory.CreateRPSComboBox<IncidentEntityView>("ceccb80a-0b9d-4558-a2ca-27fa2f15ae82","","",false, this);
 
            Details = RPSControlFactory.CreateRPSTextBox<IncidentEntityView>("56ea7891-d532-42b3-8f62-8e527ea56b85","","",false, this);
 
            CloseNotes = RPSControlFactory.CreateRPSTextBox<IncidentEntityView>("81d1e5ea-270c-4c2a-ab73-7c164b8a0f4a","","",false, this);
 
            CollectionInit params_IncidentTrackings = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ee1f2282-aaf3-4152-867c-85b14d63a9b1",CSSSelectorGrid="",XPathGrid=""};
            IncidentTrackings = RPSControlFactory.RPSCreateCollectionWithGrid<IncidentTrackingsCollectionEditor<IncidentEntityView>,IncidentEntityView>( params_IncidentTrackings,this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<IncidentEntityView>( "","ul li[rpsid='cceb5204-f06d-45dc-ae5f-1b1f294d8909']","",this);
 
            DetailSection = RPSControlFactory.CreateRPSSection<IncidentEntityView>( "","ul li[rpsid='1d9693e5-6cf8-4e1f-b04c-283971a2edd6']","",this);
 
            TrackingSection = RPSControlFactory.CreateRPSSection<IncidentEntityView>( "","ul li[rpsid='850cd04e-969d-401d-9b80-43aeeeea5330']","",this);
 

        }
        public IRPSSaveButton<IncidentEntityView> SaveButton { get; set; } 
        public IRPSButton<IncidentEntityView> DeleteButton { get; set; } 
        public IRPSButton<IncidentEntityView,IncidentCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<IncidentEntityView,IncidentCollectionView> BackButton { get; set; } 
        public IRPSTextBox<IncidentEntityView> CodIncident { get; set; } 
        public IRPSTextBox<IncidentEntityView> Description { get; set; } 
        public IRPSComboBox<IncidentEntityView> State { get; set; } 
        public IRPSComboBox<IncidentEntityView> IDProcess { get; set; } 
        public IRPSComboBox<IncidentEntityView> IDProcessTask { get; set; } 
        public IRPSComboBox<IncidentEntityView> IDIncidentCategory { get; set; } 
        public IRPSComboBox<IncidentEntityView> OpenedBy { get; set; } 
        public IRPSTextBox<IncidentEntityView> OpeningDate { get; set; } 
        public IRPSTextBox<IncidentEntityView> OpeningTime { get; set; } 
        public IRPSComboBox<IncidentEntityView> ClosedBy { get; set; } 
        public IRPSTextBox<IncidentEntityView> CloseDate { get; set; } 
        public IRPSTextBox<IncidentEntityView> CloseTime { get; set; } 
        public IRPSCheckbox<IncidentEntityView> IsBlocking { get; set; } 
        public IRPSComboBox<IncidentEntityView> Priority { get; set; } 
        public IRPSComboBox<IncidentEntityView> IDIncidentType { get; set; } 
        public IRPSTextBox<IncidentEntityView> Details { get; set; } 
        public IRPSTextBox<IncidentEntityView> CloseNotes { get; set; } 
        public IncidentTrackingsCollectionEditor<IncidentEntityView> IncidentTrackings { get; set; } 
        public IRPSSection<IncidentEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<IncidentEntityView> DetailSection { get; set; } 
        public IRPSSection<IncidentEntityView> TrackingSection { get; set; } 
        public Incident Screen { get; set; }
        public IncidentEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class IncidentTrackingsCollectionEditor<IncidentEntityView>:RPSCollectionEditor<IncidentEntityView> where IncidentEntityView : class, IView
    {
        public  IncidentTrackingsGridView<IncidentEntityView> GridView {get;set;}
    }
    public partial class IncidentTrackingsGridView <IncidentEntityView> :  RPSGridView<IncidentEntityView> where IncidentEntityView : class, IView
    {
        public IncidentTrackingsGridView(IncidentEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<IncidentEntityView>("","#ee1f2282-aaf3-4152-867c-85b14d63a9b1 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            CreatedBy = RPSControlFactory.CreateRPSGridComboBox<IncidentEntityView>("","#ee1f2282-aaf3-4152-867c-85b14d63a9b1 .ag-row[role='row']@ROWINDEX [col-id='cCreatedBy']","",true, this.CurrentView);
 
            Details = RPSControlFactory.CreateRPSGridMemoTextBox<IncidentEntityView>("","#ee1f2282-aaf3-4152-867c-85b14d63a9b1 .ag-row[role='row']@ROWINDEX [col-id='cDetails']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<IncidentEntityView> Date { get; set; } 
        public IRPSGridComboBox<IncidentEntityView> CreatedBy { get; set; } 
        public IRPSGridTextBox<IncidentEntityView> Details { get; set; } 
                     
    }
 
    }
  
    

}