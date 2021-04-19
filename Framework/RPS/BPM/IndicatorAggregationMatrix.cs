    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.IndicatorAggregationMatrix
{
    //RPS VERSION 1.0.0.0
    public partial class IndicatorAggregationMatrix:Screen
    {
        public IndicatorAggregationMatrix():base()
        {
            this.URL = "bpm.indicatoraggregationmatrix";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            IndicatorAggregationMatrixCollectionView  = new IndicatorAggregationMatrixCollectionView(this); 
            IndicatorAggregationMatrixEntityView  = new IndicatorAggregationMatrixEntityView(this); 
            IndicatorAggregationMatrixCollectionView.InitializeControls(); 
            IndicatorAggregationMatrixEntityView.InitializeControls(); 
           
        }
      
            public IndicatorAggregationMatrixCollectionView IndicatorAggregationMatrixCollectionView {get; set; } 
            public IndicatorAggregationMatrixEntityView IndicatorAggregationMatrixEntityView {get; set; } 
    }
            
    public partial class IndicatorAggregationMatrixCollectionView : View
    {
        public IndicatorAggregationMatrixCollectionView(IndicatorAggregationMatrix screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<IndicatorAggregationMatrixCollectionView,IndicatorAggregationMatrixEntityView>( this,Screen.IndicatorAggregationMatrixEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "91524e28-9c53-45dc-95a4-fc6c2a0248ca",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<IndicatorAggregationMatrixCollectionView,IndicatorAggregationMatrixEntityView>( params_MainConsult,this,Screen.IndicatorAggregationMatrixEntityView);
 

        }
        public IRPSButton<IndicatorAggregationMatrixCollectionView,IndicatorAggregationMatrixEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<IndicatorAggregationMatrixCollectionView,IndicatorAggregationMatrixEntityView> MainConsult { get; set; } 
        public IndicatorAggregationMatrix Screen { get; set; }
        public IndicatorAggregationMatrixCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class IndicatorAggregationMatrixEntityView : View
    {
        public IndicatorAggregationMatrixEntityView(IndicatorAggregationMatrix screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<IndicatorAggregationMatrixEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<IndicatorAggregationMatrixEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<IndicatorAggregationMatrixEntityView,IndicatorAggregationMatrixCollectionView>( this,Screen.IndicatorAggregationMatrixCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<IndicatorAggregationMatrixEntityView,IndicatorAggregationMatrixCollectionView>( this,Screen.IndicatorAggregationMatrixCollectionView);
 
            CodAggregationMatrix = RPSControlFactory.CreateRPSTextBox<IndicatorAggregationMatrixEntityView>("41bd4b44-f43d-4f30-aa0f-3766dd3d237f","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<IndicatorAggregationMatrixEntityView>("d6394c46-3219-4e4c-ac5a-cd6c52eca8e6","","",true, this);
 
            OnTargetPositive = RPSControlFactory.CreateRPSFormattedTextBox<IndicatorAggregationMatrixEntityView>("8a00cfbc-91ea-4b94-b09b-7407c30e6a9b","","",true, this);
 
            OnTargetSustained = RPSControlFactory.CreateRPSFormattedTextBox<IndicatorAggregationMatrixEntityView>("0dfb667e-6c87-4981-a1a6-1156dc2fb035","","",true, this);
 
            OnTargetNegative = RPSControlFactory.CreateRPSFormattedTextBox<IndicatorAggregationMatrixEntityView>("bad1e3dd-8fae-40e8-9af1-68401bb229ea","","",true, this);
 
            WithinLimitsPositive = RPSControlFactory.CreateRPSFormattedTextBox<IndicatorAggregationMatrixEntityView>("41f0cc4d-9680-4abf-8c1e-0f83eb64e002","","",true, this);
 
            WithinLimitsSustained = RPSControlFactory.CreateRPSFormattedTextBox<IndicatorAggregationMatrixEntityView>("9c601ebc-a074-40f0-9010-80a690bee049","","",true, this);
 
            WithinLimitsNegative = RPSControlFactory.CreateRPSFormattedTextBox<IndicatorAggregationMatrixEntityView>("ff43f27d-766f-484e-b396-419654911c58","","",true, this);
 
            OffLimitsPositive = RPSControlFactory.CreateRPSFormattedTextBox<IndicatorAggregationMatrixEntityView>("00e50628-c8bf-4a34-9b97-36902a6ef899","","",true, this);
 
            OffLimitsSustained = RPSControlFactory.CreateRPSFormattedTextBox<IndicatorAggregationMatrixEntityView>("dd222eae-48db-406c-bb53-65afc4df8eff","","",true, this);
 
            OffLimitsNegative = RPSControlFactory.CreateRPSFormattedTextBox<IndicatorAggregationMatrixEntityView>("94ae490d-8974-45b4-8ea7-4c0f9e64008b","","",true, this);
 
            VeryHighWeight = RPSControlFactory.CreateRPSFormattedTextBox<IndicatorAggregationMatrixEntityView>("54f1993d-2b55-4779-b2aa-c548feeea78d","","",true, this);
 
            HighWeight = RPSControlFactory.CreateRPSFormattedTextBox<IndicatorAggregationMatrixEntityView>("a7aa2737-7c43-4396-b081-ae40396ba89d","","",true, this);
 
            MediumWeight = RPSControlFactory.CreateRPSFormattedTextBox<IndicatorAggregationMatrixEntityView>("ee97e1f0-9107-47e0-a940-550f6f65b587","","",true, this);
 
            LowWeight = RPSControlFactory.CreateRPSFormattedTextBox<IndicatorAggregationMatrixEntityView>("f0b7798d-0e5f-4444-a731-f1517daa68ae","","",true, this);
 

        }
        public IRPSSaveButton<IndicatorAggregationMatrixEntityView> SaveButton { get; set; } 
        public IRPSButton<IndicatorAggregationMatrixEntityView> DeleteButton { get; set; } 
        public IRPSButton<IndicatorAggregationMatrixEntityView,IndicatorAggregationMatrixCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<IndicatorAggregationMatrixEntityView,IndicatorAggregationMatrixCollectionView> BackButton { get; set; } 
        public IRPSTextBox<IndicatorAggregationMatrixEntityView> CodAggregationMatrix { get; set; } 
        public IRPSTextBox<IndicatorAggregationMatrixEntityView> Description { get; set; } 
        public IRPSTextBox<IndicatorAggregationMatrixEntityView> OnTargetPositive { get; set; } 
        public IRPSTextBox<IndicatorAggregationMatrixEntityView> OnTargetSustained { get; set; } 
        public IRPSTextBox<IndicatorAggregationMatrixEntityView> OnTargetNegative { get; set; } 
        public IRPSTextBox<IndicatorAggregationMatrixEntityView> WithinLimitsPositive { get; set; } 
        public IRPSTextBox<IndicatorAggregationMatrixEntityView> WithinLimitsSustained { get; set; } 
        public IRPSTextBox<IndicatorAggregationMatrixEntityView> WithinLimitsNegative { get; set; } 
        public IRPSTextBox<IndicatorAggregationMatrixEntityView> OffLimitsPositive { get; set; } 
        public IRPSTextBox<IndicatorAggregationMatrixEntityView> OffLimitsSustained { get; set; } 
        public IRPSTextBox<IndicatorAggregationMatrixEntityView> OffLimitsNegative { get; set; } 
        public IRPSTextBox<IndicatorAggregationMatrixEntityView> VeryHighWeight { get; set; } 
        public IRPSTextBox<IndicatorAggregationMatrixEntityView> HighWeight { get; set; } 
        public IRPSTextBox<IndicatorAggregationMatrixEntityView> MediumWeight { get; set; } 
        public IRPSTextBox<IndicatorAggregationMatrixEntityView> LowWeight { get; set; } 
        public IndicatorAggregationMatrix Screen { get; set; }
        public IndicatorAggregationMatrixEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}