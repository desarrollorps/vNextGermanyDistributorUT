    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.EmployeeCostDetail
{
    //RPS VERSION 1.0.0.0
    public partial class EmployeeCostDetail:Screen
    {
        public EmployeeCostDetail():base()
        {
            this.URL = "manufacturing.employeecostdetail";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            EmployeeCostDetailCollectionView  = new EmployeeCostDetailCollectionView(this); 
            EmployeeCostDetailEntityView  = new EmployeeCostDetailEntityView(this); 
            EmployeeCostDetailCollectionView.InitializeControls(); 
            EmployeeCostDetailEntityView.InitializeControls(); 
           
        }
      
            public EmployeeCostDetailCollectionView EmployeeCostDetailCollectionView {get; set; } 
            public EmployeeCostDetailEntityView EmployeeCostDetailEntityView {get; set; } 
    }
            
    public partial class EmployeeCostDetailCollectionView : View
    {
        public EmployeeCostDetailCollectionView(EmployeeCostDetail screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<EmployeeCostDetailCollectionView,EmployeeCostDetailEntityView>( this,Screen.EmployeeCostDetailEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "fc115361-40e5-4d07-a9fb-e13cd238411b",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<EmployeeCostDetailCollectionView,EmployeeCostDetailEntityView>( params_MainConsult,this,Screen.EmployeeCostDetailEntityView);
 

        }
        public IRPSButton<EmployeeCostDetailCollectionView,EmployeeCostDetailEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<EmployeeCostDetailCollectionView,EmployeeCostDetailEntityView> MainConsult { get; set; } 
        public EmployeeCostDetail Screen { get; set; }
        public EmployeeCostDetailCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EmployeeCostDetailEntityView : View
    {
        public EmployeeCostDetailEntityView(EmployeeCostDetail screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<EmployeeCostDetailEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<EmployeeCostDetailEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EmployeeCostDetailEntityView,EmployeeCostDetailCollectionView>( this,Screen.EmployeeCostDetailCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<EmployeeCostDetailEntityView,EmployeeCostDetailCollectionView>( this,Screen.EmployeeCostDetailCollectionView);
 
            IDCostDetailType = RPSControlFactory.CreateRPSComboBox<EmployeeCostDetailEntityView>("824f7df0-d8a8-4ccc-b86b-a516c13ca20f","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<EmployeeCostDetailEntityView>("36002c5d-931f-4aa8-8532-018e2fe555a3","","",true, this);
 

        }
        public IRPSSaveButton<EmployeeCostDetailEntityView> SaveButton { get; set; } 
        public IRPSButton<EmployeeCostDetailEntityView> DeleteButton { get; set; } 
        public IRPSButton<EmployeeCostDetailEntityView,EmployeeCostDetailCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EmployeeCostDetailEntityView,EmployeeCostDetailCollectionView> BackButton { get; set; } 
        public IRPSComboBox<EmployeeCostDetailEntityView> IDCostDetailType { get; set; } 
        public IRPSTextBox<EmployeeCostDetailEntityView> CostPrice { get; set; } 
        public EmployeeCostDetail Screen { get; set; }
        public EmployeeCostDetailEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}