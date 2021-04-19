    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ChargingByDeliveryNote
{
    //RPS VERSION 1.0.0.0
    public partial class ChargingByDeliveryNote:Screen
    {
        public ChargingByDeliveryNote():base()
        {
            this.URL = "project.chargingbydeliverynote";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ChargingByDeliveryNoteView  = new ChargingByDeliveryNoteView(this); 
            ChargingByDeliveryNoteView.InitializeControls(); 
           
        }
      
            public ChargingByDeliveryNoteView ChargingByDeliveryNoteView {get; set; } 
    }
            
    public partial class ChargingByDeliveryNoteView : View
    {
        public ChargingByDeliveryNoteView(ChargingByDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeliveryNoteSL = RPSControlFactory.CreateRPSComboBox<ChargingByDeliveryNoteView>("373aa152-f653-49cd-a1f7-2a25ab8894ee","","",false, this);
 
            SaveCommandButton = RPSControlFactory.CreateRPSButton<ChargingByDeliveryNoteView>( "aae487bf-60c8-4567-93f7-661941c82260","","",this);
 
            CollectionInit params_ChargingByDeliveryNote = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f70bd14d-d725-44a7-8ced-0288e22da7ef",CSSSelectorGrid="",XPathGrid=""};
            ChargingByDeliveryNote = RPSControlFactory.RPSCreateCollectionWithGrid<ChargingByDeliveryNoteCollectionEditor<ChargingByDeliveryNoteView>,ChargingByDeliveryNoteView>( params_ChargingByDeliveryNote,this);
 
            CollectionInit params_CertificationsByDeliveryNote = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="944025cc-f7cb-4ce8-a6e6-cdade95c1750",CSSSelectorGrid="",XPathGrid=""};
            CertificationsByDeliveryNote = RPSControlFactory.RPSCreateCollectionWithGrid<CertificationsByDeliveryNoteCollectionEditor<ChargingByDeliveryNoteView>,ChargingByDeliveryNoteView>( params_CertificationsByDeliveryNote,this);
 
            Section1 = RPSControlFactory.CreateRPSSection<ChargingByDeliveryNoteView>( "","ul li[rpsid='fb7ad2fc-5b1d-4b89-acc3-48749992a9c9']","",this);
 
            Section2 = RPSControlFactory.CreateRPSSection<ChargingByDeliveryNoteView>( "","ul li[rpsid='ca606398-6a10-45e3-b702-3af1e418e0c7']","",this);
 

        }
        public IRPSComboBox<ChargingByDeliveryNoteView> DeliveryNoteSL { get; set; } 
        public IRPSButton<ChargingByDeliveryNoteView> SaveCommandButton { get; set; } 
        public ChargingByDeliveryNoteCollectionEditor<ChargingByDeliveryNoteView> ChargingByDeliveryNote { get; set; } 
        public CertificationsByDeliveryNoteCollectionEditor<ChargingByDeliveryNoteView> CertificationsByDeliveryNote { get; set; } 
        public IRPSSection<ChargingByDeliveryNoteView> Section1 { get; set; } 
        public IRPSSection<ChargingByDeliveryNoteView> Section2 { get; set; } 
        public ChargingByDeliveryNote Screen { get; set; }
        public ChargingByDeliveryNoteView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ChargingByDeliveryNoteCollectionEditor<ChargingByDeliveryNoteView>:RPSCollectionEditor<ChargingByDeliveryNoteView> where ChargingByDeliveryNoteView : class, IView
    {
        public  ChargingByDeliveryNoteGridView<ChargingByDeliveryNoteView> GridView {get;set;}
    }
    public partial class ChargingByDeliveryNoteGridView <ChargingByDeliveryNoteView> :  RPSGridView<ChargingByDeliveryNoteView> where ChargingByDeliveryNoteView : class, IView
    {
        public ChargingByDeliveryNoteGridView(ChargingByDeliveryNoteView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridTextBox<ChargingByDeliveryNoteView>("","#f70bd14d-d725-44a7-8ced-0288e22da7ef .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            Project = RPSControlFactory.CreateRPSGridTextBox<ChargingByDeliveryNoteView>("","#f70bd14d-d725-44a7-8ced-0288e22da7ef .ag-row[role='row']@ROWINDEX [col-id='cProject']","",false, this.CurrentView);
 
            ProjectDescription = RPSControlFactory.CreateRPSGridTextBox<ChargingByDeliveryNoteView>("","#f70bd14d-d725-44a7-8ced-0288e22da7ef .ag-row[role='row']@ROWINDEX [col-id='cProjectDescription']","",false, this.CurrentView);
 
            Task = RPSControlFactory.CreateRPSGridTextBox<ChargingByDeliveryNoteView>("","#f70bd14d-d725-44a7-8ced-0288e22da7ef .ag-row[role='row']@ROWINDEX [col-id='cTask']","",false, this.CurrentView);
 
            DescTask = RPSControlFactory.CreateRPSGridTextBox<ChargingByDeliveryNoteView>("","#f70bd14d-d725-44a7-8ced-0288e22da7ef .ag-row[role='row']@ROWINDEX [col-id='cDescTask']","",false, this.CurrentView);
 
            Resource = RPSControlFactory.CreateRPSGridTextBox<ChargingByDeliveryNoteView>("","#f70bd14d-d725-44a7-8ced-0288e22da7ef .ag-row[role='row']@ROWINDEX [col-id='cResource']","",false, this.CurrentView);
 
            ResDescription = RPSControlFactory.CreateRPSGridTextBox<ChargingByDeliveryNoteView>("","#f70bd14d-d725-44a7-8ced-0288e22da7ef .ag-row[role='row']@ROWINDEX [col-id='cResDescription']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<ChargingByDeliveryNoteView>("","#f70bd14d-d725-44a7-8ced-0288e22da7ef .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ChargingByDeliveryNoteView>("","#f70bd14d-d725-44a7-8ced-0288e22da7ef .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ChargingByDeliveryNoteView> Type { get; set; } 
        public IRPSGridTextBox<ChargingByDeliveryNoteView> Project { get; set; } 
        public IRPSGridTextBox<ChargingByDeliveryNoteView> ProjectDescription { get; set; } 
        public IRPSGridTextBox<ChargingByDeliveryNoteView> Task { get; set; } 
        public IRPSGridTextBox<ChargingByDeliveryNoteView> DescTask { get; set; } 
        public IRPSGridTextBox<ChargingByDeliveryNoteView> Resource { get; set; } 
        public IRPSGridTextBox<ChargingByDeliveryNoteView> ResDescription { get; set; } 
        public IRPSGridTextBox<ChargingByDeliveryNoteView> Date { get; set; } 
        public IRPSGridTextBox<ChargingByDeliveryNoteView> Quantity { get; set; } 
                     
    }
 
        public partial class CertificationsByDeliveryNoteCollectionEditor<ChargingByDeliveryNoteView>:RPSCollectionEditor<ChargingByDeliveryNoteView> where ChargingByDeliveryNoteView : class, IView
    {
        public  CertificationsByDeliveryNoteGridView<ChargingByDeliveryNoteView> GridView {get;set;}
    }
    public partial class CertificationsByDeliveryNoteGridView <ChargingByDeliveryNoteView> :  RPSGridView<ChargingByDeliveryNoteView> where ChargingByDeliveryNoteView : class, IView
    {
        public CertificationsByDeliveryNoteGridView(ChargingByDeliveryNoteView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridTextBox<ChargingByDeliveryNoteView>("","#944025cc-f7cb-4ce8-a6e6-cdade95c1750 .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            Project = RPSControlFactory.CreateRPSGridTextBox<ChargingByDeliveryNoteView>("","#944025cc-f7cb-4ce8-a6e6-cdade95c1750 .ag-row[role='row']@ROWINDEX [col-id='cProject']","",false, this.CurrentView);
 
            ProjectDescription = RPSControlFactory.CreateRPSGridTextBox<ChargingByDeliveryNoteView>("","#944025cc-f7cb-4ce8-a6e6-cdade95c1750 .ag-row[role='row']@ROWINDEX [col-id='cProjectDescription']","",false, this.CurrentView);
 
            Task = RPSControlFactory.CreateRPSGridTextBox<ChargingByDeliveryNoteView>("","#944025cc-f7cb-4ce8-a6e6-cdade95c1750 .ag-row[role='row']@ROWINDEX [col-id='cTask']","",false, this.CurrentView);
 
            DescTask = RPSControlFactory.CreateRPSGridTextBox<ChargingByDeliveryNoteView>("","#944025cc-f7cb-4ce8-a6e6-cdade95c1750 .ag-row[role='row']@ROWINDEX [col-id='cDescTask']","",false, this.CurrentView);
 
            Resource = RPSControlFactory.CreateRPSGridTextBox<ChargingByDeliveryNoteView>("","#944025cc-f7cb-4ce8-a6e6-cdade95c1750 .ag-row[role='row']@ROWINDEX [col-id='cResource']","",false, this.CurrentView);
 
            ResDescription = RPSControlFactory.CreateRPSGridTextBox<ChargingByDeliveryNoteView>("","#944025cc-f7cb-4ce8-a6e6-cdade95c1750 .ag-row[role='row']@ROWINDEX [col-id='cResDescription']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<ChargingByDeliveryNoteView>("","#944025cc-f7cb-4ce8-a6e6-cdade95c1750 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ChargingByDeliveryNoteView>("","#944025cc-f7cb-4ce8-a6e6-cdade95c1750 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ChargingByDeliveryNoteView> Type { get; set; } 
        public IRPSGridTextBox<ChargingByDeliveryNoteView> Project { get; set; } 
        public IRPSGridTextBox<ChargingByDeliveryNoteView> ProjectDescription { get; set; } 
        public IRPSGridTextBox<ChargingByDeliveryNoteView> Task { get; set; } 
        public IRPSGridTextBox<ChargingByDeliveryNoteView> DescTask { get; set; } 
        public IRPSGridTextBox<ChargingByDeliveryNoteView> Resource { get; set; } 
        public IRPSGridTextBox<ChargingByDeliveryNoteView> ResDescription { get; set; } 
        public IRPSGridTextBox<ChargingByDeliveryNoteView> Date { get; set; } 
        public IRPSGridTextBox<ChargingByDeliveryNoteView> Quantity { get; set; } 
                     
    }
 
    }
  
    

}