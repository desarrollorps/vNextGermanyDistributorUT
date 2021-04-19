    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ImputationOnlinePRO
{
    //RPS VERSION 1.0.0.0
    public partial class ImputationOnlinePRO:Screen
    {
        public ImputationOnlinePRO():base()
        {
            this.URL = "project.imputationonlinepro";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ImputationOnLinePROVMQueryView  = new ImputationOnLinePROVMQueryView(this); 
            ImputationOnLinePROVMEntityView  = new ImputationOnLinePROVMEntityView(this); 
            ImputationOnLinePROVMQueryView.InitializeControls(); 
            ImputationOnLinePROVMEntityView.InitializeControls(); 
           
        }
      
            public ImputationOnLinePROVMQueryView ImputationOnLinePROVMQueryView {get; set; } 
            public ImputationOnLinePROVMEntityView ImputationOnLinePROVMEntityView {get; set; } 
    }
            
    public partial class ImputationOnLinePROVMQueryView : View
    {
        public ImputationOnLinePROVMQueryView(ImputationOnlinePRO screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ImputationOnLinePROVMQueryView,ImputationOnLinePROVMEntityView>( this,Screen.ImputationOnLinePROVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<ImputationOnLinePROVMQueryView>( this);
 
            Site = RPSControlFactory.CreateRPSComboBox<ImputationOnLinePROVMQueryView>("fda23d89-9562-440e-b6b6-b125b9a9eed4","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<ImputationOnLinePROVMQueryView>("b1aafa78-9110-40c8-b7be-d8a87762ff90","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ImputationOnLinePROVMQueryView>("6040aaf9-f0d6-45c7-9d77-897ff278e131","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ImputationOnLinePROVMQueryView>("209e1641-06d1-460a-870c-34de5035403e","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<ImputationOnLinePROVMQueryView>( "d6576b59-1c41-4fcc-a82b-3692255cf9dd","","",this);
 
            Started = RPSControlFactory.CreateRPSOption<ImputationOnLinePROVMQueryView>( "9502f707-5284-41c9-95ae-40d3fbad1761","","",this);
 
            Finished = RPSControlFactory.CreateRPSOption<ImputationOnLinePROVMQueryView>( "9c077fef-7560-4612-b774-c3fe5750df15","","",this);
 
            ExecuteGenerateImputationOnlinePROButton = RPSControlFactory.CreateRPSButton<ImputationOnLinePROVMQueryView>( "fd780e5e-5aed-4891-bd3c-1630d6919ff1","","",this);
 
            CollectionInit params_ImputationOnlinePRO = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d1fa1366-34c4-4c25-b8e0-6489bfaab00c",CSSSelectorGrid="",XPathGrid=""};
            ImputationOnlinePRO = RPSControlFactory.RPSCreateCollectionWithGrid<ImputationOnlinePROCollectionEditor<ImputationOnLinePROVMQueryView,ImputationOnLinePROVMEntityView>,ImputationOnLinePROVMQueryView,ImputationOnLinePROVMEntityView>( params_ImputationOnlinePRO,this,Screen.ImputationOnLinePROVMEntityView);
 

        }
        public IRPSButton<ImputationOnLinePROVMQueryView,ImputationOnLinePROVMEntityView> NewButton { get; set; } 
        public IRPSButton<ImputationOnLinePROVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<ImputationOnLinePROVMQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ImputationOnLinePROVMQueryView> Project { get; set; } 
        public IRPSTextBox<ImputationOnLinePROVMQueryView> DateFrom { get; set; } 
        public IRPSTextBox<ImputationOnLinePROVMQueryView> DateTo { get; set; } 
        public IRPSOption<ImputationOnLinePROVMQueryView> All { get; set; } 
        public IRPSOption<ImputationOnLinePROVMQueryView> Started { get; set; } 
        public IRPSOption<ImputationOnLinePROVMQueryView> Finished { get; set; } 
        public IRPSButton<ImputationOnLinePROVMQueryView> ExecuteGenerateImputationOnlinePROButton { get; set; } 
        public ImputationOnlinePROCollectionEditor<ImputationOnLinePROVMQueryView,ImputationOnLinePROVMEntityView> ImputationOnlinePRO { get; set; } 
        public ImputationOnlinePRO Screen { get; set; }
        public ImputationOnLinePROVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImputationOnlinePROCollectionEditor<ImputationOnLinePROVMQueryView,ImputationOnLinePROVMEntityView>:RPSCollectionEditor<ImputationOnLinePROVMQueryView,ImputationOnLinePROVMEntityView> where ImputationOnLinePROVMQueryView : class, IView where ImputationOnLinePROVMEntityView : class, IView
    {
        public  ImputationOnlinePROGridView<ImputationOnLinePROVMQueryView,ImputationOnLinePROVMEntityView> GridView {get;set;}
    }
    public partial class ImputationOnlinePROGridView <ImputationOnLinePROVMQueryView,ImputationOnLinePROVMEntityView> :  RPSGridView<ImputationOnLinePROVMQueryView,ImputationOnLinePROVMEntityView> where ImputationOnLinePROVMQueryView : class, IView where ImputationOnLinePROVMEntityView : class, IView
    {
        public ImputationOnlinePROGridView(ImputationOnLinePROVMQueryView currentView,ImputationOnLinePROVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationOnLinePRO_ResourceType = RPSControlFactory.CreateRPSGridTextBox<ImputationOnLinePROVMQueryView>("","#d1fa1366-34c4-4c25-b8e0-6489bfaab00c .ag-row[role='row']@ROWINDEX [col-id='cImputationOnLinePRO_ResourceType']","",false, this.CurrentView);
 
            ImputationOnLinePRO_ImputationDate = RPSControlFactory.CreateRPSGridTextBox<ImputationOnLinePROVMQueryView>("","#d1fa1366-34c4-4c25-b8e0-6489bfaab00c .ag-row[role='row']@ROWINDEX [col-id='cImputationOnLinePRO_ImputationDate']","",false, this.CurrentView);
 
            StartHour = RPSControlFactory.CreateRPSGridTextBox<ImputationOnLinePROVMQueryView>("","#d1fa1366-34c4-4c25-b8e0-6489bfaab00c .ag-row[role='row']@ROWINDEX [col-id='cStartHour']","",false, this.CurrentView);
 
            EndHour = RPSControlFactory.CreateRPSGridTextBox<ImputationOnLinePROVMQueryView>("","#d1fa1366-34c4-4c25-b8e0-6489bfaab00c .ag-row[role='row']@ROWINDEX [col-id='cEndHour']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ImputationOnLinePROVMQueryView> ImputationOnLinePRO_ResourceType { get; set; } 
        public IRPSGridTextBox<ImputationOnLinePROVMQueryView> ImputationOnLinePRO_ImputationDate { get; set; } 
        public IRPSGridTextBox<ImputationOnLinePROVMQueryView> StartHour { get; set; } 
        public IRPSGridTextBox<ImputationOnLinePROVMQueryView> EndHour { get; set; } 
                     
    }
 
    }
  
            
    public partial class ImputationOnLinePROVMEntityView : View
    {
        public ImputationOnLinePROVMEntityView(ImputationOnlinePRO screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ImputationOnLinePROVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ImputationOnLinePROVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ImputationOnLinePROVMEntityView,ImputationOnLinePROVMQueryView>( this,Screen.ImputationOnLinePROVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<ImputationOnLinePROVMEntityView,ImputationOnLinePROVMQueryView>( this,Screen.ImputationOnLinePROVMQueryView);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<ImputationOnLinePROVMEntityView>("1fa571e5-dca4-478d-885c-cbdd0da86169","","",true, this);
 
            IDProTask = RPSControlFactory.CreateRPSComboBox<ImputationOnLinePROVMEntityView>("9dc0077f-4c1f-4b74-88ff-e2af12a4736a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ImputationOnLinePROVMEntityView>("46ba4e8f-a99c-4a2d-8480-594d64e27192","","",false, this);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<ImputationOnLinePROVMEntityView>("053cb5c9-c0f7-4a52-a8b3-45fb0fa251bb","","",true, this);
 
            StartHour = RPSControlFactory.CreateRPSTextBox<ImputationOnLinePROVMEntityView>("d5b2b138-662c-4304-bada-7414c169f6a9","","",true, this);
 
            ImputationEndDate = RPSControlFactory.CreateRPSTextBox<ImputationOnLinePROVMEntityView>("39ff2312-63f3-44bd-9901-5b2211d46902","","",false, this);
 
            EndHour = RPSControlFactory.CreateRPSTextBox<ImputationOnLinePROVMEntityView>("0e5de9ea-6270-4824-843e-5bf4d644d28f","","",true, this);
 
            ResourceType = RPSControlFactory.CreateRPSEnumComboBox<ImputationOnLinePROVMEntityView>("5d237d63-279b-4b87-91de-f099b02aeb8d","","",true, this);
 
            IDProjectResourceEmployee = RPSControlFactory.CreateRPSComboBox<ImputationOnLinePROVMEntityView>("d1a7aa3a-ea21-4e2f-9e7f-4325a0084e7d","","",false, this);
 
            IDProjectResourceMachine = RPSControlFactory.CreateRPSComboBox<ImputationOnLinePROVMEntityView>("0e784e38-5106-46d9-bb46-2bb3cec98b3f","","",false, this);
 
            IDProjectResourceTool = RPSControlFactory.CreateRPSComboBox<ImputationOnLinePROVMEntityView>("5b214eee-edd0-48ed-a4f1-258ac30a321f","","",false, this);
 
            IDResourceEmployee = RPSControlFactory.CreateRPSComboBox<ImputationOnLinePROVMEntityView>("65a643b9-5e0d-4ed9-b5b4-1db9110a57fd","","",false, this);
 
            IDResourceMachine = RPSControlFactory.CreateRPSComboBox<ImputationOnLinePROVMEntityView>("70579709-dc47-4228-8269-b8df1d95b6d9","","",false, this);
 
            IDResourceTool = RPSControlFactory.CreateRPSComboBox<ImputationOnLinePROVMEntityView>("38b8fb99-e79c-46df-aadf-3d9cf73cc2c6","","",false, this);
 
            CostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationOnLinePROVMEntityView>("13bf2ad1-82a6-4e67-9c63-9a9060281477","","",true, this);
 
            PercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ImputationOnLinePROVMEntityView>("50d29a72-e5f4-4eb3-a141-f0a183121b44","","",true, this);
 
            DedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<ImputationOnLinePROVMEntityView>("9fcb23c0-1a00-4b6c-a4a6-019099828964","","",true, this);
 
            CostPriceReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationOnLinePROVMEntityView>("bd7acbd7-0f0b-40a4-ade3-bae8f1b863b3","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<ImputationOnLinePROVMEntityView>("30305965-f585-4aa1-9f0f-9b2f1494104d","","",false, this);
 
            CostType = RPSControlFactory.CreateRPSEnumComboBox<ImputationOnLinePROVMEntityView>("45ded3d0-1586-4ae5-a3a6-d0f589e0bd46","","",true, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<ImputationOnLinePROVMEntityView>("6804e9cb-b549-4821-9aab-673eececebe5","","",false, this);
 
            Unproductive = RPSControlFactory.CreateRPSCheckBox<ImputationOnLinePROVMEntityView>("44b5ecc4-0c04-4cdf-b9e2-387df583a17b","","",true, this);
 
            IDUnproductiveType = RPSControlFactory.CreateRPSComboBox<ImputationOnLinePROVMEntityView>("02914cd1-b1ad-4e17-b8a8-706ebe0fcb16","","",false, this);
 
            Preparation = RPSControlFactory.CreateRPSCheckBox<ImputationOnLinePROVMEntityView>("c040ccf2-e925-43db-9aed-876d44d8982b","","",true, this);
 

        }
        public IRPSSaveButton<ImputationOnLinePROVMEntityView> SaveButton { get; set; } 
        public IRPSButton<ImputationOnLinePROVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ImputationOnLinePROVMEntityView,ImputationOnLinePROVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ImputationOnLinePROVMEntityView,ImputationOnLinePROVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<ImputationOnLinePROVMEntityView> IDProject { get; set; } 
        public IRPSComboBox<ImputationOnLinePROVMEntityView> IDProTask { get; set; } 
        public IRPSTextBox<ImputationOnLinePROVMEntityView> Description { get; set; } 
        public IRPSTextBox<ImputationOnLinePROVMEntityView> ImputationDate { get; set; } 
        public IRPSTextBox<ImputationOnLinePROVMEntityView> StartHour { get; set; } 
        public IRPSTextBox<ImputationOnLinePROVMEntityView> ImputationEndDate { get; set; } 
        public IRPSTextBox<ImputationOnLinePROVMEntityView> EndHour { get; set; } 
        public IRPSComboBox<ImputationOnLinePROVMEntityView> ResourceType { get; set; } 
        public IRPSComboBox<ImputationOnLinePROVMEntityView> IDProjectResourceEmployee { get; set; } 
        public IRPSComboBox<ImputationOnLinePROVMEntityView> IDProjectResourceMachine { get; set; } 
        public IRPSComboBox<ImputationOnLinePROVMEntityView> IDProjectResourceTool { get; set; } 
        public IRPSComboBox<ImputationOnLinePROVMEntityView> IDResourceEmployee { get; set; } 
        public IRPSComboBox<ImputationOnLinePROVMEntityView> IDResourceMachine { get; set; } 
        public IRPSComboBox<ImputationOnLinePROVMEntityView> IDResourceTool { get; set; } 
        public IRPSTextBox<ImputationOnLinePROVMEntityView> CostQuantity { get; set; } 
        public IRPSTextBox<ImputationOnLinePROVMEntityView> PercentProgress { get; set; } 
        public IRPSTextBox<ImputationOnLinePROVMEntityView> DedicationPercent { get; set; } 
        public IRPSTextBox<ImputationOnLinePROVMEntityView> CostPriceReal { get; set; } 
        public IRPSComboBox<ImputationOnLinePROVMEntityView> IDHourType { get; set; } 
        public IRPSComboBox<ImputationOnLinePROVMEntityView> CostType { get; set; } 
        public IRPSComboBox<ImputationOnLinePROVMEntityView> IDMachine { get; set; } 
        public IRPSCheckbox<ImputationOnLinePROVMEntityView> Unproductive { get; set; } 
        public IRPSComboBox<ImputationOnLinePROVMEntityView> IDUnproductiveType { get; set; } 
        public IRPSCheckbox<ImputationOnLinePROVMEntityView> Preparation { get; set; } 
        public ImputationOnlinePRO Screen { get; set; }
        public ImputationOnLinePROVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}