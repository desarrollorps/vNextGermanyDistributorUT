    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.EmployeeCost
{
    //RPS VERSION 1.0.0.0
    public partial class EmployeeCost:Screen
    {
        public EmployeeCost():base()
        {
            this.URL = "manufacturing.employeecost";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            EmployeeCostCollectionView  = new EmployeeCostCollectionView(this); 
            EmployeeCostEntityView  = new EmployeeCostEntityView(this); 
            EmployeeCostDetailView  = new EmployeeCostDetailView(this); 
            EmployeeCostCollectionView.InitializeControls(); 
            EmployeeCostEntityView.InitializeControls(); 
            EmployeeCostDetailView.InitializeControls(); 
           
        }
      
            public EmployeeCostCollectionView EmployeeCostCollectionView {get; set; } 
            public EmployeeCostEntityView EmployeeCostEntityView {get; set; } 
            public EmployeeCostDetailView EmployeeCostDetailView {get; set; } 
    }
            
    public partial class EmployeeCostCollectionView : View
    {
        public EmployeeCostCollectionView(EmployeeCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<EmployeeCostCollectionView,EmployeeCostEntityView>( this,Screen.EmployeeCostEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0605c193-089f-4dcb-ae67-3127dc2202d9",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<EmployeeCostCollectionView,EmployeeCostEntityView>( params_MainConsult,this,Screen.EmployeeCostEntityView);
 

        }
        public IRPSButton<EmployeeCostCollectionView,EmployeeCostEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<EmployeeCostCollectionView,EmployeeCostEntityView> MainConsult { get; set; } 
        public EmployeeCost Screen { get; set; }
        public EmployeeCostCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EmployeeCostEntityView : View
    {
        public EmployeeCostEntityView(EmployeeCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<EmployeeCostEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<EmployeeCostEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EmployeeCostEntityView,EmployeeCostCollectionView>( this,Screen.EmployeeCostCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<EmployeeCostEntityView,EmployeeCostCollectionView>( this,Screen.EmployeeCostCollectionView);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<EmployeeCostEntityView>("69388f95-6ae8-47cd-9e1c-e55dd2edcd55","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<EmployeeCostEntityView>("2e56e416-1dab-41ce-9b58-834756cac734","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<EmployeeCostEntityView>("392db58e-744b-46c9-9beb-a04a38f9e0d7","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<EmployeeCostEntityView>("ef10f4e8-5393-4053-9792-baccccbd72c1","","",true, this);
 
            LinkNavigationCommand1 = RPSControlFactory.CreateRPSButton<EmployeeCostEntityView>( "eaf69137-9280-4d58-80b1-5d0a31b7cf8a","","",this);
 
            CollectionInit params_EmployeeCostDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5a0db09d-65af-49de-a7a6-832809a706f8",CSSSelectorGrid="",XPathGrid=""};
            EmployeeCostDetail = RPSControlFactory.RPSCreateCollectionWithGrid<EmployeeCostDetailCollectionEditor<EmployeeCostEntityView>,EmployeeCostEntityView>( params_EmployeeCostDetail,this);
 

        }
        public IRPSSaveButton<EmployeeCostEntityView> SaveButton { get; set; } 
        public IRPSButton<EmployeeCostEntityView> DeleteButton { get; set; } 
        public IRPSButton<EmployeeCostEntityView,EmployeeCostCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EmployeeCostEntityView,EmployeeCostCollectionView> BackButton { get; set; } 
        public IRPSComboBox<EmployeeCostEntityView> IDEmployee { get; set; } 
        public IRPSComboBox<EmployeeCostEntityView> IDHourType { get; set; } 
        public IRPSTextBox<EmployeeCostEntityView> DateFrom { get; set; } 
        public IRPSTextBox<EmployeeCostEntityView> CostPrice { get; set; } 
        public IRPSButton<EmployeeCostEntityView> LinkNavigationCommand1 { get; set; } 
        public EmployeeCostDetailCollectionEditor<EmployeeCostEntityView> EmployeeCostDetail { get; set; } 
        public EmployeeCost Screen { get; set; }
        public EmployeeCostEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class EmployeeCostDetailCollectionEditor<EmployeeCostEntityView>:RPSCollectionEditor<EmployeeCostEntityView> where EmployeeCostEntityView : class, IView
    {
        public  EmployeeCostDetailGridView<EmployeeCostEntityView> GridView {get;set;}
    }
    public partial class EmployeeCostDetailGridView <EmployeeCostEntityView> :  RPSGridView<EmployeeCostEntityView> where EmployeeCostEntityView : class, IView
    {
        public EmployeeCostDetailGridView(EmployeeCostEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class EmployeeCostDetailView : View
    {
        public EmployeeCostDetailView(EmployeeCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<EmployeeCostDetailView>( this);
 
            IDCostDetailType = RPSControlFactory.CreateRPSComboBox<EmployeeCostDetailView>("009cbabc-df7d-4391-9afd-598dd35052cf","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<EmployeeCostDetailView>("1aa6f5af-9773-4e5c-997f-210c4faf6c20","","",true, this);
 

        }
        public IRPSSaveButton<EmployeeCostDetailView> SaveButton { get; set; } 
        public IRPSComboBox<EmployeeCostDetailView> IDCostDetailType { get; set; } 
        public IRPSTextBox<EmployeeCostDetailView> CostPrice { get; set; } 
        public EmployeeCost Screen { get; set; }
        public EmployeeCostDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}