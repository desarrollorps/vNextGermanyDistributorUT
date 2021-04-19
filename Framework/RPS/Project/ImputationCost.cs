    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ImputationCost
{
    //RPS VERSION 1.0.0.0
    public partial class ImputationCost:Screen
    {
        public ImputationCost():base()
        {
            this.URL = "project.imputationcost";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            QueryView  = new QueryView(this); 
            EntityView  = new EntityView(this); 
            QueryView.InitializeControls(); 
            EntityView.InitializeControls(); 
           
        }
      
            public QueryView QueryView {get; set; } 
            public EntityView EntityView {get; set; } 
    }
            
    public partial class QueryView : View
    {
        public QueryView(ImputationCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<QueryView,EntityView>( this,Screen.EntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<QueryView>( this);
 
            UISite = RPSControlFactory.CreateRPSComboBox<QueryView>("1a1f3d2f-7918-4310-94da-3b089509d1b1","","",false, this);
 
            UILstProject = RPSControlFactory.CreateRPSCollectionComboBox<QueryView>("cc6a97b5-3394-4783-87d2-30f5e846859f","","",false, this);
 
            UILstProjectTask = RPSControlFactory.CreateRPSCollectionComboBox<QueryView>("420e7825-ea86-4f9f-943b-47fd0decd710","","",false, this);
 
            UIWarning = RPSControlFactory.CreateRPSComboBox<QueryView>("5f9f036e-82ab-4ba7-a6fd-9c266ceedeb5","","",false, this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<QueryView>("79cfbe8f-507e-4072-8197-89d5df22c492","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<QueryView>("74fe9e0f-c88c-4c31-9424-fe106c902f84","","",false, this);
 
            UILstCostComponent = RPSControlFactory.CreateRPSCollectionComboBox<QueryView>("0285a6b3-a965-433b-88b2-3c010ec413d1","","",false, this);
 
            UIGetIncludeChild = RPSControlFactory.CreateRPSCheckBox<QueryView>("aa3cbbf6-7789-420f-bc8d-afff74a544ea","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<QueryView>( "2b9e03bc-7c5d-43fd-9488-58727d2cd943","","",this);
 
            CollectionInit params_ImputationCost = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="664592c2-d289-4326-9e3a-f6b2d82b17b0",CSSSelectorGrid="",XPathGrid=""};
            ImputationCost = RPSControlFactory.RPSCreateCollectionWithGrid<ImputationCostCollectionEditor<QueryView,EntityView>,QueryView,EntityView>( params_ImputationCost,this,Screen.EntityView);
 

        }
        public IRPSButton<QueryView,EntityView> NewButton { get; set; } 
        public IRPSButton<QueryView> ConsultButton { get; set; } 
        public IRPSComboBox<QueryView> UISite { get; set; } 
        public IRPSCollectionComboBox<QueryView> UILstProject { get; set; } 
        public IRPSCollectionComboBox<QueryView> UILstProjectTask { get; set; } 
        public IRPSComboBox<QueryView> UIWarning { get; set; } 
        public IRPSTextBox<QueryView> UIDateFrom { get; set; } 
        public IRPSTextBox<QueryView> UIDateTo { get; set; } 
        public IRPSCollectionComboBox<QueryView> UILstCostComponent { get; set; } 
        public IRPSCheckbox<QueryView> UIGetIncludeChild { get; set; } 
        public IRPSButton<QueryView> DeleteCommandButton { get; set; } 
        public ImputationCostCollectionEditor<QueryView,EntityView> ImputationCost { get; set; } 
        public ImputationCost Screen { get; set; }
        public QueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImputationCostCollectionEditor<QueryView,EntityView>:RPSCollectionEditor<QueryView,EntityView> where QueryView : class, IView where EntityView : class, IView
    {
        public  ImputationCostGridView<QueryView,EntityView> GridView {get;set;}
    }
    public partial class ImputationCostGridView <QueryView,EntityView> :  RPSGridView<QueryView,EntityView> where QueryView : class, IView where EntityView : class, IView
    {
        public ImputationCostGridView(QueryView currentView,EntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationCost_ImputationDate = RPSControlFactory.CreateRPSGridTextBox<QueryView>("","#664592c2-d289-4326-9e3a-f6b2d82b17b0 .ag-row[role='row']@ROWINDEX [col-id='cImputationCost_ImputationDate']","",false, this.CurrentView);
 
            ImputationCost_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<QueryView>("","#664592c2-d289-4326-9e3a-f6b2d82b17b0 .ag-row[role='row']@ROWINDEX [col-id='cImputationCost_Quantity']","",false, this.CurrentView);
 
            ImputationCost_CostPriceReal = RPSControlFactory.CreateRPSGridFormattedTextBox<QueryView>("","#664592c2-d289-4326-9e3a-f6b2d82b17b0 .ag-row[role='row']@ROWINDEX [col-id='cImputationCost_CostPriceReal']","",false, this.CurrentView);
 
            ImputationCost_CostAmountReal = RPSControlFactory.CreateRPSGridFormattedTextBox<QueryView>("","#664592c2-d289-4326-9e3a-f6b2d82b17b0 .ag-row[role='row']@ROWINDEX [col-id='cImputationCost_CostAmountReal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QueryView> ImputationCost_ImputationDate { get; set; } 
        public IRPSGridTextBox<QueryView> ImputationCost_Quantity { get; set; } 
        public IRPSGridTextBox<QueryView> ImputationCost_CostPriceReal { get; set; } 
        public IRPSGridTextBox<QueryView> ImputationCost_CostAmountReal { get; set; } 
                     
    }
 
    }
  
            
    public partial class EntityView : View
    {
        public EntityView(ImputationCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<EntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<EntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EntityView,QueryView>( this,Screen.QueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<EntityView,QueryView>( this,Screen.QueryView);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<EntityView>("1b960994-acd8-4089-891b-09b26af4aeb5","","",true, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<EntityView>("4e74a6e4-95e1-4e23-b4ed-c9b02ad83a71","","",true, this);
 
            IDPROTask = RPSControlFactory.CreateRPSComboBox<EntityView>("2a764d89-b188-4e6c-9a0c-0887262d8858","","",true, this);
 
            UIEmployee = RPSControlFactory.CreateRPSComboBox<EntityView>("ca59a84e-19c1-4d79-954c-7b8741dddff7","","",false, this);
 
            IDCostComponent = RPSControlFactory.CreateRPSComboBox<EntityView>("6ecaeb87-bbab-471a-9408-3cc3125d9135","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("750065f5-6d06-4ad9-a36c-3360516a4c1e","","",true, this);
 
            CostPriceReal = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("75576ceb-aa25-48cd-a4e1-a154e2f9736e","","",true, this);
 
            CostAmountReal = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("44296e5f-a533-434a-a253-b6f5d8907a98","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<EntityView>("180107fc-5684-4b74-bcb3-679d91cad1c2","","",false, this);
 
            IDProTaskCostComponent = RPSControlFactory.CreateRPSComboBox<EntityView>("d3b7267d-9784-4dc2-acd0-a0fc2803f7bb","","",false, this);
 
            IDPROWarning = RPSControlFactory.CreateRPSComboBox<EntityView>("2fd13c2a-3d68-4973-bc0c-3988b4ff9d38","","",false, this);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<EntityView>("9b351b42-9ad3-44ee-9ade-98a2ba725647","","",false, this);
 
            Billable = RPSControlFactory.CreateRPSCheckBox<EntityView>("c942ad2e-f3c0-473c-8e25-cdfa109fa0e6","","",true, this);
 
            Invoiced = RPSControlFactory.CreateRPSCheckBox<EntityView>("92d384d2-712e-47ff-947f-0045980e0822","","",false, this);
 
            IsPosting = RPSControlFactory.CreateRPSCheckBox<EntityView>("a9eb044d-cf55-47b2-9790-025d7acd288b","","",true, this);
 

        }
        public IRPSSaveButton<EntityView> SaveButton { get; set; } 
        public IRPSButton<EntityView> DeleteButton { get; set; } 
        public IRPSButton<EntityView,QueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EntityView,QueryView> BackButton { get; set; } 
        public IRPSTextBox<EntityView> ImputationDate { get; set; } 
        public IRPSComboBox<EntityView> IDProject { get; set; } 
        public IRPSComboBox<EntityView> IDPROTask { get; set; } 
        public IRPSComboBox<EntityView> UIEmployee { get; set; } 
        public IRPSComboBox<EntityView> IDCostComponent { get; set; } 
        public IRPSTextBox<EntityView> Quantity { get; set; } 
        public IRPSTextBox<EntityView> CostPriceReal { get; set; } 
        public IRPSTextBox<EntityView> CostAmountReal { get; set; } 
        public IRPSTextBox<EntityView> Description { get; set; } 
        public IRPSComboBox<EntityView> IDProTaskCostComponent { get; set; } 
        public IRPSComboBox<EntityView> IDPROWarning { get; set; } 
        public IRPSTextBox<EntityView> CodDeliveryNote { get; set; } 
        public IRPSCheckbox<EntityView> Billable { get; set; } 
        public IRPSCheckbox<EntityView> Invoiced { get; set; } 
        public IRPSCheckbox<EntityView> IsPosting { get; set; } 
        public ImputationCost Screen { get; set; }
        public EntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}