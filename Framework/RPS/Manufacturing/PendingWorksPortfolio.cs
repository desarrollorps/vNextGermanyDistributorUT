    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.PendingWorksPortfolio
{
    //RPS VERSION 1.0.0.0
    public partial class PendingWorksPortfolio:Screen
    {
        public PendingWorksPortfolio():base()
        {
            this.URL = "manufacturing.pendingworksportfolio";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PendingWorksPortfolioQueryView  = new PendingWorksPortfolioQueryView(this); 
            PendingWorksPortfolioQueryView.InitializeControls(); 
           
        }
      
            public PendingWorksPortfolioQueryView PendingWorksPortfolioQueryView {get; set; } 
    }
            
    public partial class PendingWorksPortfolioQueryView : View
    {
        public PendingWorksPortfolioQueryView(PendingWorksPortfolio screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSCollectionComboBox<PendingWorksPortfolioQueryView>("a4fb0238-3ca4-4db9-8b22-8db996ce0530","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<PendingWorksPortfolioQueryView>("100f29a6-86eb-4e29-97a7-ceb45a2b2d71","","",false, this);
 
            Employee = RPSControlFactory.CreateRPSCollectionComboBox<PendingWorksPortfolioQueryView>("5d4458bb-ba19-45aa-b27c-b86661daf1bd","","",false, this);
 
            Qualify = RPSControlFactory.CreateRPSCollectionComboBox<PendingWorksPortfolioQueryView>("66d2864e-acf9-4282-81e3-6d04e7d3ec15","","",false, this);
 
            EmployeeNone = RPSControlFactory.CreateRPSCheckBox<PendingWorksPortfolioQueryView>("67d9afdd-2f52-4fc5-a1ae-6baa35622c7c","","",false, this);
 
            Machine = RPSControlFactory.CreateRPSCollectionComboBox<PendingWorksPortfolioQueryView>("55666e68-8b67-47a8-a34c-07b54be05abc","","",false, this);
 
            MachineGroup = RPSControlFactory.CreateRPSCollectionComboBox<PendingWorksPortfolioQueryView>("82ba4675-9446-4a05-901f-0f61117e0b6c","","",false, this);
 
            MachineNone = RPSControlFactory.CreateRPSCheckBox<PendingWorksPortfolioQueryView>("8bd4f2ca-39f2-4548-a583-addbd600af90","","",false, this);
 
            OnlyMaterialWithStock = RPSControlFactory.CreateRPSCheckBox<PendingWorksPortfolioQueryView>("38b73017-c294-4a25-9053-1a7c1e373527","","",false, this);
 
            OnlyFinishedProducts = RPSControlFactory.CreateRPSCheckBox<PendingWorksPortfolioQueryView>("7f83f3a2-8031-4605-a14c-973c3568725b","","",false, this);
 
            ResourceType = RPSControlFactory.CreateRPSTextBox<PendingWorksPortfolioQueryView>("b96c6067-a96a-4eaa-a21a-901fd133b7a9","","",false, this);
 
            ResourceDescription = RPSControlFactory.CreateRPSTextBox<PendingWorksPortfolioQueryView>("4881533e-953d-4967-be18-efdbb7074712","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<PendingWorksPortfolioQueryView>("d0d63fa0-37b0-4557-abfc-2101cea8e34c","","",false, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<PendingWorksPortfolioQueryView>("f4786695-0a2b-4912-bf92-f56611110536","","",false, this);
 
            DateReplanify = RPSControlFactory.CreateRPSTextBox<PendingWorksPortfolioQueryView>("6bf8d3f9-c293-4972-a1e0-4d90c653a038","","",false, this);
 
            PlannedStartDate = RPSControlFactory.CreateRPSTextBox<PendingWorksPortfolioQueryView>("3758d8e3-05b8-49ea-9e48-cc454270aec1","","",false, this);
 
            PlannedEndDate = RPSControlFactory.CreateRPSTextBox<PendingWorksPortfolioQueryView>("fb9c2719-f2c1-4038-92bf-a3a9936ae4ec","","",false, this);
 
            IsFirstTask = RPSControlFactory.CreateRPSCheckBox<PendingWorksPortfolioQueryView>("a987787a-af4b-4f64-86d2-d811f9af1d3f","","",false, this);
 
            CollectionInit params_PendingWorksPortfolio = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="28c8ef36-f805-4487-b139-1b0df712f0db",CSSSelectorGrid="",XPathGrid=""};
            PendingWorksPortfolio = RPSControlFactory.RPSCreateCollectionWithGrid<PendingWorksPortfolioCollectionEditor<PendingWorksPortfolioQueryView>,PendingWorksPortfolioQueryView>( params_PendingWorksPortfolio,this);
 

        }
        public IRPSCollectionComboBox<PendingWorksPortfolioQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<PendingWorksPortfolioQueryView> Customer { get; set; } 
        public IRPSCollectionComboBox<PendingWorksPortfolioQueryView> Employee { get; set; } 
        public IRPSCollectionComboBox<PendingWorksPortfolioQueryView> Qualify { get; set; } 
        public IRPSCheckbox<PendingWorksPortfolioQueryView> EmployeeNone { get; set; } 
        public IRPSCollectionComboBox<PendingWorksPortfolioQueryView> Machine { get; set; } 
        public IRPSCollectionComboBox<PendingWorksPortfolioQueryView> MachineGroup { get; set; } 
        public IRPSCheckbox<PendingWorksPortfolioQueryView> MachineNone { get; set; } 
        public IRPSCheckbox<PendingWorksPortfolioQueryView> OnlyMaterialWithStock { get; set; } 
        public IRPSCheckbox<PendingWorksPortfolioQueryView> OnlyFinishedProducts { get; set; } 
        public IRPSTextBox<PendingWorksPortfolioQueryView> ResourceType { get; set; } 
        public IRPSTextBox<PendingWorksPortfolioQueryView> ResourceDescription { get; set; } 
        public IRPSTextBox<PendingWorksPortfolioQueryView> InternalCode { get; set; } 
        public IRPSTextBox<PendingWorksPortfolioQueryView> Priority { get; set; } 
        public IRPSTextBox<PendingWorksPortfolioQueryView> DateReplanify { get; set; } 
        public IRPSTextBox<PendingWorksPortfolioQueryView> PlannedStartDate { get; set; } 
        public IRPSTextBox<PendingWorksPortfolioQueryView> PlannedEndDate { get; set; } 
        public IRPSCheckbox<PendingWorksPortfolioQueryView> IsFirstTask { get; set; } 
        public PendingWorksPortfolioCollectionEditor<PendingWorksPortfolioQueryView> PendingWorksPortfolio { get; set; } 
        public PendingWorksPortfolio Screen { get; set; }
        public PendingWorksPortfolioQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PendingWorksPortfolioCollectionEditor<PendingWorksPortfolioQueryView>:RPSCollectionEditor<PendingWorksPortfolioQueryView> where PendingWorksPortfolioQueryView : class, IView
    {
        public  PendingWorksPortfolioGridView<PendingWorksPortfolioQueryView> GridView {get;set;}
    }
    public partial class PendingWorksPortfolioGridView <PendingWorksPortfolioQueryView> :  RPSGridView<PendingWorksPortfolioQueryView> where PendingWorksPortfolioQueryView : class, IView
    {
        public PendingWorksPortfolioGridView(PendingWorksPortfolioQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ResourceDescription = RPSControlFactory.CreateRPSGridTextBox<PendingWorksPortfolioQueryView>("","#28c8ef36-f805-4487-b139-1b0df712f0db .ag-row[role='row']@ROWINDEX [col-id='cResourceDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PendingWorksPortfolioQueryView> ResourceDescription { get; set; } 
                     
    }
 
    }
  
    

}