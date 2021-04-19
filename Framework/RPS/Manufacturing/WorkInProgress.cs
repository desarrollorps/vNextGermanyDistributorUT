    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.WorkInProgress
{
    //RPS VERSION 1.0.0.0
    public partial class WorkInProgress:Screen
    {
        public WorkInProgress():base()
        {
            this.URL = "manufacturing.workinprogress";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            WorkInProgressQueryView  = new WorkInProgressQueryView(this); 
            WorkInProgressQueryView.InitializeControls(); 
           
        }
      
            public WorkInProgressQueryView WorkInProgressQueryView {get; set; } 
    }
            
    public partial class WorkInProgressQueryView : View
    {
        public WorkInProgressQueryView(WorkInProgress screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<WorkInProgressQueryView>("5f53002d-60a7-43be-aad7-99b744327d2f","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<WorkInProgressQueryView>("95c4c1d1-f5d4-4115-a95a-1f1cb2b1b62b","","",false, this);
 
            ManufacturingOrderSituation = RPSControlFactory.CreateRPSCollectionComboBox<WorkInProgressQueryView>("bf0011bd-bdec-44c8-9803-aa1bbb087a1c","","",false, this);
 
            Historic = RPSControlFactory.CreateRPSCheckBox<WorkInProgressQueryView>("3b4d51e9-e1cf-4f79-a487-e119fff362ff","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<WorkInProgressQueryView>("96b7b673-b0af-43ff-8fce-dbbe060753af","","",false, this);
 
            TaskNotStarted = RPSControlFactory.CreateRPSCheckBox<WorkInProgressQueryView>("2f220aa9-8bfc-49d1-b783-8e55609e9fec","","",false, this);
 
            TaskInProgress = RPSControlFactory.CreateRPSCheckBox<WorkInProgressQueryView>("ee914742-b334-4360-9839-ac796e458a2c","","",false, this);
 
            TaskFinished = RPSControlFactory.CreateRPSCheckBox<WorkInProgressQueryView>("a983c71a-044a-4dcd-aeed-e666357252df","","",false, this);
 
            PlannedStartDate = RPSControlFactory.CreateRPSTextBox<WorkInProgressQueryView>("bb1e3e2d-9b83-4be1-91ef-b6e9322f9eac","","",false, this);
 
            PlannedEndDate = RPSControlFactory.CreateRPSTextBox<WorkInProgressQueryView>("c4aafefe-9365-4975-8eb9-934f56863f3a","","",false, this);
 
            ManualEndDate = RPSControlFactory.CreateRPSTextBox<WorkInProgressQueryView>("54e99686-78e6-4053-8a3c-9b658d497967","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<WorkInProgressQueryView>("db82678b-c8d1-4514-859b-2f7caf86c2d9","","",false, this);
 
            PlannedStartDate1 = RPSControlFactory.CreateRPSTextBox<WorkInProgressQueryView>("3207f706-c4ca-4f3c-8f1c-2bc4af8c791f","","",false, this);
 
            PlannedEndDate1 = RPSControlFactory.CreateRPSTextBox<WorkInProgressQueryView>("080499a8-0d4b-4189-bd91-d102a5f1ad7c","","",false, this);
 
            AcceptedDate = RPSControlFactory.CreateRPSTextBox<WorkInProgressQueryView>("41326727-759f-472f-84e6-6a290df155d8","","",false, this);
 
            RealEndDate = RPSControlFactory.CreateRPSTextBox<WorkInProgressQueryView>("345b9fa2-991f-47e4-8c4e-28c0fe7d3cf5","","",false, this);
 
            ChildNumber = RPSControlFactory.CreateRPSFormattedTextBox<WorkInProgressQueryView>("aefeeef6-4def-4a3f-93b0-6936c54842f7","","",false, this);
 
            TaskCountDone = RPSControlFactory.CreateRPSFormattedTextBox<WorkInProgressQueryView>("78846981-e6fc-4c7b-9e11-6574e2bd4fd8","","",false, this);
 
            PlannedEndMRPDate = RPSControlFactory.CreateRPSTextBox<WorkInProgressQueryView>("a53d5f21-b3ad-4b1e-bb56-421e5dce11eb","","",false, this);
 
            Canceled = RPSControlFactory.CreateRPSCheckBox<WorkInProgressQueryView>("44d0019f-fe1c-4148-8f77-f274700222d8","","",false, this);
 
            PlannedStartDate2 = RPSControlFactory.CreateRPSTextBox<WorkInProgressQueryView>("ac87b597-1bb0-4423-813e-598696a434f6","","",false, this);
 
            PlannedEndDate2 = RPSControlFactory.CreateRPSTextBox<WorkInProgressQueryView>("d83e54bf-0301-4033-84a8-be652df3db9e","","",false, this);
 

        }
        public IRPSComboBox<WorkInProgressQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<WorkInProgressQueryView> ManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<WorkInProgressQueryView> ManufacturingOrderSituation { get; set; } 
        public IRPSCheckbox<WorkInProgressQueryView> Historic { get; set; } 
        public IRPSCollectionComboBox<WorkInProgressQueryView> Project { get; set; } 
        public IRPSCheckbox<WorkInProgressQueryView> TaskNotStarted { get; set; } 
        public IRPSCheckbox<WorkInProgressQueryView> TaskInProgress { get; set; } 
        public IRPSCheckbox<WorkInProgressQueryView> TaskFinished { get; set; } 
        public IRPSTextBox<WorkInProgressQueryView> PlannedStartDate { get; set; } 
        public IRPSTextBox<WorkInProgressQueryView> PlannedEndDate { get; set; } 
        public IRPSTextBox<WorkInProgressQueryView> ManualEndDate { get; set; } 
        public IRPSTextBox<WorkInProgressQueryView> InternalCode { get; set; } 
        public IRPSTextBox<WorkInProgressQueryView> PlannedStartDate1 { get; set; } 
        public IRPSTextBox<WorkInProgressQueryView> PlannedEndDate1 { get; set; } 
        public IRPSTextBox<WorkInProgressQueryView> AcceptedDate { get; set; } 
        public IRPSTextBox<WorkInProgressQueryView> RealEndDate { get; set; } 
        public IRPSTextBox<WorkInProgressQueryView> ChildNumber { get; set; } 
        public IRPSTextBox<WorkInProgressQueryView> TaskCountDone { get; set; } 
        public IRPSTextBox<WorkInProgressQueryView> PlannedEndMRPDate { get; set; } 
        public IRPSCheckbox<WorkInProgressQueryView> Canceled { get; set; } 
        public IRPSTextBox<WorkInProgressQueryView> PlannedStartDate2 { get; set; } 
        public IRPSTextBox<WorkInProgressQueryView> PlannedEndDate2 { get; set; } 
        public WorkInProgress Screen { get; set; }
        public WorkInProgressQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}