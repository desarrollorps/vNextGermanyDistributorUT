    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.BudgetCategory
{
    //RPS VERSION 1.0.0.0
    public partial class BudgetCategory:Screen
    {
        public BudgetCategory():base()
        {
            this.URL = "manufacturing.budgetcategory";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BudgetCategoryVMTreeView  = new BudgetCategoryVMTreeView(this); 
            BudgetCategoryVMEntityView  = new BudgetCategoryVMEntityView(this); 
            BudgetCategoryDetailView  = new BudgetCategoryDetailView(this); 
            BudgetCategoryVMTreeView.InitializeControls(); 
            BudgetCategoryVMEntityView.InitializeControls(); 
            BudgetCategoryDetailView.InitializeControls(); 
           
        }
      
            public BudgetCategoryVMTreeView BudgetCategoryVMTreeView {get; set; } 
            public BudgetCategoryVMEntityView BudgetCategoryVMEntityView {get; set; } 
            public BudgetCategoryDetailView BudgetCategoryDetailView {get; set; } 
    }
            
    public partial class BudgetCategoryVMTreeView : View
    {
        public BudgetCategoryVMTreeView(BudgetCategory screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public BudgetCategory Screen { get; set; }
        public BudgetCategoryVMTreeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BudgetCategoryVMEntityView : View
    {
        public BudgetCategoryVMEntityView(BudgetCategory screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<BudgetCategoryVMEntityView>( this);
 
            CodBudgetCategory = RPSControlFactory.CreateRPSTextBox<BudgetCategoryVMEntityView>("8542abda-3f67-4991-ae34-affbd42a6129","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<BudgetCategoryVMEntityView>("5ebd9896-b782-4e22-b4ad-3b2b088bc4e4","","",false, this);
 
            CollectionInit params_BudgetCategoryDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a141f883-6069-4124-adf3-a858e1075d42",CSSSelectorGrid="",XPathGrid=""};
            BudgetCategoryDetails = RPSControlFactory.RPSCreateCollectionWithGrid<BudgetCategoryDetailsCollectionEditor<BudgetCategoryVMEntityView,BudgetCategoryDetailView>,BudgetCategoryVMEntityView,BudgetCategoryDetailView>( params_BudgetCategoryDetails,this,Screen.BudgetCategoryDetailView);
 

        }
        public IRPSSaveButton<BudgetCategoryVMEntityView> SaveButton { get; set; } 
        public IRPSTextBox<BudgetCategoryVMEntityView> CodBudgetCategory { get; set; } 
        public IRPSTextBox<BudgetCategoryVMEntityView> Description { get; set; } 
        public BudgetCategoryDetailsCollectionEditor<BudgetCategoryVMEntityView,BudgetCategoryDetailView> BudgetCategoryDetails { get; set; } 
        public BudgetCategory Screen { get; set; }
        public BudgetCategoryVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class BudgetCategoryDetailsCollectionEditor<BudgetCategoryVMEntityView,BudgetCategoryDetailView>:RPSCollectionEditor<BudgetCategoryVMEntityView,BudgetCategoryDetailView> where BudgetCategoryVMEntityView : class, IView where BudgetCategoryDetailView : class, IView
    {
        public  BudgetCategoryDetailsGridView<BudgetCategoryVMEntityView,BudgetCategoryDetailView> GridView {get;set;}
    }
    public partial class BudgetCategoryDetailsGridView <BudgetCategoryVMEntityView,BudgetCategoryDetailView> :  RPSGridView<BudgetCategoryVMEntityView,BudgetCategoryDetailView> where BudgetCategoryVMEntityView : class, IView where BudgetCategoryDetailView : class, IView
    {
        public BudgetCategoryDetailsGridView(BudgetCategoryVMEntityView currentView,BudgetCategoryDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TypeDetail = RPSControlFactory.CreateRPSGridEnumComboBox<BudgetCategoryVMEntityView>("","#a141f883-6069-4124-adf3-a858e1075d42 .ag-row[role='row']@ROWINDEX [col-id='cTypeDetail']","",true, this.CurrentView);
 
            IDResourceSelector = RPSControlFactory.CreateRPSGridComboBox<BudgetCategoryVMEntityView>("","#a141f883-6069-4124-adf3-a858e1075d42 .ag-row[role='row']@ROWINDEX [col-id='cIDResourceSelector']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<BudgetCategoryVMEntityView> TypeDetail { get; set; } 
        public IRPSGridComboBox<BudgetCategoryVMEntityView> IDResourceSelector { get; set; } 
                     
    }
 
    }
  
            
    public partial class BudgetCategoryDetailView : View
    {
        public BudgetCategoryDetailView(BudgetCategory screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<BudgetCategoryDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<BudgetCategoryDetailView,BudgetCategoryVMEntityView>( this,Screen.BudgetCategoryVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<BudgetCategoryDetailView,BudgetCategoryVMEntityView>( this,Screen.BudgetCategoryVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<BudgetCategoryDetailView,BudgetCategoryVMEntityView>( this,Screen.BudgetCategoryVMEntityView);
 
            TypeDetail = RPSControlFactory.CreateRPSEnumComboBox<BudgetCategoryDetailView>("a0267235-20d6-4fc8-bbec-edc4a5353cc6","","",true, this);
 
            Employee = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("6c71360a-02fe-4a7d-9917-0d797b18a064","","",false, this);
 
            Qualify = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("a7a36f1f-cb8e-4c2e-8938-b819f27d4a76","","",false, this);
 
            Machine = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("3cd54ac7-4032-4e13-9061-f685629cf9b2","","",false, this);
 
            MachineGroup = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("c7c2c76b-d5b3-4890-8c66-3c598d388852","","",false, this);
 
            Tool = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("7dc4537f-5f92-436f-b771-d3343435c9fa","","",false, this);
 
            CostComponentSTR = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("b3cf3327-3ee3-406a-adc8-6e7efd741936","","",false, this);
 
            Article = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("9fa6ba7b-ff13-4546-8961-ca245f40572f","","",false, this);
 
            ProductLine = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("31737a88-4708-4705-b40e-3f482cbd158a","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("eb9d8d05-fd44-4b07-9645-02657c6fe0b2","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("143ad78a-7264-4277-a70f-1a99c01a9de6","","",false, this);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSButton<BudgetCategoryDetailView>( "474beb1e-0644-47f3-aa5c-0bf7b434b879","","",this);
 

        }
        public IRPSButton<BudgetCategoryDetailView> DeleteButton { get; set; } 
        public IRPSButton<BudgetCategoryDetailView,BudgetCategoryVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<BudgetCategoryDetailView,BudgetCategoryVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<BudgetCategoryDetailView,BudgetCategoryVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<BudgetCategoryDetailView> TypeDetail { get; set; } 
        public IRPSComboBox<BudgetCategoryDetailView> Employee { get; set; } 
        public IRPSComboBox<BudgetCategoryDetailView> Qualify { get; set; } 
        public IRPSComboBox<BudgetCategoryDetailView> Machine { get; set; } 
        public IRPSComboBox<BudgetCategoryDetailView> MachineGroup { get; set; } 
        public IRPSComboBox<BudgetCategoryDetailView> Tool { get; set; } 
        public IRPSComboBox<BudgetCategoryDetailView> CostComponentSTR { get; set; } 
        public IRPSComboBox<BudgetCategoryDetailView> Article { get; set; } 
        public IRPSComboBox<BudgetCategoryDetailView> ProductLine { get; set; } 
        public IRPSComboBox<BudgetCategoryDetailView> ProductFamily { get; set; } 
        public IRPSComboBox<BudgetCategoryDetailView> ProductSubFamily { get; set; } 
        public IRPSButton<BudgetCategoryDetailView> LinkNavigationCommand { get; set; } 
        public BudgetCategory Screen { get; set; }
        public BudgetCategoryDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}