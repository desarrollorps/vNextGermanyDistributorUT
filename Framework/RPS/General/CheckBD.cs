    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.CheckBD
{
    //RPS VERSION 1.0.0.0
    public partial class CheckBD:Screen
    {
        public CheckBD():base()
        {
            this.URL = "general.checkbd";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CheckBDView  = new CheckBDView(this); 
            CheckBDView.InitializeControls(); 
           
        }
      
            public CheckBDView CheckBDView {get; set; } 
    }
            
    public partial class CheckBDView : View
    {
        public CheckBDView(CheckBD screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SelectionService = RPSControlFactory.CreateRPSEnumComboBox<CheckBDView>("ab392a0c-52b2-4300-a8da-f5bc38ef30f0","","",false, this);
 
            UIService = RPSControlFactory.CreateRPSEnumComboBox<CheckBDView>("6f2b1c31-afde-4c22-b1ce-204fe96a99ba","","",false, this);
 
            SelectionEntity = RPSControlFactory.CreateRPSEnumComboBox<CheckBDView>("e8741faf-80e8-46b2-b462-9a4554dd5159","","",false, this);
 
            UIServiceEntity = RPSControlFactory.CreateRPSEnumComboBox<CheckBDView>("b133ec6c-7914-484d-a3ff-48f1e24da6fb","","",false, this);
 
            OnlyEntitiesWithErrors = RPSControlFactory.CreateRPSCheckBox<CheckBDView>("cfcb7115-1aca-46f2-b4a1-a74213a4d554","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<CheckBDView>("3077426c-5e69-4fcf-acd8-04ae78c80f53","","",false, this);
 
            VerifyDataBaseCommand = RPSControlFactory.CreateRPSButton<CheckBDView>( "c1fc344b-589b-418d-9124-69619680f1d5","","",this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<CheckBDView>( "0c0a716b-a556-4ba5-89b9-52e403cd7348","","",this);
 
            CollectionInit params_GetEntityValidation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="96cb998c-50aa-468b-b4d9-3741cd21115a",CSSSelectorGrid="",XPathGrid=""};
            GetEntityValidation = RPSControlFactory.RPSCreateCollectionWithGrid<GetEntityValidationCollectionEditor<CheckBDView>,CheckBDView>( params_GetEntityValidation,this);
 

        }
        public IRPSComboBox<CheckBDView> SelectionService { get; set; } 
        public IRPSComboBox<CheckBDView> UIService { get; set; } 
        public IRPSComboBox<CheckBDView> SelectionEntity { get; set; } 
        public IRPSComboBox<CheckBDView> UIServiceEntity { get; set; } 
        public IRPSCheckbox<CheckBDView> OnlyEntitiesWithErrors { get; set; } 
        public IRPSComboBox<CheckBDView> Type { get; set; } 
        public IRPSButton<CheckBDView> VerifyDataBaseCommand { get; set; } 
        public IRPSButton<CheckBDView> ReportCommandButton { get; set; } 
        public GetEntityValidationCollectionEditor<CheckBDView> GetEntityValidation { get; set; } 
        public CheckBD Screen { get; set; }
        public CheckBDView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetEntityValidationCollectionEditor<CheckBDView>:RPSCollectionEditor<CheckBDView> where CheckBDView : class, IView
    {
        public  GetEntityValidationGridView<CheckBDView> GridView {get;set;}
    }
    public partial class GetEntityValidationGridView <CheckBDView> :  RPSGridView<CheckBDView> where CheckBDView : class, IView
    {
        public GetEntityValidationGridView(CheckBDView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ServiceName = RPSControlFactory.CreateRPSGridTextBox<CheckBDView>("","#96cb998c-50aa-468b-b4d9-3741cd21115a .ag-row[role='row']@ROWINDEX [col-id='cServiceName']","",false, this.CurrentView);
 
            EntityName = RPSControlFactory.CreateRPSGridTextBox<CheckBDView>("","#96cb998c-50aa-468b-b4d9-3741cd21115a .ag-row[role='row']@ROWINDEX [col-id='cEntityName']","",false, this.CurrentView);
 
            RecordCount = RPSControlFactory.CreateRPSGridFormattedTextBox<CheckBDView>("","#96cb998c-50aa-468b-b4d9-3741cd21115a .ag-row[role='row']@ROWINDEX [col-id='cRecordCount']","",false, this.CurrentView);
 
            Message = RPSControlFactory.CreateRPSGridMemoTextBox<CheckBDView>("","#96cb998c-50aa-468b-b4d9-3741cd21115a .ag-row[role='row']@ROWINDEX [col-id='cMessage']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CheckBDView> ServiceName { get; set; } 
        public IRPSGridTextBox<CheckBDView> EntityName { get; set; } 
        public IRPSGridTextBox<CheckBDView> RecordCount { get; set; } 
        public IRPSGridTextBox<CheckBDView> Message { get; set; } 
                     
    }
 
    }
  
    

}