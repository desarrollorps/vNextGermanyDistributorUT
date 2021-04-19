    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.RecalculateStructureTaskTime
{
    //RPS VERSION 1.0.0.0
    public partial class RecalculateStructureTaskTime:Screen
    {
        public RecalculateStructureTaskTime():base()
        {
            this.URL = "manufacturing.recalculatestructuretasktime";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RecalculateStructureTaskTimeQueryView  = new RecalculateStructureTaskTimeQueryView(this); 
            RecalculateStructureTaskTimeQueryView.InitializeControls(); 
           
        }
      
            public RecalculateStructureTaskTimeQueryView RecalculateStructureTaskTimeQueryView {get; set; } 
    }
            
    public partial class RecalculateStructureTaskTimeQueryView : View
    {
        public RecalculateStructureTaskTimeQueryView(RecalculateStructureTaskTime screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<RecalculateStructureTaskTimeQueryView>("12a2edd5-0dcf-435f-aa04-41eb9f44263c","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<RecalculateStructureTaskTimeQueryView>("9c941f3e-6ee7-4697-8288-2691158a80c8","","",false, this);
 
            ManufacturingOrderSituation = RPSControlFactory.CreateRPSCollectionComboBox<RecalculateStructureTaskTimeQueryView>("50378bdb-7e91-49ee-a63f-1d8e9c94f797","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<RecalculateStructureTaskTimeQueryView>("eab988c1-7643-4d11-a17c-74bb34bb16c2","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<RecalculateStructureTaskTimeQueryView>("328b5b7c-b6b2-4416-89c5-5e05a53dc3f0","","",false, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<RecalculateStructureTaskTimeQueryView>("af41800b-71c7-4125-834f-2b676481bd88","","",false, this);
 
            DateFrom1 = RPSControlFactory.CreateRPSTextBox<RecalculateStructureTaskTimeQueryView>("e9f6f48c-d565-48e9-b957-724efc0c89bb","","",false, this);
 
            ExecutionTimeCalcValue = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateStructureTaskTimeQueryView>("8b17892e-3cf9-4501-b361-c70ea3eddfc9","","",false, this);
 
            PreparationTimeCalcValue = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateStructureTaskTimeQueryView>("017b5025-dfc7-4f7d-91cf-bbf286c077c4","","",false, this);
 
            ExecutionLot = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateStructureTaskTimeQueryView>("b5fd4671-62ce-4be6-9f4a-b03a30b5bd51","","",false, this);
 
            Version1 = RPSControlFactory.CreateRPSTextBox<RecalculateStructureTaskTimeQueryView>("9c5801e3-d0a8-43e7-bf61-4b458d9ba19c","","",false, this);
 
            DateFrom2 = RPSControlFactory.CreateRPSTextBox<RecalculateStructureTaskTimeQueryView>("75e59319-a8a8-47b5-8204-34cf6a169d0e","","",false, this);
 
            ExecutionTimeCalcValue1 = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateStructureTaskTimeQueryView>("5537abed-0d01-4845-b15b-cc14a19eb107","","",false, this);
 
            PreparationTimeCalcValue1 = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateStructureTaskTimeQueryView>("6766f90e-f7ca-4146-a994-7ac86232d7e5","","",false, this);
 
            ExecutionLot1 = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateStructureTaskTimeQueryView>("44f0bc68-f438-4731-b90b-a658557fb4e3","","",false, this);
 
            ExecuteUpdateStructureTaskTimes = RPSControlFactory.CreateRPSButton<RecalculateStructureTaskTimeQueryView>( "e1ae989d-a240-4a56-aa82-960cde4be83a","","",this);
 
            SaveCommandCommandButton = RPSControlFactory.CreateRPSButton<RecalculateStructureTaskTimeQueryView>( "ced6b161-b084-4909-b025-b0e397f7f1f6","","",this);
 

        }
        public IRPSComboBox<RecalculateStructureTaskTimeQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<RecalculateStructureTaskTimeQueryView> Article { get; set; } 
        public IRPSCollectionComboBox<RecalculateStructureTaskTimeQueryView> ManufacturingOrderSituation { get; set; } 
        public IRPSTextBox<RecalculateStructureTaskTimeQueryView> DateFrom { get; set; } 
        public IRPSTextBox<RecalculateStructureTaskTimeQueryView> DateTo { get; set; } 
        public IRPSTextBox<RecalculateStructureTaskTimeQueryView> Version { get; set; } 
        public IRPSTextBox<RecalculateStructureTaskTimeQueryView> DateFrom1 { get; set; } 
        public IRPSTextBox<RecalculateStructureTaskTimeQueryView> ExecutionTimeCalcValue { get; set; } 
        public IRPSTextBox<RecalculateStructureTaskTimeQueryView> PreparationTimeCalcValue { get; set; } 
        public IRPSTextBox<RecalculateStructureTaskTimeQueryView> ExecutionLot { get; set; } 
        public IRPSTextBox<RecalculateStructureTaskTimeQueryView> Version1 { get; set; } 
        public IRPSTextBox<RecalculateStructureTaskTimeQueryView> DateFrom2 { get; set; } 
        public IRPSTextBox<RecalculateStructureTaskTimeQueryView> ExecutionTimeCalcValue1 { get; set; } 
        public IRPSTextBox<RecalculateStructureTaskTimeQueryView> PreparationTimeCalcValue1 { get; set; } 
        public IRPSTextBox<RecalculateStructureTaskTimeQueryView> ExecutionLot1 { get; set; } 
        public IRPSButton<RecalculateStructureTaskTimeQueryView> ExecuteUpdateStructureTaskTimes { get; set; } 
        public IRPSButton<RecalculateStructureTaskTimeQueryView> SaveCommandCommandButton { get; set; } 
        public RecalculateStructureTaskTime Screen { get; set; }
        public RecalculateStructureTaskTimeQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}