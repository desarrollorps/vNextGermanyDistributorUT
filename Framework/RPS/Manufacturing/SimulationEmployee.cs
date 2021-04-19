    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.SimulationEmployee
{
    //RPS VERSION 1.0.0.0
    public partial class SimulationEmployee:Screen
    {
        public SimulationEmployee():base()
        {
            this.URL = "manufacturing.simulationemployee";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            EmployeeCostSimVMQueryView  = new EmployeeCostSimVMQueryView(this); 
            EmployeeCostSimVMEntityView  = new EmployeeCostSimVMEntityView(this); 
            EmployeeCostSimDetailView  = new EmployeeCostSimDetailView(this); 
            SimulationEmployeeDialogView  = new SimulationEmployeeDialogView(this); 
            EmployeeCostSimVMQueryView.InitializeControls(); 
            EmployeeCostSimVMEntityView.InitializeControls(); 
            EmployeeCostSimDetailView.InitializeControls(); 
            SimulationEmployeeDialogView.InitializeControls(); 
           
        }
      
            public EmployeeCostSimVMQueryView EmployeeCostSimVMQueryView {get; set; } 
            public EmployeeCostSimVMEntityView EmployeeCostSimVMEntityView {get; set; } 
            public EmployeeCostSimDetailView EmployeeCostSimDetailView {get; set; } 
            public SimulationEmployeeDialogView SimulationEmployeeDialogView {get; set; } 
    }
            
    public partial class EmployeeCostSimVMQueryView : View
    {
        public EmployeeCostSimVMQueryView(SimulationEmployee screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<EmployeeCostSimVMQueryView,EmployeeCostSimVMEntityView>( this,Screen.EmployeeCostSimVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<EmployeeCostSimVMQueryView>( this);
 
            Site = RPSControlFactory.CreateRPSComboBox<EmployeeCostSimVMQueryView>("e7528867-59d1-4778-be50-8b89cb0a470d","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<EmployeeCostSimVMQueryView>( "730e0bb7-f06c-4b3a-9294-7b99e014b9fb","","",this);
 
            SimulationEmployeeNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<EmployeeCostSimVMQueryView,SimulationEmployeeDialogView>("5200a3bb-ddaf-4dc5-a690-b82e2a2f3885","","", this,Screen.SimulationEmployeeDialogView);
 
            CollectionInit params_EmployeeCostSim = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4f0e1fc7-b018-4156-9ea4-273cb03c2a77",CSSSelectorGrid="",XPathGrid=""};
            EmployeeCostSim = RPSControlFactory.RPSCreateCollectionWithGrid<EmployeeCostSimCollectionEditor<EmployeeCostSimVMQueryView,EmployeeCostSimVMEntityView>,EmployeeCostSimVMQueryView,EmployeeCostSimVMEntityView>( params_EmployeeCostSim,this,Screen.EmployeeCostSimVMEntityView);
 

        }
        public IRPSButton<EmployeeCostSimVMQueryView,EmployeeCostSimVMEntityView> NewButton { get; set; } 
        public IRPSButton<EmployeeCostSimVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<EmployeeCostSimVMQueryView> Site { get; set; } 
        public IRPSButton<EmployeeCostSimVMQueryView> DeleteCommandButton { get; set; } 
        public IRPSButton<EmployeeCostSimVMQueryView,SimulationEmployeeDialogView> SimulationEmployeeNavigationCommandButton { get; set; } 
        public EmployeeCostSimCollectionEditor<EmployeeCostSimVMQueryView,EmployeeCostSimVMEntityView> EmployeeCostSim { get; set; } 
        public SimulationEmployee Screen { get; set; }
        public EmployeeCostSimVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class EmployeeCostSimCollectionEditor<EmployeeCostSimVMQueryView,EmployeeCostSimVMEntityView>:RPSCollectionEditor<EmployeeCostSimVMQueryView,EmployeeCostSimVMEntityView> where EmployeeCostSimVMQueryView : class, IView where EmployeeCostSimVMEntityView : class, IView
    {
        public  EmployeeCostSimGridView<EmployeeCostSimVMQueryView,EmployeeCostSimVMEntityView> GridView {get;set;}
    }
    public partial class EmployeeCostSimGridView <EmployeeCostSimVMQueryView,EmployeeCostSimVMEntityView> :  RPSGridView<EmployeeCostSimVMQueryView,EmployeeCostSimVMEntityView> where EmployeeCostSimVMQueryView : class, IView where EmployeeCostSimVMEntityView : class, IView
    {
        public EmployeeCostSimGridView(EmployeeCostSimVMQueryView currentView,EmployeeCostSimVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class EmployeeCostSimVMEntityView : View
    {
        public EmployeeCostSimVMEntityView(SimulationEmployee screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<EmployeeCostSimVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<EmployeeCostSimVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EmployeeCostSimVMEntityView,EmployeeCostSimVMQueryView>( this,Screen.EmployeeCostSimVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<EmployeeCostSimVMEntityView,EmployeeCostSimVMQueryView>( this,Screen.EmployeeCostSimVMQueryView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<EmployeeCostSimVMEntityView>("7853543a-0197-4816-99a6-4649d2943742","","",true, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<EmployeeCostSimVMEntityView>("82369d35-0c46-468a-a794-28c9ed384d61","","",true, this);
 
            CollectionInit params_CPREmployeeCostSimDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c9e34d8d-fe28-46b0-9984-0f7f7aab8355",CSSSelectorGrid="",XPathGrid=""};
            CPREmployeeCostSimDetails = RPSControlFactory.RPSCreateCollectionWithGrid<CPREmployeeCostSimDetailsCollectionEditor<EmployeeCostSimVMEntityView,EmployeeCostSimDetailView>,EmployeeCostSimVMEntityView,EmployeeCostSimDetailView>( params_CPREmployeeCostSimDetails,this,Screen.EmployeeCostSimDetailView);
 

        }
        public IRPSSaveButton<EmployeeCostSimVMEntityView> SaveButton { get; set; } 
        public IRPSButton<EmployeeCostSimVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<EmployeeCostSimVMEntityView,EmployeeCostSimVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EmployeeCostSimVMEntityView,EmployeeCostSimVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<EmployeeCostSimVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<EmployeeCostSimVMEntityView> IDEmployee { get; set; } 
        public CPREmployeeCostSimDetailsCollectionEditor<EmployeeCostSimVMEntityView,EmployeeCostSimDetailView> CPREmployeeCostSimDetails { get; set; } 
        public SimulationEmployee Screen { get; set; }
        public EmployeeCostSimVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CPREmployeeCostSimDetailsCollectionEditor<EmployeeCostSimVMEntityView,EmployeeCostSimDetailView>:RPSCollectionEditor<EmployeeCostSimVMEntityView,EmployeeCostSimDetailView> where EmployeeCostSimVMEntityView : class, IView where EmployeeCostSimDetailView : class, IView
    {
        public  CPREmployeeCostSimDetailsGridView<EmployeeCostSimVMEntityView,EmployeeCostSimDetailView> GridView {get;set;}
    }
    public partial class CPREmployeeCostSimDetailsGridView <EmployeeCostSimVMEntityView,EmployeeCostSimDetailView> :  RPSGridView<EmployeeCostSimVMEntityView,EmployeeCostSimDetailView> where EmployeeCostSimVMEntityView : class, IView where EmployeeCostSimDetailView : class, IView
    {
        public CPREmployeeCostSimDetailsGridView(EmployeeCostSimVMEntityView currentView,EmployeeCostSimDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCostDetailType = RPSControlFactory.CreateRPSGridComboBox<EmployeeCostSimVMEntityView>("","#c9e34d8d-fe28-46b0-9984-0f7f7aab8355 .ag-row[role='row']@ROWINDEX [col-id='cIDCostDetailType']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<EmployeeCostSimVMEntityView>("","#c9e34d8d-fe28-46b0-9984-0f7f7aab8355 .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<EmployeeCostSimVMEntityView> IDCostDetailType { get; set; } 
        public IRPSGridTextBox<EmployeeCostSimVMEntityView> CostPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class EmployeeCostSimDetailView : View
    {
        public EmployeeCostSimDetailView(SimulationEmployee screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<EmployeeCostSimDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EmployeeCostSimDetailView,EmployeeCostSimVMEntityView>( this,Screen.EmployeeCostSimVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<EmployeeCostSimDetailView,EmployeeCostSimVMEntityView>( this,Screen.EmployeeCostSimVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<EmployeeCostSimDetailView,EmployeeCostSimVMEntityView>( this,Screen.EmployeeCostSimVMEntityView);
 
            IDCostDetailType = RPSControlFactory.CreateRPSComboBox<EmployeeCostSimDetailView>("f09797ac-e489-434a-b41a-46ba94e78779","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<EmployeeCostSimDetailView>("93c19766-bdfb-4e71-9d8a-84170a8de1e1","","",true, this);
 

        }
        public IRPSButton<EmployeeCostSimDetailView> DeleteButton { get; set; } 
        public IRPSButton<EmployeeCostSimDetailView,EmployeeCostSimVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EmployeeCostSimDetailView,EmployeeCostSimVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<EmployeeCostSimDetailView,EmployeeCostSimVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<EmployeeCostSimDetailView> IDCostDetailType { get; set; } 
        public IRPSTextBox<EmployeeCostSimDetailView> CostPrice { get; set; } 
        public SimulationEmployee Screen { get; set; }
        public EmployeeCostSimDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SimulationEmployeeDialogView : View
    {
        public SimulationEmployeeDialogView(SimulationEmployee screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Employee = RPSControlFactory.CreateRPSCollectionComboBox<SimulationEmployeeDialogView>("b615d220-b4fc-4aee-8201-62de24f80d7e","","",false, this);
 
            HourType = RPSControlFactory.CreateRPSComboBox<SimulationEmployeeDialogView>("06895498-24d9-4017-879a-3b80f5f4f858","","",false, this);
 
            CostDetailType = RPSControlFactory.CreateRPSCollectionComboBox<SimulationEmployeeDialogView>("a3a32794-5132-486a-a560-665727c3508f","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<SimulationEmployeeDialogView>("4e952a7b-161b-41ef-a4a0-8b4191deb834","","",false, this);
 

        }
        public IRPSCollectionComboBox<SimulationEmployeeDialogView> Employee { get; set; } 
        public IRPSComboBox<SimulationEmployeeDialogView> HourType { get; set; } 
        public IRPSCollectionComboBox<SimulationEmployeeDialogView> CostDetailType { get; set; } 
        public IRPSTextBox<SimulationEmployeeDialogView> Percentage { get; set; } 
        public SimulationEmployee Screen { get; set; }
        public SimulationEmployeeDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}