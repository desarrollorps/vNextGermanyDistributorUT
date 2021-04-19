    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.StrategicIndicatorRegistry
{
    //RPS VERSION 1.0.0.0
    public partial class StrategicIndicatorRegistry:Screen
    {
        public StrategicIndicatorRegistry():base()
        {
            this.URL = "bpm.strategicindicatorregistry";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StrategicIndicatorRegistryQueryView  = new StrategicIndicatorRegistryQueryView(this); 
            StrategicIndicatorRegistryQueryView.InitializeControls(); 
           
        }
      
            public StrategicIndicatorRegistryQueryView StrategicIndicatorRegistryQueryView {get; set; } 
    }
            
    public partial class StrategicIndicatorRegistryQueryView : View
    {
        public StrategicIndicatorRegistryQueryView(StrategicIndicatorRegistry screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIStrategicPlan = RPSControlFactory.CreateRPSComboBox<StrategicIndicatorRegistryQueryView>("0b91678e-53e6-4f28-a6f8-95cc052fa2e2","","",false, this);
 
            UIStrategicIndicator = RPSControlFactory.CreateRPSComboBox<StrategicIndicatorRegistryQueryView>("0b2c0555-2212-4a89-b8e2-6f3f124a3c77","","",false, this);
 
            UIOptAllData = RPSControlFactory.CreateRPSOption<StrategicIndicatorRegistryQueryView>( "d45be087-ebbf-41b6-b702-7a5a480cdab6","","",this);
 
            UIOptByDates = RPSControlFactory.CreateRPSOption<StrategicIndicatorRegistryQueryView>( "64d13df6-5881-4046-9df9-d6e4f6aa3186","","",this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<StrategicIndicatorRegistryQueryView>("13875079-b2fe-4608-9e6b-cd70ae9a3964","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<StrategicIndicatorRegistryQueryView>("b207fd62-0497-4a50-8bbc-aeb01a78bc0d","","",false, this);
 
            UIOptLastValues = RPSControlFactory.CreateRPSOption<StrategicIndicatorRegistryQueryView>( "261c286b-bbf8-4ee8-a3dc-2273ccd53fd8","","",this);
 
            UILastItems = RPSControlFactory.CreateRPSFormattedTextBox<StrategicIndicatorRegistryQueryView>("c8c7d497-2249-4fa1-800a-e3e147299438","","",false, this);
 
            StrategicIndicatorPeriod_Achieved = RPSControlFactory.CreateRPSFormattedTextBox<StrategicIndicatorRegistryQueryView>("a0edf572-233d-4d40-87dd-8d7e72ccfdc5","","",false, this);
 
            StrategicIndicatorPeriod_LimitValue = RPSControlFactory.CreateRPSFormattedTextBox<StrategicIndicatorRegistryQueryView>("7c34a00a-1ec6-4be1-bf49-9d39a4a5a5a5","","",false, this);
 
            StrategicIndicatorPeriod_TargetValue = RPSControlFactory.CreateRPSFormattedTextBox<StrategicIndicatorRegistryQueryView>("3b1e9480-0045-44c6-a619-10dc57c11c5a","","",false, this);
 
            StrategicIndicator_MeasurementUnit = RPSControlFactory.CreateRPSTextBox<StrategicIndicatorRegistryQueryView>("0c4cf3f4-2074-41de-aea1-af221627c3a7","","",false, this);
 
            StrategicIndicator_CompareType = RPSControlFactory.CreateRPSTextBox<StrategicIndicatorRegistryQueryView>("4eeb5584-07fb-46ef-a8dd-3ef5105bb7a9","","",false, this);
 
            StrategicIndicator_ValueInterpretation = RPSControlFactory.CreateRPSTextBox<StrategicIndicatorRegistryQueryView>("9b7c20eb-f5ba-469d-8ace-7cc290fd7b99","","",false, this);
 
            StrategicIndicator_IndicatorType = RPSControlFactory.CreateRPSTextBox<StrategicIndicatorRegistryQueryView>("ba78a8d6-e7a2-4d8b-9646-9ae783c357ce","","",false, this);
 
            NewCommand = RPSControlFactory.CreateRPSButton<StrategicIndicatorRegistryQueryView>( "6b26da16-a089-4238-a27f-47abccfc2233","","",this);
 
            SaveCommand = RPSControlFactory.CreateRPSButton<StrategicIndicatorRegistryQueryView>( "82b0ac2b-30eb-4ac9-9317-2357f698ae46","","",this);
 
            CollectionInit params_StrategicIndicatorRegistry = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="683cd314-2dd7-48d1-bfad-085a44ab33ef",CSSSelectorGrid="",XPathGrid=""};
            StrategicIndicatorRegistry = RPSControlFactory.RPSCreateCollectionWithGrid<StrategicIndicatorRegistryCollectionEditor<StrategicIndicatorRegistryQueryView>,StrategicIndicatorRegistryQueryView>( params_StrategicIndicatorRegistry,this);
 
            CollectionInit params_IndicatorMeasurements = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e22cf0a7-a1bc-4598-9e23-8ac965fe903d",CSSSelectorGrid="",XPathGrid=""};
            IndicatorMeasurements = RPSControlFactory.RPSCreateCollectionWithGrid<IndicatorMeasurementsCollectionEditor<StrategicIndicatorRegistryQueryView>,StrategicIndicatorRegistryQueryView>( params_IndicatorMeasurements,this);
 

        }
        public IRPSComboBox<StrategicIndicatorRegistryQueryView> UIStrategicPlan { get; set; } 
        public IRPSComboBox<StrategicIndicatorRegistryQueryView> UIStrategicIndicator { get; set; } 
        public IRPSOption<StrategicIndicatorRegistryQueryView> UIOptAllData { get; set; } 
        public IRPSOption<StrategicIndicatorRegistryQueryView> UIOptByDates { get; set; } 
        public IRPSTextBox<StrategicIndicatorRegistryQueryView> UIDateFrom { get; set; } 
        public IRPSTextBox<StrategicIndicatorRegistryQueryView> UIDateTo { get; set; } 
        public IRPSOption<StrategicIndicatorRegistryQueryView> UIOptLastValues { get; set; } 
        public IRPSTextBox<StrategicIndicatorRegistryQueryView> UILastItems { get; set; } 
        public IRPSTextBox<StrategicIndicatorRegistryQueryView> StrategicIndicatorPeriod_Achieved { get; set; } 
        public IRPSTextBox<StrategicIndicatorRegistryQueryView> StrategicIndicatorPeriod_LimitValue { get; set; } 
        public IRPSTextBox<StrategicIndicatorRegistryQueryView> StrategicIndicatorPeriod_TargetValue { get; set; } 
        public IRPSTextBox<StrategicIndicatorRegistryQueryView> StrategicIndicator_MeasurementUnit { get; set; } 
        public IRPSTextBox<StrategicIndicatorRegistryQueryView> StrategicIndicator_CompareType { get; set; } 
        public IRPSTextBox<StrategicIndicatorRegistryQueryView> StrategicIndicator_ValueInterpretation { get; set; } 
        public IRPSTextBox<StrategicIndicatorRegistryQueryView> StrategicIndicator_IndicatorType { get; set; } 
        public IRPSButton<StrategicIndicatorRegistryQueryView> NewCommand { get; set; } 
        public IRPSButton<StrategicIndicatorRegistryQueryView> SaveCommand { get; set; } 
        public StrategicIndicatorRegistryCollectionEditor<StrategicIndicatorRegistryQueryView> StrategicIndicatorRegistry { get; set; } 
        public IndicatorMeasurementsCollectionEditor<StrategicIndicatorRegistryQueryView> IndicatorMeasurements { get; set; } 
        public StrategicIndicatorRegistry Screen { get; set; }
        public StrategicIndicatorRegistryQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class StrategicIndicatorRegistryCollectionEditor<StrategicIndicatorRegistryQueryView>:RPSCollectionEditor<StrategicIndicatorRegistryQueryView> where StrategicIndicatorRegistryQueryView : class, IView
    {
        public  StrategicIndicatorRegistryGridView<StrategicIndicatorRegistryQueryView> GridView {get;set;}
    }
    public partial class StrategicIndicatorRegistryGridView <StrategicIndicatorRegistryQueryView> :  RPSGridView<StrategicIndicatorRegistryQueryView> where StrategicIndicatorRegistryQueryView : class, IView
    {
        public StrategicIndicatorRegistryGridView(StrategicIndicatorRegistryQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StrategicIndicatorPeriod_Achieved = RPSControlFactory.CreateRPSGridFormattedTextBox<StrategicIndicatorRegistryQueryView>("","#683cd314-2dd7-48d1-bfad-085a44ab33ef .ag-row[role='row']@ROWINDEX [col-id='cStrategicIndicatorPeriod_Achieved']","",false, this.CurrentView);
 
            StrategicIndicatorPeriod_LimitValue = RPSControlFactory.CreateRPSGridFormattedTextBox<StrategicIndicatorRegistryQueryView>("","#683cd314-2dd7-48d1-bfad-085a44ab33ef .ag-row[role='row']@ROWINDEX [col-id='cStrategicIndicatorPeriod_LimitValue']","",false, this.CurrentView);
 
            StrategicIndicatorPeriod_TargetValue = RPSControlFactory.CreateRPSGridFormattedTextBox<StrategicIndicatorRegistryQueryView>("","#683cd314-2dd7-48d1-bfad-085a44ab33ef .ag-row[role='row']@ROWINDEX [col-id='cStrategicIndicatorPeriod_TargetValue']","",false, this.CurrentView);
 
            StrategicIndicator_MeasurementUnit = RPSControlFactory.CreateRPSGridTextBox<StrategicIndicatorRegistryQueryView>("","#683cd314-2dd7-48d1-bfad-085a44ab33ef .ag-row[role='row']@ROWINDEX [col-id='cStrategicIndicator_MeasurementUnit']","",false, this.CurrentView);
 
            StrategicIndicator_CompareType = RPSControlFactory.CreateRPSGridTextBox<StrategicIndicatorRegistryQueryView>("","#683cd314-2dd7-48d1-bfad-085a44ab33ef .ag-row[role='row']@ROWINDEX [col-id='cStrategicIndicator_CompareType']","",false, this.CurrentView);
 
            StrategicIndicator_ValueInterpretation = RPSControlFactory.CreateRPSGridTextBox<StrategicIndicatorRegistryQueryView>("","#683cd314-2dd7-48d1-bfad-085a44ab33ef .ag-row[role='row']@ROWINDEX [col-id='cStrategicIndicator_ValueInterpretation']","",false, this.CurrentView);
 
            StrategicIndicator_IndicatorType = RPSControlFactory.CreateRPSGridTextBox<StrategicIndicatorRegistryQueryView>("","#683cd314-2dd7-48d1-bfad-085a44ab33ef .ag-row[role='row']@ROWINDEX [col-id='cStrategicIndicator_IndicatorType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StrategicIndicatorRegistryQueryView> StrategicIndicatorPeriod_Achieved { get; set; } 
        public IRPSGridTextBox<StrategicIndicatorRegistryQueryView> StrategicIndicatorPeriod_LimitValue { get; set; } 
        public IRPSGridTextBox<StrategicIndicatorRegistryQueryView> StrategicIndicatorPeriod_TargetValue { get; set; } 
        public IRPSGridTextBox<StrategicIndicatorRegistryQueryView> StrategicIndicator_MeasurementUnit { get; set; } 
        public IRPSGridTextBox<StrategicIndicatorRegistryQueryView> StrategicIndicator_CompareType { get; set; } 
        public IRPSGridTextBox<StrategicIndicatorRegistryQueryView> StrategicIndicator_ValueInterpretation { get; set; } 
        public IRPSGridTextBox<StrategicIndicatorRegistryQueryView> StrategicIndicator_IndicatorType { get; set; } 
                     
    }
 
        public partial class IndicatorMeasurementsCollectionEditor<StrategicIndicatorRegistryQueryView>:RPSCollectionEditor<StrategicIndicatorRegistryQueryView> where StrategicIndicatorRegistryQueryView : class, IView
    {
        public  IndicatorMeasurementsGridView<StrategicIndicatorRegistryQueryView> GridView {get;set;}
    }
    public partial class IndicatorMeasurementsGridView <StrategicIndicatorRegistryQueryView> :  RPSGridView<StrategicIndicatorRegistryQueryView> where StrategicIndicatorRegistryQueryView : class, IView
    {
        public IndicatorMeasurementsGridView(StrategicIndicatorRegistryQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteCommand = RPSControlFactory.CreateRPSGridButton<StrategicIndicatorRegistryQueryView>( "","#e22cf0a7-a1bc-4598-9e23-8ac965fe903d .ag-row[role='row']@ROWINDEX [col-id='cDeleteCommand']","",this.CurrentView);
 
            MeasurementDate = RPSControlFactory.CreateRPSGridTextBox<StrategicIndicatorRegistryQueryView>("","#e22cf0a7-a1bc-4598-9e23-8ac965fe903d .ag-row[role='row']@ROWINDEX [col-id='cMeasurementDate']","",false, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<StrategicIndicatorRegistryQueryView>("","#e22cf0a7-a1bc-4598-9e23-8ac965fe903d .ag-row[role='row']@ROWINDEX [col-id='cValue']","",false, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<StrategicIndicatorRegistryQueryView>("","#e22cf0a7-a1bc-4598-9e23-8ac965fe903d .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<StrategicIndicatorRegistryQueryView> DeleteCommand { get; set; } 
        public IRPSGridTextBox<StrategicIndicatorRegistryQueryView> MeasurementDate { get; set; } 
        public IRPSGridTextBox<StrategicIndicatorRegistryQueryView> Value { get; set; } 
        public IRPSGridTextBox<StrategicIndicatorRegistryQueryView> Comments { get; set; } 
                     
    }
 
    }
  
    

}