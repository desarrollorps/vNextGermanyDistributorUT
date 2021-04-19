    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.BudgetCategory
{
    //RPS VERSION 1.0.0.0
    public partial class BudgetCategory:Screen
    {
        public BudgetCategory():base()
        {
            this.URL = "project.budgetcategory";
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
 
            CodBudgetCategory = RPSControlFactory.CreateRPSTextBox<BudgetCategoryVMEntityView>("f7e23410-5355-40da-9561-18c7539cd8c2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<BudgetCategoryVMEntityView>("19be2d0f-ec25-483e-89d2-6469dbe9105f","","",false, this);
 
            CollectionInit params_BudgetCategoryDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0517fbaa-a186-4035-8e92-0178b2799dca",CSSSelectorGrid="",XPathGrid=""};
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
            TypeDetail = RPSControlFactory.CreateRPSGridEnumComboBox<BudgetCategoryVMEntityView>("","#0517fbaa-a186-4035-8e92-0178b2799dca .ag-row[role='row']@ROWINDEX [col-id='cTypeDetail']","",true, this.CurrentView);
 
            IDItemSelector = RPSControlFactory.CreateRPSGridComboBox<BudgetCategoryVMEntityView>("","#0517fbaa-a186-4035-8e92-0178b2799dca .ag-row[role='row']@ROWINDEX [col-id='cIDItemSelector']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<BudgetCategoryVMEntityView> TypeDetail { get; set; } 
        public IRPSGridComboBox<BudgetCategoryVMEntityView> IDItemSelector { get; set; } 
                     
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
 
            TypeDetail = RPSControlFactory.CreateRPSEnumComboBox<BudgetCategoryDetailView>("de74abb0-530d-4602-a85d-b94d3022285c","","",true, this);
 
            Employee = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("6b7d91b6-b041-4cd5-a8fd-750ef9f95d99","","",false, this);
 
            Qualify = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("41897222-8ffe-4bea-bfc4-3aeb00bfd677","","",false, this);
 
            Machine = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("fae5d55b-a600-47b9-856b-7ef2005b23fb","","",false, this);
 
            MachineGroup = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("5ac39ba1-c90f-4d32-8320-b233dec936c4","","",false, this);
 
            Tool = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("4bb56d1e-ff99-4e5b-b4f4-935d224e76ca","","",false, this);
 
            CostComponent = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("873fe1d4-dced-4ba1-a967-846e3ed746f4","","",false, this);
 
            Article = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("532b9cf0-6ad7-4f7f-affb-3f7de63da5fe","","",false, this);
 
            ProductLine = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("f9b34fac-2b7b-46fc-b444-3439169fab0f","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("a42e5c3d-5224-47d5-a682-04bf3ca12aed","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSComboBox<BudgetCategoryDetailView>("4c50d5e8-f558-4f7f-92dc-2d424bc39c73","","",false, this);
 

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
        public IRPSComboBox<BudgetCategoryDetailView> CostComponent { get; set; } 
        public IRPSComboBox<BudgetCategoryDetailView> Article { get; set; } 
        public IRPSComboBox<BudgetCategoryDetailView> ProductLine { get; set; } 
        public IRPSComboBox<BudgetCategoryDetailView> ProductFamily { get; set; } 
        public IRPSComboBox<BudgetCategoryDetailView> ProductSubFamily { get; set; } 
        public BudgetCategory Screen { get; set; }
        public BudgetCategoryDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}