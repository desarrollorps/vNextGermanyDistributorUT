    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.ProcessIndicatorMeasurements
{
    //RPS VERSION 1.0.0.0
    public partial class ProcessIndicatorMeasurements:Screen
    {
        public ProcessIndicatorMeasurements():base()
        {
            this.URL = "bpm.processindicatormeasurements";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProcessIndicatorMeasurementsQueryView  = new ProcessIndicatorMeasurementsQueryView(this); 
            ProcessIndicatorMeasurementsQueryView.InitializeControls(); 
           
        }
      
            public ProcessIndicatorMeasurementsQueryView ProcessIndicatorMeasurementsQueryView {get; set; } 
    }
            
    public partial class ProcessIndicatorMeasurementsQueryView : View
    {
        public ProcessIndicatorMeasurementsQueryView(ProcessIndicatorMeasurements screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIProcess = RPSControlFactory.CreateRPSComboBox<ProcessIndicatorMeasurementsQueryView>("466d1473-b32a-4839-bc7e-208795784743","","",false, this);
 
            UIProcessIndicator = RPSControlFactory.CreateRPSComboBox<ProcessIndicatorMeasurementsQueryView>("13f69b31-e860-44f0-a236-28315978c482","","",false, this);
 
            UIOptAllData = RPSControlFactory.CreateRPSOption<ProcessIndicatorMeasurementsQueryView>( "80007275-4886-440b-b353-97d4ed0d3b47","","",this);
 
            UIOptByDates = RPSControlFactory.CreateRPSOption<ProcessIndicatorMeasurementsQueryView>( "2af1edf9-413b-40eb-9868-f4915efa0055","","",this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<ProcessIndicatorMeasurementsQueryView>("204eaf91-e277-44fb-b1d1-fc18fc5576f2","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<ProcessIndicatorMeasurementsQueryView>("7c0c14e5-66b8-482f-aa88-69658eb47f5a","","",false, this);
 
            UIOptLastValues = RPSControlFactory.CreateRPSOption<ProcessIndicatorMeasurementsQueryView>( "59e62ee3-626a-4398-a210-550d843ed3d8","","",this);
 
            UILastItems = RPSControlFactory.CreateRPSFormattedTextBox<ProcessIndicatorMeasurementsQueryView>("b4dd24d0-b529-4443-a516-a29b7c00d41d","","",false, this);
 
            Achieved = RPSControlFactory.CreateRPSFormattedTextBox<ProcessIndicatorMeasurementsQueryView>("c7c1ca9f-27ad-4ba0-b63d-d3d479dbb484","","",false, this);
 
            LimitValue = RPSControlFactory.CreateRPSFormattedTextBox<ProcessIndicatorMeasurementsQueryView>("e2c9a62e-242b-4ede-b27d-e78cb3438bbc","","",false, this);
 
            TargetValue = RPSControlFactory.CreateRPSFormattedTextBox<ProcessIndicatorMeasurementsQueryView>("1e211b28-0e16-4d4c-af2f-3b0de874a843","","",false, this);
 
            ProcessIndicator_MeasurementUnit = RPSControlFactory.CreateRPSTextBox<ProcessIndicatorMeasurementsQueryView>("6abc2a4f-ca66-4694-b97d-6f40667b55ff","","",false, this);
 
            ProcessIndicator_CompareType = RPSControlFactory.CreateRPSTextBox<ProcessIndicatorMeasurementsQueryView>("97854a88-9e7c-45d9-8873-c37bb092df47","","",false, this);
 
            ProcessIndicator_ValueInterpretation = RPSControlFactory.CreateRPSTextBox<ProcessIndicatorMeasurementsQueryView>("c83f6bf9-3e2f-4691-a63f-7ac18c6e18ee","","",false, this);
 
            ProcessIndicator_IndicatorType = RPSControlFactory.CreateRPSTextBox<ProcessIndicatorMeasurementsQueryView>("7b15ad9d-d055-4397-95e6-1cde56688ba9","","",false, this);
 
            NewCommand = RPSControlFactory.CreateRPSButton<ProcessIndicatorMeasurementsQueryView>( "5e20b2e5-ba09-4da1-b465-136e2800893f","","",this);
 
            SaveCommand = RPSControlFactory.CreateRPSButton<ProcessIndicatorMeasurementsQueryView>( "ed7f9de1-c64b-4583-85f4-f3d7ff840993","","",this);
 
            CollectionInit params_GetProcessIndicatorMeasurements = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6a157ba5-356b-4e32-9b56-a1ad5265412b",CSSSelectorGrid="",XPathGrid=""};
            GetProcessIndicatorMeasurements = RPSControlFactory.RPSCreateCollectionWithGrid<GetProcessIndicatorMeasurementsCollectionEditor<ProcessIndicatorMeasurementsQueryView>,ProcessIndicatorMeasurementsQueryView>( params_GetProcessIndicatorMeasurements,this);
 
            CollectionInit params_IndicatorMeasurementsData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5d5e4880-89a7-4400-940a-94449ee6e83f",CSSSelectorGrid="",XPathGrid=""};
            IndicatorMeasurementsData = RPSControlFactory.RPSCreateCollectionWithGrid<IndicatorMeasurementsDataCollectionEditor<ProcessIndicatorMeasurementsQueryView>,ProcessIndicatorMeasurementsQueryView>( params_IndicatorMeasurementsData,this);
 

        }
        public IRPSComboBox<ProcessIndicatorMeasurementsQueryView> UIProcess { get; set; } 
        public IRPSComboBox<ProcessIndicatorMeasurementsQueryView> UIProcessIndicator { get; set; } 
        public IRPSOption<ProcessIndicatorMeasurementsQueryView> UIOptAllData { get; set; } 
        public IRPSOption<ProcessIndicatorMeasurementsQueryView> UIOptByDates { get; set; } 
        public IRPSTextBox<ProcessIndicatorMeasurementsQueryView> UIDateFrom { get; set; } 
        public IRPSTextBox<ProcessIndicatorMeasurementsQueryView> UIDateTo { get; set; } 
        public IRPSOption<ProcessIndicatorMeasurementsQueryView> UIOptLastValues { get; set; } 
        public IRPSTextBox<ProcessIndicatorMeasurementsQueryView> UILastItems { get; set; } 
        public IRPSTextBox<ProcessIndicatorMeasurementsQueryView> Achieved { get; set; } 
        public IRPSTextBox<ProcessIndicatorMeasurementsQueryView> LimitValue { get; set; } 
        public IRPSTextBox<ProcessIndicatorMeasurementsQueryView> TargetValue { get; set; } 
        public IRPSTextBox<ProcessIndicatorMeasurementsQueryView> ProcessIndicator_MeasurementUnit { get; set; } 
        public IRPSTextBox<ProcessIndicatorMeasurementsQueryView> ProcessIndicator_CompareType { get; set; } 
        public IRPSTextBox<ProcessIndicatorMeasurementsQueryView> ProcessIndicator_ValueInterpretation { get; set; } 
        public IRPSTextBox<ProcessIndicatorMeasurementsQueryView> ProcessIndicator_IndicatorType { get; set; } 
        public IRPSButton<ProcessIndicatorMeasurementsQueryView> NewCommand { get; set; } 
        public IRPSButton<ProcessIndicatorMeasurementsQueryView> SaveCommand { get; set; } 
        public GetProcessIndicatorMeasurementsCollectionEditor<ProcessIndicatorMeasurementsQueryView> GetProcessIndicatorMeasurements { get; set; } 
        public IndicatorMeasurementsDataCollectionEditor<ProcessIndicatorMeasurementsQueryView> IndicatorMeasurementsData { get; set; } 
        public ProcessIndicatorMeasurements Screen { get; set; }
        public ProcessIndicatorMeasurementsQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetProcessIndicatorMeasurementsCollectionEditor<ProcessIndicatorMeasurementsQueryView>:RPSCollectionEditor<ProcessIndicatorMeasurementsQueryView> where ProcessIndicatorMeasurementsQueryView : class, IView
    {
        public  GetProcessIndicatorMeasurementsGridView<ProcessIndicatorMeasurementsQueryView> GridView {get;set;}
    }
    public partial class GetProcessIndicatorMeasurementsGridView <ProcessIndicatorMeasurementsQueryView> :  RPSGridView<ProcessIndicatorMeasurementsQueryView> where ProcessIndicatorMeasurementsQueryView : class, IView
    {
        public GetProcessIndicatorMeasurementsGridView(ProcessIndicatorMeasurementsQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Achieved = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessIndicatorMeasurementsQueryView>("","#6a157ba5-356b-4e32-9b56-a1ad5265412b .ag-row[role='row']@ROWINDEX [col-id='cAchieved']","",false, this.CurrentView);
 
            LimitValue = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessIndicatorMeasurementsQueryView>("","#6a157ba5-356b-4e32-9b56-a1ad5265412b .ag-row[role='row']@ROWINDEX [col-id='cLimitValue']","",false, this.CurrentView);
 
            TargetValue = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessIndicatorMeasurementsQueryView>("","#6a157ba5-356b-4e32-9b56-a1ad5265412b .ag-row[role='row']@ROWINDEX [col-id='cTargetValue']","",false, this.CurrentView);
 
            ProcessIndicator_MeasurementUnit = RPSControlFactory.CreateRPSGridTextBox<ProcessIndicatorMeasurementsQueryView>("","#6a157ba5-356b-4e32-9b56-a1ad5265412b .ag-row[role='row']@ROWINDEX [col-id='cProcessIndicator_MeasurementUnit']","",false, this.CurrentView);
 
            ProcessIndicator_CompareType = RPSControlFactory.CreateRPSGridTextBox<ProcessIndicatorMeasurementsQueryView>("","#6a157ba5-356b-4e32-9b56-a1ad5265412b .ag-row[role='row']@ROWINDEX [col-id='cProcessIndicator_CompareType']","",false, this.CurrentView);
 
            ProcessIndicator_ValueInterpretation = RPSControlFactory.CreateRPSGridTextBox<ProcessIndicatorMeasurementsQueryView>("","#6a157ba5-356b-4e32-9b56-a1ad5265412b .ag-row[role='row']@ROWINDEX [col-id='cProcessIndicator_ValueInterpretation']","",false, this.CurrentView);
 
            ProcessIndicator_IndicatorType = RPSControlFactory.CreateRPSGridTextBox<ProcessIndicatorMeasurementsQueryView>("","#6a157ba5-356b-4e32-9b56-a1ad5265412b .ag-row[role='row']@ROWINDEX [col-id='cProcessIndicator_IndicatorType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessIndicatorMeasurementsQueryView> Achieved { get; set; } 
        public IRPSGridTextBox<ProcessIndicatorMeasurementsQueryView> LimitValue { get; set; } 
        public IRPSGridTextBox<ProcessIndicatorMeasurementsQueryView> TargetValue { get; set; } 
        public IRPSGridTextBox<ProcessIndicatorMeasurementsQueryView> ProcessIndicator_MeasurementUnit { get; set; } 
        public IRPSGridTextBox<ProcessIndicatorMeasurementsQueryView> ProcessIndicator_CompareType { get; set; } 
        public IRPSGridTextBox<ProcessIndicatorMeasurementsQueryView> ProcessIndicator_ValueInterpretation { get; set; } 
        public IRPSGridTextBox<ProcessIndicatorMeasurementsQueryView> ProcessIndicator_IndicatorType { get; set; } 
                     
    }
 
        public partial class IndicatorMeasurementsDataCollectionEditor<ProcessIndicatorMeasurementsQueryView>:RPSCollectionEditor<ProcessIndicatorMeasurementsQueryView> where ProcessIndicatorMeasurementsQueryView : class, IView
    {
        public  IndicatorMeasurementsDataGridView<ProcessIndicatorMeasurementsQueryView> GridView {get;set;}
    }
    public partial class IndicatorMeasurementsDataGridView <ProcessIndicatorMeasurementsQueryView> :  RPSGridView<ProcessIndicatorMeasurementsQueryView> where ProcessIndicatorMeasurementsQueryView : class, IView
    {
        public IndicatorMeasurementsDataGridView(ProcessIndicatorMeasurementsQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteCommand = RPSControlFactory.CreateRPSGridButton<ProcessIndicatorMeasurementsQueryView>( "","#5d5e4880-89a7-4400-940a-94449ee6e83f .ag-row[role='row']@ROWINDEX [col-id='cDeleteCommand']","",this.CurrentView);
 
            MeasurementDate = RPSControlFactory.CreateRPSGridTextBox<ProcessIndicatorMeasurementsQueryView>("","#5d5e4880-89a7-4400-940a-94449ee6e83f .ag-row[role='row']@ROWINDEX [col-id='cMeasurementDate']","",false, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessIndicatorMeasurementsQueryView>("","#5d5e4880-89a7-4400-940a-94449ee6e83f .ag-row[role='row']@ROWINDEX [col-id='cValue']","",false, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridTextBox<ProcessIndicatorMeasurementsQueryView>("","#5d5e4880-89a7-4400-940a-94449ee6e83f .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<ProcessIndicatorMeasurementsQueryView> DeleteCommand { get; set; } 
        public IRPSGridTextBox<ProcessIndicatorMeasurementsQueryView> MeasurementDate { get; set; } 
        public IRPSGridTextBox<ProcessIndicatorMeasurementsQueryView> Value { get; set; } 
        public IRPSGridTextBox<ProcessIndicatorMeasurementsQueryView> Comments { get; set; } 
                     
    }
 
    }
  
    

}