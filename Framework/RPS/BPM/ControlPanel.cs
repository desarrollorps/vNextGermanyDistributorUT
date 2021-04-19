    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.ControlPanel
{
    //RPS VERSION 1.0.0.0
    public partial class ControlPanel:Screen
    {
        public ControlPanel():base()
        {
            this.URL = "bpm.controlpanel";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ControlPanelQueryView  = new ControlPanelQueryView(this); 
            ControlPanelQueryView.InitializeControls(); 
           
        }
      
            public ControlPanelQueryView ControlPanelQueryView {get; set; } 
    }
            
    public partial class ControlPanelQueryView : View
    {
        public ControlPanelQueryView(ControlPanel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDStrategicPlan = RPSControlFactory.CreateRPSComboBox<ControlPanelQueryView>("a7684cba-0792-4091-92c9-2230600841c3","","",false, this);
 
            IDStrategicIndicatorGroup = RPSControlFactory.CreateRPSCollectionComboBox<ControlPanelQueryView>("3a2367be-962a-4f14-96df-795f9239a219","","",false, this);
 
            MeasurementResponsible = RPSControlFactory.CreateRPSCollectionComboBox<ControlPanelQueryView>("d266f042-a49d-43f0-a9c7-c0b164fec86b","","",false, this);
 
            ControlResponsible = RPSControlFactory.CreateRPSCollectionComboBox<ControlPanelQueryView>("80bb4cfc-02e0-486b-8a6d-c03759af13fc","","",false, this);
 
            Achieved = RPSControlFactory.CreateRPSFormattedTextBox<ControlPanelQueryView>("d47a884e-2298-412c-92d4-2ca02edc2388","","",false, this);
 
            AchievedPercent = RPSControlFactory.CreateRPSFormattedTextBox<ControlPanelQueryView>("07ea115c-2afb-4580-9e81-d3c7fd4c45cf","","",false, this);
 
            LimitValue = RPSControlFactory.CreateRPSFormattedTextBox<ControlPanelQueryView>("fedaa0f4-74b6-4316-8dac-5cdea4bc2e14","","",false, this);
 
            TargetValue = RPSControlFactory.CreateRPSFormattedTextBox<ControlPanelQueryView>("cc5a3272-617d-4f8e-a837-5d169d5e01d3","","",false, this);
 
            MeasurementUnit = RPSControlFactory.CreateRPSTextBox<ControlPanelQueryView>("ae633ae3-7482-4a34-9471-ec4ca83ac397","","",false, this);
 
            CollectionInit params_ControlPanelQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bdb56ab2-e074-4ef4-9faa-23c88aeb93cd",CSSSelectorGrid="",XPathGrid=""};
            ControlPanelQuery = RPSControlFactory.RPSCreateCollectionWithGrid<ControlPanelQueryCollectionEditor<ControlPanelQueryView>,ControlPanelQueryView>( params_ControlPanelQuery,this);
 
            CollectionInit params_GetIndicatorMeasurementQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="41e35bbd-3f09-4274-916f-fb0a1f1b23e4",CSSSelectorGrid="",XPathGrid=""};
            GetIndicatorMeasurementQuery = RPSControlFactory.RPSCreateCollectionWithGrid<GetIndicatorMeasurementQueryCollectionEditor<ControlPanelQueryView>,ControlPanelQueryView>( params_GetIndicatorMeasurementQuery,this);
 

        }
        public IRPSComboBox<ControlPanelQueryView> IDStrategicPlan { get; set; } 
        public IRPSCollectionComboBox<ControlPanelQueryView> IDStrategicIndicatorGroup { get; set; } 
        public IRPSCollectionComboBox<ControlPanelQueryView> MeasurementResponsible { get; set; } 
        public IRPSCollectionComboBox<ControlPanelQueryView> ControlResponsible { get; set; } 
        public IRPSTextBox<ControlPanelQueryView> Achieved { get; set; } 
        public IRPSTextBox<ControlPanelQueryView> AchievedPercent { get; set; } 
        public IRPSTextBox<ControlPanelQueryView> LimitValue { get; set; } 
        public IRPSTextBox<ControlPanelQueryView> TargetValue { get; set; } 
        public IRPSTextBox<ControlPanelQueryView> MeasurementUnit { get; set; } 
        public ControlPanelQueryCollectionEditor<ControlPanelQueryView> ControlPanelQuery { get; set; } 
        public GetIndicatorMeasurementQueryCollectionEditor<ControlPanelQueryView> GetIndicatorMeasurementQuery { get; set; } 
        public ControlPanel Screen { get; set; }
        public ControlPanelQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ControlPanelQueryCollectionEditor<ControlPanelQueryView>:RPSCollectionEditor<ControlPanelQueryView> where ControlPanelQueryView : class, IView
    {
        public  ControlPanelQueryGridView<ControlPanelQueryView> GridView {get;set;}
    }
    public partial class ControlPanelQueryGridView <ControlPanelQueryView> :  RPSGridView<ControlPanelQueryView> where ControlPanelQueryView : class, IView
    {
        public ControlPanelQueryGridView(ControlPanelQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TargetValue = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlPanelQueryView>("","#bdb56ab2-e074-4ef4-9faa-23c88aeb93cd .ag-row[role='row']@ROWINDEX [col-id='cTargetValue']","",false, this.CurrentView);
 
            Achieved = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlPanelQueryView>("","#bdb56ab2-e074-4ef4-9faa-23c88aeb93cd .ag-row[role='row']@ROWINDEX [col-id='cAchieved']","",false, this.CurrentView);
 
            AchievedPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlPanelQueryView>("","#bdb56ab2-e074-4ef4-9faa-23c88aeb93cd .ag-row[role='row']@ROWINDEX [col-id='cAchievedPercent']","",false, this.CurrentView);
 
            LimitValue = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlPanelQueryView>("","#bdb56ab2-e074-4ef4-9faa-23c88aeb93cd .ag-row[role='row']@ROWINDEX [col-id='cLimitValue']","",false, this.CurrentView);
 
            MeasurementUnit = RPSControlFactory.CreateRPSGridTextBox<ControlPanelQueryView>("","#bdb56ab2-e074-4ef4-9faa-23c88aeb93cd .ag-row[role='row']@ROWINDEX [col-id='cMeasurementUnit']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ControlPanelQueryView> TargetValue { get; set; } 
        public IRPSGridTextBox<ControlPanelQueryView> Achieved { get; set; } 
        public IRPSGridTextBox<ControlPanelQueryView> AchievedPercent { get; set; } 
        public IRPSGridTextBox<ControlPanelQueryView> LimitValue { get; set; } 
        public IRPSGridTextBox<ControlPanelQueryView> MeasurementUnit { get; set; } 
                     
    }
 
        public partial class GetIndicatorMeasurementQueryCollectionEditor<ControlPanelQueryView>:RPSCollectionEditor<ControlPanelQueryView> where ControlPanelQueryView : class, IView
    {
        public  GetIndicatorMeasurementQueryGridView<ControlPanelQueryView> GridView {get;set;}
    }
    public partial class GetIndicatorMeasurementQueryGridView <ControlPanelQueryView> :  RPSGridView<ControlPanelQueryView> where ControlPanelQueryView : class, IView
    {
        public GetIndicatorMeasurementQueryGridView(ControlPanelQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MeasurementDate = RPSControlFactory.CreateRPSGridTextBox<ControlPanelQueryView>("","#41e35bbd-3f09-4274-916f-fb0a1f1b23e4 .ag-row[role='row']@ROWINDEX [col-id='cMeasurementDate']","",false, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlPanelQueryView>("","#41e35bbd-3f09-4274-916f-fb0a1f1b23e4 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",false, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridTextBox<ControlPanelQueryView>("","#41e35bbd-3f09-4274-916f-fb0a1f1b23e4 .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ControlPanelQueryView> MeasurementDate { get; set; } 
        public IRPSGridTextBox<ControlPanelQueryView> Value { get; set; } 
        public IRPSGridTextBox<ControlPanelQueryView> Comments { get; set; } 
                     
    }
 
    }
  
    

}