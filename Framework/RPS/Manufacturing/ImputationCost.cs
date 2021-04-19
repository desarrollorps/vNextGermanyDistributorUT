    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ImputationCost
{
    //RPS VERSION 1.0.0.0
    public partial class ImputationCost:Screen
    {
        public ImputationCost():base()
        {
            this.URL = "manufacturing.imputationcost";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ImputationCostMOVMQueryView  = new ImputationCostMOVMQueryView(this); 
            ImputationCostMOVMEntityView  = new ImputationCostMOVMEntityView(this); 
            ImputationCostMOVMQueryView.InitializeControls(); 
            ImputationCostMOVMEntityView.InitializeControls(); 
           
        }
      
            public ImputationCostMOVMQueryView ImputationCostMOVMQueryView {get; set; } 
            public ImputationCostMOVMEntityView ImputationCostMOVMEntityView {get; set; } 
    }
            
    public partial class ImputationCostMOVMQueryView : View
    {
        public ImputationCostMOVMQueryView(ImputationCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ImputationCostMOVMQueryView,ImputationCostMOVMEntityView>( this,Screen.ImputationCostMOVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<ImputationCostMOVMQueryView>( this);
 
            Site = RPSControlFactory.CreateRPSComboBox<ImputationCostMOVMQueryView>("e68030a9-2cc4-4e96-91ca-cd43701de4f5","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<ImputationCostMOVMQueryView>("79cf3552-21ac-4838-b039-76461e325669","","",false, this);
 
            CostComponentSTR = RPSControlFactory.CreateRPSCollectionComboBox<ImputationCostMOVMQueryView>("896a819e-cb3a-4ced-a756-1eb31c5737fc","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ImputationCostMOVMQueryView>("77482f98-92b4-4121-8b99-9dad1e0210f1","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ImputationCostMOVMQueryView>("a79eeb04-8318-4f0a-93ad-54105b1b5e51","","",false, this);
 
            UIInternalCode = RPSControlFactory.CreateRPSTextBox<ImputationCostMOVMQueryView>("fec71624-1aea-40e7-b4a2-5df2901378ac","","",false, this);
 
            ImputationCostMO_Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationCostMOVMQueryView>("f2037a29-0b1d-4a0d-a89a-0548b9fff592","","",false, this);
 
            ImputationCostMO_CostAmountReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationCostMOVMQueryView>("5e9f2e3b-f1ed-4647-beaa-67f39562da13","","",false, this);
 
            ImputationCostMO_CostPriceReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationCostMOVMQueryView>("5a8cd675-23ee-4da7-a259-df05264abf78","","",false, this);
 
            ImputationCostMO_ImputationDate = RPSControlFactory.CreateRPSTextBox<ImputationCostMOVMQueryView>("6dd4103f-36d5-4e4d-995d-6e0e8c247072","","",false, this);
 
            ImputationCostMO_IsPosting = RPSControlFactory.CreateRPSCheckBox<ImputationCostMOVMQueryView>("05c759b0-dc42-4381-b04a-778bcb40c62b","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<ImputationCostMOVMQueryView>( "4b95caae-b36c-4b67-8e38-e5bc11768811","","",this);
 
            CollectionInit params_ImputationCost = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2d1c74bf-a33f-4eb8-b5d8-540d60b27557",CSSSelectorGrid="",XPathGrid=""};
            ImputationCost = RPSControlFactory.RPSCreateCollectionWithGrid<ImputationCostCollectionEditor<ImputationCostMOVMQueryView,ImputationCostMOVMEntityView>,ImputationCostMOVMQueryView,ImputationCostMOVMEntityView>( params_ImputationCost,this,Screen.ImputationCostMOVMEntityView);
 

        }
        public IRPSButton<ImputationCostMOVMQueryView,ImputationCostMOVMEntityView> NewButton { get; set; } 
        public IRPSButton<ImputationCostMOVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<ImputationCostMOVMQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ImputationCostMOVMQueryView> ManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<ImputationCostMOVMQueryView> CostComponentSTR { get; set; } 
        public IRPSTextBox<ImputationCostMOVMQueryView> DateFrom { get; set; } 
        public IRPSTextBox<ImputationCostMOVMQueryView> DateTo { get; set; } 
        public IRPSTextBox<ImputationCostMOVMQueryView> UIInternalCode { get; set; } 
        public IRPSTextBox<ImputationCostMOVMQueryView> ImputationCostMO_Quantity { get; set; } 
        public IRPSTextBox<ImputationCostMOVMQueryView> ImputationCostMO_CostAmountReal { get; set; } 
        public IRPSTextBox<ImputationCostMOVMQueryView> ImputationCostMO_CostPriceReal { get; set; } 
        public IRPSTextBox<ImputationCostMOVMQueryView> ImputationCostMO_ImputationDate { get; set; } 
        public IRPSCheckbox<ImputationCostMOVMQueryView> ImputationCostMO_IsPosting { get; set; } 
        public IRPSButton<ImputationCostMOVMQueryView> DeleteCommandButton { get; set; } 
        public ImputationCostCollectionEditor<ImputationCostMOVMQueryView,ImputationCostMOVMEntityView> ImputationCost { get; set; } 
        public ImputationCost Screen { get; set; }
        public ImputationCostMOVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImputationCostCollectionEditor<ImputationCostMOVMQueryView,ImputationCostMOVMEntityView>:RPSCollectionEditor<ImputationCostMOVMQueryView,ImputationCostMOVMEntityView> where ImputationCostMOVMQueryView : class, IView where ImputationCostMOVMEntityView : class, IView
    {
        public  ImputationCostGridView<ImputationCostMOVMQueryView,ImputationCostMOVMEntityView> GridView {get;set;}
    }
    public partial class ImputationCostGridView <ImputationCostMOVMQueryView,ImputationCostMOVMEntityView> :  RPSGridView<ImputationCostMOVMQueryView,ImputationCostMOVMEntityView> where ImputationCostMOVMQueryView : class, IView where ImputationCostMOVMEntityView : class, IView
    {
        public ImputationCostGridView(ImputationCostMOVMQueryView currentView,ImputationCostMOVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationCostMO_ImputationDate = RPSControlFactory.CreateRPSGridTextBox<ImputationCostMOVMQueryView>("","#2d1c74bf-a33f-4eb8-b5d8-540d60b27557 .ag-row[role='row']@ROWINDEX [col-id='cImputationCostMO_ImputationDate']","",false, this.CurrentView);
 
            ImputationCostMO_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ImputationCostMOVMQueryView>("","#2d1c74bf-a33f-4eb8-b5d8-540d60b27557 .ag-row[role='row']@ROWINDEX [col-id='cImputationCostMO_Quantity']","",false, this.CurrentView);
 
            ImputationCostMO_CostPriceReal = RPSControlFactory.CreateRPSGridFormattedTextBox<ImputationCostMOVMQueryView>("","#2d1c74bf-a33f-4eb8-b5d8-540d60b27557 .ag-row[role='row']@ROWINDEX [col-id='cImputationCostMO_CostPriceReal']","",false, this.CurrentView);
 
            ImputationCostMO_CostAmountReal = RPSControlFactory.CreateRPSGridFormattedTextBox<ImputationCostMOVMQueryView>("","#2d1c74bf-a33f-4eb8-b5d8-540d60b27557 .ag-row[role='row']@ROWINDEX [col-id='cImputationCostMO_CostAmountReal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ImputationCostMOVMQueryView> ImputationCostMO_ImputationDate { get; set; } 
        public IRPSGridTextBox<ImputationCostMOVMQueryView> ImputationCostMO_Quantity { get; set; } 
        public IRPSGridTextBox<ImputationCostMOVMQueryView> ImputationCostMO_CostPriceReal { get; set; } 
        public IRPSGridTextBox<ImputationCostMOVMQueryView> ImputationCostMO_CostAmountReal { get; set; } 
                     
    }
 
    }
  
            
    public partial class ImputationCostMOVMEntityView : View
    {
        public ImputationCostMOVMEntityView(ImputationCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ImputationCostMOVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ImputationCostMOVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ImputationCostMOVMEntityView,ImputationCostMOVMQueryView>( this,Screen.ImputationCostMOVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<ImputationCostMOVMEntityView,ImputationCostMOVMQueryView>( this,Screen.ImputationCostMOVMQueryView);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<ImputationCostMOVMEntityView>("b9a5173c-2eb8-47ec-82c7-6a8311d49e7f","","",true, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<ImputationCostMOVMEntityView>("351c162a-7d5f-4885-b9d2-dbf177f51980","","",true, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<ImputationCostMOVMEntityView>("5caa81d0-058d-4841-b280-23f1568247da","","",true, this);
 
            IDCostComponent = RPSControlFactory.CreateRPSComboBox<ImputationCostMOVMEntityView>("b0213866-2e47-4ed4-b7b0-57b592f7c43d","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationCostMOVMEntityView>("027fa511-de04-4d8a-806c-4ddd16d4fde3","","",true, this);
 
            CostPriceReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationCostMOVMEntityView>("3e5403fb-7863-40fc-9b0e-640286002683","","",true, this);
 
            CostAmountReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationCostMOVMEntityView>("a54c691e-782d-4f1c-b727-c8154ee9d184","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ImputationCostMOVMEntityView>("5195126e-7777-499d-976d-877997698eb1","","",false, this);
 
            IDMOTaskCostComponent = RPSControlFactory.CreateRPSComboBox<ImputationCostMOVMEntityView>("0e598e74-ff7e-4e2c-9b31-3e7f2d64a4b4","","",false, this);
 
            IsPosting = RPSControlFactory.CreateRPSCheckBox<ImputationCostMOVMEntityView>("b98a931a-c339-4f62-863f-b8c55fc16379","","",true, this);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<ImputationCostMOVMEntityView>( "15049c2a-9f98-43b9-a55d-3f86f0c76981","","",this);
 

        }
        public IRPSSaveButton<ImputationCostMOVMEntityView> SaveButton { get; set; } 
        public IRPSButton<ImputationCostMOVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ImputationCostMOVMEntityView,ImputationCostMOVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ImputationCostMOVMEntityView,ImputationCostMOVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<ImputationCostMOVMEntityView> ImputationDate { get; set; } 
        public IRPSComboBox<ImputationCostMOVMEntityView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<ImputationCostMOVMEntityView> IDMOTask { get; set; } 
        public IRPSComboBox<ImputationCostMOVMEntityView> IDCostComponent { get; set; } 
        public IRPSTextBox<ImputationCostMOVMEntityView> Quantity { get; set; } 
        public IRPSTextBox<ImputationCostMOVMEntityView> CostPriceReal { get; set; } 
        public IRPSTextBox<ImputationCostMOVMEntityView> CostAmountReal { get; set; } 
        public IRPSTextBox<ImputationCostMOVMEntityView> Description { get; set; } 
        public IRPSComboBox<ImputationCostMOVMEntityView> IDMOTaskCostComponent { get; set; } 
        public IRPSCheckbox<ImputationCostMOVMEntityView> IsPosting { get; set; } 
        public IRPSButton<ImputationCostMOVMEntityView> LinkNavigationCommandButton { get; set; } 
        public ImputationCost Screen { get; set; }
        public ImputationCostMOVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}