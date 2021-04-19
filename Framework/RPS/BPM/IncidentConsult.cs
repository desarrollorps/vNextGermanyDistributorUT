    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.IncidentConsult
{
    //RPS VERSION 1.0.0.0
    public partial class IncidentConsult:Screen
    {
        public IncidentConsult():base()
        {
            this.URL = "bpm.incidentconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            IncidentConsultQueryView  = new IncidentConsultQueryView(this); 
            IncidentConsultQueryView.InitializeControls(); 
           
        }
      
            public IncidentConsultQueryView IncidentConsultQueryView {get; set; } 
    }
            
    public partial class IncidentConsultQueryView : View
    {
        public IncidentConsultQueryView(IncidentConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDIncident = RPSControlFactory.CreateRPSCollectionComboBox<IncidentConsultQueryView>("bb66583e-a479-43ed-9b6f-31a54a8fb360","","",false, this);
 
            IDIncidentCategory = RPSControlFactory.CreateRPSCollectionComboBox<IncidentConsultQueryView>("9fe153a9-3daf-425e-b273-dd40c09a01ba","","",false, this);
 
            PendingTickets = RPSControlFactory.CreateRPSCheckBox<IncidentConsultQueryView>("2344f31b-e3d3-4adc-8b4c-cdf7d2fa2ead","","",false, this);
 
            CollectionInit params_IncidentConsult = new CollectionInit(){IDDescriptor = "ffaea624-f258-41bf-b366-87bfd5bf26b9",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a7d3ec99-5c37-40a7-b0b8-23ac6f97c992",CSSSelectorGrid="",XPathGrid=""};
            IncidentConsult = RPSControlFactory.RPSCreateCollectionWithGrid<IncidentConsultCollectionEditor<IncidentConsultQueryView>,IncidentConsultQueryView>( params_IncidentConsult,this);
 
            CollectionInit params_IncidentConsultTracking = new CollectionInit(){IDDescriptor = "ffaea624-f258-41bf-b366-87bfd5bf26b9",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ec99c0b1-55a9-480a-8bc6-50f5768edd22",CSSSelectorGrid="",XPathGrid=""};
            IncidentConsultTracking = RPSControlFactory.RPSCreateCollectionWithGrid<IncidentConsultTrackingCollectionEditor<IncidentConsultQueryView>,IncidentConsultQueryView>( params_IncidentConsultTracking,this);
 

        }
        public IRPSCollectionComboBox<IncidentConsultQueryView> IDIncident { get; set; } 
        public IRPSCollectionComboBox<IncidentConsultQueryView> IDIncidentCategory { get; set; } 
        public IRPSCheckbox<IncidentConsultQueryView> PendingTickets { get; set; } 
        public IncidentConsultCollectionEditor<IncidentConsultQueryView> IncidentConsult { get; set; } 
        public IncidentConsultTrackingCollectionEditor<IncidentConsultQueryView> IncidentConsultTracking { get; set; } 
        public IncidentConsult Screen { get; set; }
        public IncidentConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class IncidentConsultCollectionEditor<IncidentConsultQueryView>:RPSCollectionEditor<IncidentConsultQueryView> where IncidentConsultQueryView : class, IView
    {
        public  IncidentConsultGridView<IncidentConsultQueryView> GridView {get;set;}
    }
    public partial class IncidentConsultGridView <IncidentConsultQueryView> :  RPSGridView<IncidentConsultQueryView> where IncidentConsultQueryView : class, IView
    {
        public IncidentConsultGridView(IncidentConsultQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Incident_Priority = RPSControlFactory.CreateRPSGridTextBox<IncidentConsultQueryView>("","#a7d3ec99-5c37-40a7-b0b8-23ac6f97c992 .ag-row[role='row']@ROWINDEX [col-id='cIncident_Priority']","",false, this.CurrentView);
 
            Incident_State = RPSControlFactory.CreateRPSGridTextBox<IncidentConsultQueryView>("","#a7d3ec99-5c37-40a7-b0b8-23ac6f97c992 .ag-row[role='row']@ROWINDEX [col-id='cIncident_State']","",false, this.CurrentView);
 
            Incident_OpeningDate = RPSControlFactory.CreateRPSGridTextBox<IncidentConsultQueryView>("","#a7d3ec99-5c37-40a7-b0b8-23ac6f97c992 .ag-row[role='row']@ROWINDEX [col-id='cIncident_OpeningDate']","",false, this.CurrentView);
 
            Incident_CloseDate = RPSControlFactory.CreateRPSGridTextBox<IncidentConsultQueryView>("","#a7d3ec99-5c37-40a7-b0b8-23ac6f97c992 .ag-row[role='row']@ROWINDEX [col-id='cIncident_CloseDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<IncidentConsultQueryView> Incident_Priority { get; set; } 
        public IRPSGridTextBox<IncidentConsultQueryView> Incident_State { get; set; } 
        public IRPSGridTextBox<IncidentConsultQueryView> Incident_OpeningDate { get; set; } 
        public IRPSGridTextBox<IncidentConsultQueryView> Incident_CloseDate { get; set; } 
                     
    }
 
        public partial class IncidentConsultTrackingCollectionEditor<IncidentConsultQueryView>:RPSCollectionEditor<IncidentConsultQueryView> where IncidentConsultQueryView : class, IView
    {
        public  IncidentConsultTrackingGridView<IncidentConsultQueryView> GridView {get;set;}
    }
    public partial class IncidentConsultTrackingGridView <IncidentConsultQueryView> :  RPSGridView<IncidentConsultQueryView> where IncidentConsultQueryView : class, IView
    {
        public IncidentConsultTrackingGridView(IncidentConsultQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IncidentTracking_Date = RPSControlFactory.CreateRPSGridTextBox<IncidentConsultQueryView>("","#ec99c0b1-55a9-480a-8bc6-50f5768edd22 .ag-row[role='row']@ROWINDEX [col-id='cIncidentTracking_Date']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<IncidentConsultQueryView> IncidentTracking_Date { get; set; } 
                     
    }
 
    }
  
    

}