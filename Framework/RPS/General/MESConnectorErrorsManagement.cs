    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.MESConnectorErrorsManagement
{
    //RPS VERSION 1.0.0.0
    public partial class MESConnectorErrorsManagement:Screen
    {
        public MESConnectorErrorsManagement():base()
        {
            this.URL = "general.mesconnectorerrorsmanagement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MESConnectorErrorsManagementView  = new MESConnectorErrorsManagementView(this); 
            MESConnectorErrorsManagementView.InitializeControls(); 
           
        }
      
            public MESConnectorErrorsManagementView MESConnectorErrorsManagementView {get; set; } 
    }
            
    public partial class MESConnectorErrorsManagementView : View
    {
        public MESConnectorErrorsManagementView(MESConnectorErrorsManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteComm = RPSControlFactory.CreateRPSButton<MESConnectorErrorsManagementView>( "40de3520-c6cb-4510-a2e4-6316eb399c3e","","",this);
 
            RetryCommButton = RPSControlFactory.CreateRPSButton<MESConnectorErrorsManagementView>( "25735e53-e1a5-4af5-ad45-915f0c3203a6","","",this);
 
            CollectionInit params_GetMESImputationErrors = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4b0015b3-c64b-4bb6-87a1-f95679b41800",CSSSelectorGrid="",XPathGrid=""};
            GetMESImputationErrors = RPSControlFactory.RPSCreateCollectionWithGrid<GetMESImputationErrorsCollectionEditor<MESConnectorErrorsManagementView>,MESConnectorErrorsManagementView>( params_GetMESImputationErrors,this);
 
            CollectionInit params_GetMESImputationErrorDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="22cfe28d-733a-4a99-a483-361aa3395c93",CSSSelectorGrid="",XPathGrid=""};
            GetMESImputationErrorDetails = RPSControlFactory.RPSCreateCollectionWithGrid<GetMESImputationErrorDetailsCollectionEditor<MESConnectorErrorsManagementView>,MESConnectorErrorsManagementView>( params_GetMESImputationErrorDetails,this);
 

        }
        public IRPSButton<MESConnectorErrorsManagementView> DeleteComm { get; set; } 
        public IRPSButton<MESConnectorErrorsManagementView> RetryCommButton { get; set; } 
        public GetMESImputationErrorsCollectionEditor<MESConnectorErrorsManagementView> GetMESImputationErrors { get; set; } 
        public GetMESImputationErrorDetailsCollectionEditor<MESConnectorErrorsManagementView> GetMESImputationErrorDetails { get; set; } 
        public MESConnectorErrorsManagement Screen { get; set; }
        public MESConnectorErrorsManagementView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetMESImputationErrorsCollectionEditor<MESConnectorErrorsManagementView>:RPSCollectionEditor<MESConnectorErrorsManagementView> where MESConnectorErrorsManagementView : class, IView
    {
        public  GetMESImputationErrorsGridView<MESConnectorErrorsManagementView> GridView {get;set;}
    }
    public partial class GetMESImputationErrorsGridView <MESConnectorErrorsManagementView> :  RPSGridView<MESConnectorErrorsManagementView> where MESConnectorErrorsManagementView : class, IView
    {
        public GetMESImputationErrorsGridView(MESConnectorErrorsManagementView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridTextBox<MESConnectorErrorsManagementView>("","#4b0015b3-c64b-4bb6-87a1-f95679b41800 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",false, this.CurrentView);
 
            CodSite = RPSControlFactory.CreateRPSGridTextBox<MESConnectorErrorsManagementView>("","#4b0015b3-c64b-4bb6-87a1-f95679b41800 .ag-row[role='row']@ROWINDEX [col-id='cCodSite']","",false, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridTextBox<MESConnectorErrorsManagementView>("","#4b0015b3-c64b-4bb6-87a1-f95679b41800 .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            DateError = RPSControlFactory.CreateRPSGridTextBox<MESConnectorErrorsManagementView>("","#4b0015b3-c64b-4bb6-87a1-f95679b41800 .ag-row[role='row']@ROWINDEX [col-id='cDateError']","",false, this.CurrentView);
 
            ErrorMsg = RPSControlFactory.CreateRPSGridTextBox<MESConnectorErrorsManagementView>("","#4b0015b3-c64b-4bb6-87a1-f95679b41800 .ag-row[role='row']@ROWINDEX [col-id='cErrorMsg']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MESConnectorErrorsManagementView> CodCompany { get; set; } 
        public IRPSGridTextBox<MESConnectorErrorsManagementView> CodSite { get; set; } 
        public IRPSGridTextBox<MESConnectorErrorsManagementView> Type { get; set; } 
        public IRPSGridTextBox<MESConnectorErrorsManagementView> DateError { get; set; } 
        public IRPSGridTextBox<MESConnectorErrorsManagementView> ErrorMsg { get; set; } 
                     
    }
 
        public partial class GetMESImputationErrorDetailsCollectionEditor<MESConnectorErrorsManagementView>:RPSCollectionEditor<MESConnectorErrorsManagementView> where MESConnectorErrorsManagementView : class, IView
    {
        public  GetMESImputationErrorDetailsGridView<MESConnectorErrorsManagementView> GridView {get;set;}
    }
    public partial class GetMESImputationErrorDetailsGridView <MESConnectorErrorsManagementView> :  RPSGridView<MESConnectorErrorsManagementView> where MESConnectorErrorsManagementView : class, IView
    {
        public GetMESImputationErrorDetailsGridView(MESConnectorErrorsManagementView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PropertyName = RPSControlFactory.CreateRPSGridTextBox<MESConnectorErrorsManagementView>("","#22cfe28d-733a-4a99-a483-361aa3395c93 .ag-row[role='row']@ROWINDEX [col-id='cPropertyName']","",false, this.CurrentView);
 
            BasePropertyValue = RPSControlFactory.CreateRPSGridTextBox<MESConnectorErrorsManagementView>("","#22cfe28d-733a-4a99-a483-361aa3395c93 .ag-row[role='row']@ROWINDEX [col-id='cBasePropertyValue']","",false, this.CurrentView);
 
            ExtendedPropertyValue = RPSControlFactory.CreateRPSGridTextBox<MESConnectorErrorsManagementView>("","#22cfe28d-733a-4a99-a483-361aa3395c93 .ag-row[role='row']@ROWINDEX [col-id='cExtendedPropertyValue']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MESConnectorErrorsManagementView> PropertyName { get; set; } 
        public IRPSGridTextBox<MESConnectorErrorsManagementView> BasePropertyValue { get; set; } 
        public IRPSGridTextBox<MESConnectorErrorsManagementView> ExtendedPropertyValue { get; set; } 
                     
    }
 
    }
  
    

}