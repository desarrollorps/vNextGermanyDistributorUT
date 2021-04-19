    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.SalesMethodSL
{
    //RPS VERSION 1.0.0.0
    public partial class SalesMethodSL:Screen
    {
        public SalesMethodSL():base()
        {
            this.URL = "salescrm.salesmethodsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SalesMethodSLQueryView  = new SalesMethodSLQueryView(this); 
            SalesMethodSLEntityView  = new SalesMethodSLEntityView(this); 
            SalesMethodPhaseSLView  = new SalesMethodPhaseSLView(this); 
            SalesMethodPhaseActivitySLView  = new SalesMethodPhaseActivitySLView(this); 
            SalesMethodSLQueryView.InitializeControls(); 
            SalesMethodSLEntityView.InitializeControls(); 
            SalesMethodPhaseSLView.InitializeControls(); 
            SalesMethodPhaseActivitySLView.InitializeControls(); 
           
        }
      
            public SalesMethodSLQueryView SalesMethodSLQueryView {get; set; } 
            public SalesMethodSLEntityView SalesMethodSLEntityView {get; set; } 
            public SalesMethodPhaseSLView SalesMethodPhaseSLView {get; set; } 
            public SalesMethodPhaseActivitySLView SalesMethodPhaseActivitySLView {get; set; } 
    }
            
    public partial class SalesMethodSLQueryView : View
    {
        public SalesMethodSLQueryView(SalesMethodSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SalesMethodSLQueryView,SalesMethodSLEntityView>( this,Screen.SalesMethodSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "dccb5b2b-8bae-4123-ae17-7b2a60f960c5",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SalesMethodSLQueryView,SalesMethodSLEntityView>( params_MainConsult,this,Screen.SalesMethodSLEntityView);
 

        }
        public IRPSButton<SalesMethodSLQueryView,SalesMethodSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SalesMethodSLQueryView,SalesMethodSLEntityView> MainConsult { get; set; } 
        public SalesMethodSL Screen { get; set; }
        public SalesMethodSLQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SalesMethodSLEntityView : View
    {
        public SalesMethodSLEntityView(SalesMethodSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SalesMethodSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesMethodSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesMethodSLEntityView,SalesMethodSLQueryView>( this,Screen.SalesMethodSLQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesMethodSLEntityView,SalesMethodSLQueryView>( this,Screen.SalesMethodSLQueryView);
 
            CodSalesMethod = RPSControlFactory.CreateRPSTextBox<SalesMethodSLEntityView>("ff137355-9609-40e7-bd96-095b491590a1","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SalesMethodSLEntityView>("1e832963-c819-44c8-8fd8-863fcdaa205d","","",false, this);
 
            IDWorkflowOnOportunityCreate = RPSControlFactory.CreateRPSComboBox<SalesMethodSLEntityView>("75e7e901-5b29-472a-8df6-fffb40be0058","","",false, this);
 
            IDWorkflowOnPhaseChange = RPSControlFactory.CreateRPSComboBox<SalesMethodSLEntityView>("627a00ca-21fb-4611-aea9-6e6a9f310a06","","",false, this);
 
            IDWorkflowOnStatusChange = RPSControlFactory.CreateRPSComboBox<SalesMethodSLEntityView>("32155664-7ef8-4ea5-980c-9118e4667429","","",false, this);
 
            IDWorkflowOnSalesQuoteAssign = RPSControlFactory.CreateRPSComboBox<SalesMethodSLEntityView>("82777881-b0f2-4674-b966-f72db3d091b2","","",false, this);
 
            IDWorkflowOnAgentChange = RPSControlFactory.CreateRPSComboBox<SalesMethodSLEntityView>("630efed2-2c69-4634-8904-6440e6514f1b","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SalesMethodSLEntityView>("f529e257-81cd-4cd6-be40-d6fd1181fb44","","",false, this);
 
            CollectionInit params_SalesMethodPhaseSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="528e95fc-33e6-4b50-854d-568ca889f775",CSSSelectorGrid="",XPathGrid=""};
            SalesMethodPhaseSLs = RPSControlFactory.RPSCreateCollectionWithGrid<SalesMethodPhaseSLsCollectionEditor<SalesMethodSLEntityView,SalesMethodPhaseSLView>,SalesMethodSLEntityView,SalesMethodPhaseSLView>( params_SalesMethodPhaseSLs,this,Screen.SalesMethodPhaseSLView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<SalesMethodSLEntityView>( "","ul li[rpsid='3d1bd00b-dd90-4d22-b714-629aec331746']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<SalesMethodSLEntityView>( "","ul li[rpsid='e324bf92-d07d-49ac-9e57-8f305bf4157c']","",this);
 

        }
        public IRPSSaveButton<SalesMethodSLEntityView> SaveButton { get; set; } 
        public IRPSButton<SalesMethodSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<SalesMethodSLEntityView,SalesMethodSLQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesMethodSLEntityView,SalesMethodSLQueryView> BackButton { get; set; } 
        public IRPSTextBox<SalesMethodSLEntityView> CodSalesMethod { get; set; } 
        public IRPSTextBox<SalesMethodSLEntityView> Description { get; set; } 
        public IRPSComboBox<SalesMethodSLEntityView> IDWorkflowOnOportunityCreate { get; set; } 
        public IRPSComboBox<SalesMethodSLEntityView> IDWorkflowOnPhaseChange { get; set; } 
        public IRPSComboBox<SalesMethodSLEntityView> IDWorkflowOnStatusChange { get; set; } 
        public IRPSComboBox<SalesMethodSLEntityView> IDWorkflowOnSalesQuoteAssign { get; set; } 
        public IRPSComboBox<SalesMethodSLEntityView> IDWorkflowOnAgentChange { get; set; } 
        public IRPSTextBox<SalesMethodSLEntityView> Comment { get; set; } 
        public SalesMethodPhaseSLsCollectionEditor<SalesMethodSLEntityView,SalesMethodPhaseSLView> SalesMethodPhaseSLs { get; set; } 
        public IRPSSection<SalesMethodSLEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<SalesMethodSLEntityView> CommentSection { get; set; } 
        public SalesMethodSL Screen { get; set; }
        public SalesMethodSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SalesMethodPhaseSLsCollectionEditor<SalesMethodSLEntityView,SalesMethodPhaseSLView>:RPSCollectionEditor<SalesMethodSLEntityView,SalesMethodPhaseSLView> where SalesMethodSLEntityView : class, IView where SalesMethodPhaseSLView : class, IView
    {
        public  SalesMethodPhaseSLsPhasesGridView<SalesMethodSLEntityView,SalesMethodPhaseSLView> GridView {get;set;}
    }
    public partial class SalesMethodPhaseSLsPhasesGridView <SalesMethodSLEntityView,SalesMethodPhaseSLView> :  RPSGridView<SalesMethodSLEntityView,SalesMethodPhaseSLView> where SalesMethodSLEntityView : class, IView where SalesMethodPhaseSLView : class, IView
    {
        public SalesMethodPhaseSLsPhasesGridView(SalesMethodSLEntityView currentView,SalesMethodPhaseSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodSalesMethodPhase = RPSControlFactory.CreateRPSGridTextBox<SalesMethodSLEntityView>("","#528e95fc-33e6-4b50-854d-568ca889f775 .ag-row[role='row']@ROWINDEX [col-id='cCodSalesMethodPhase']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SalesMethodSLEntityView>("","#528e95fc-33e6-4b50-854d-568ca889f775 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Initial = RPSControlFactory.CreateRPSGridCheckBox<SalesMethodSLEntityView>("","#528e95fc-33e6-4b50-854d-568ca889f775 .ag-row[role='row']@ROWINDEX [col-id='cInitial']","",true, this.CurrentView);
 
            SalesQuote = RPSControlFactory.CreateRPSGridCheckBox<SalesMethodSLEntityView>("","#528e95fc-33e6-4b50-854d-568ca889f775 .ag-row[role='row']@ROWINDEX [col-id='cSalesQuote']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesMethodSLEntityView> CodSalesMethodPhase { get; set; } 
        public IRPSGridTextBox<SalesMethodSLEntityView> Description { get; set; } 
        public IRPSGridCheckbox<SalesMethodSLEntityView> Initial { get; set; } 
        public IRPSGridCheckbox<SalesMethodSLEntityView> SalesQuote { get; set; } 
                     
    }
 
    }
  
            
    public partial class SalesMethodPhaseSLView : View
    {
        public SalesMethodPhaseSLView(SalesMethodSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesMethodPhaseSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesMethodPhaseSLView,SalesMethodSLEntityView>( this,Screen.SalesMethodSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesMethodPhaseSLView,SalesMethodSLEntityView>( this,Screen.SalesMethodSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SalesMethodPhaseSLView,SalesMethodSLEntityView>( this,Screen.SalesMethodSLEntityView);
 
            CodSalesMethodPhase = RPSControlFactory.CreateRPSTextBox<SalesMethodPhaseSLView>("3eb09813-dc84-40bf-beeb-29249a577b23","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SalesMethodPhaseSLView>("c5d0a7f1-b2fd-4e03-a2db-a42825113a6d","","",false, this);
 
            Initial = RPSControlFactory.CreateRPSCheckBox<SalesMethodPhaseSLView>("e5777359-f2ab-4517-aa8b-9a076d4e12ba","","",true, this);
 
            SalesQuote = RPSControlFactory.CreateRPSCheckBox<SalesMethodPhaseSLView>("036ce1e1-7c7d-4573-a49c-5b90d64e6efa","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SalesMethodPhaseSLView>("e094d313-ec59-477a-9450-cc6d2776138e","","",false, this);
 
            CollectionInit params_SalesMethodPhaseActivitySLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="96ee1990-a8e2-434c-b91e-85343522c44a",CSSSelectorGrid="",XPathGrid=""};
            SalesMethodPhaseActivitySLs = RPSControlFactory.RPSCreateCollectionWithGrid<SalesMethodPhaseActivitySLsCollectionEditor<SalesMethodPhaseSLView,SalesMethodPhaseActivitySLView>,SalesMethodPhaseSLView,SalesMethodPhaseActivitySLView>( params_SalesMethodPhaseActivitySLs,this,Screen.SalesMethodPhaseActivitySLView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<SalesMethodPhaseSLView>( "","ul li[rpsid='505c6b13-d5a0-4979-b808-4a2f0ebd31a3']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<SalesMethodPhaseSLView>( "","ul li[rpsid='babd2af1-d0e5-4979-8c1a-2ca3631842df']","",this);
 

        }
        public IRPSButton<SalesMethodPhaseSLView> DeleteButton { get; set; } 
        public IRPSButton<SalesMethodPhaseSLView,SalesMethodSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesMethodPhaseSLView,SalesMethodSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SalesMethodPhaseSLView,SalesMethodSLEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<SalesMethodPhaseSLView> CodSalesMethodPhase { get; set; } 
        public IRPSTextBox<SalesMethodPhaseSLView> Description { get; set; } 
        public IRPSCheckbox<SalesMethodPhaseSLView> Initial { get; set; } 
        public IRPSCheckbox<SalesMethodPhaseSLView> SalesQuote { get; set; } 
        public IRPSTextBox<SalesMethodPhaseSLView> Comment { get; set; } 
        public SalesMethodPhaseActivitySLsCollectionEditor<SalesMethodPhaseSLView,SalesMethodPhaseActivitySLView> SalesMethodPhaseActivitySLs { get; set; } 
        public IRPSSection<SalesMethodPhaseSLView> GeneralDataSection { get; set; } 
        public IRPSSection<SalesMethodPhaseSLView> CommentSection { get; set; } 
        public SalesMethodSL Screen { get; set; }
        public SalesMethodPhaseSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SalesMethodPhaseActivitySLsCollectionEditor<SalesMethodPhaseSLView,SalesMethodPhaseActivitySLView>:RPSCollectionEditor<SalesMethodPhaseSLView,SalesMethodPhaseActivitySLView> where SalesMethodPhaseSLView : class, IView where SalesMethodPhaseActivitySLView : class, IView
    {
        public  SalesMethodPhaseActivitySLsActivitiesGridView<SalesMethodPhaseSLView,SalesMethodPhaseActivitySLView> GridView {get;set;}
    }
    public partial class SalesMethodPhaseActivitySLsActivitiesGridView <SalesMethodPhaseSLView,SalesMethodPhaseActivitySLView> :  RPSGridView<SalesMethodPhaseSLView,SalesMethodPhaseActivitySLView> where SalesMethodPhaseSLView : class, IView where SalesMethodPhaseActivitySLView : class, IView
    {
        public SalesMethodPhaseActivitySLsActivitiesGridView(SalesMethodPhaseSLView currentView,SalesMethodPhaseActivitySLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDActivityType = RPSControlFactory.CreateRPSGridComboBox<SalesMethodPhaseSLView>("","#96ee1990-a8e2-434c-b91e-85343522c44a .ag-row[role='row']@ROWINDEX [col-id='cIDActivityType']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SalesMethodPhaseSLView>("","#96ee1990-a8e2-434c-b91e-85343522c44a .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesMethodPhaseSLView>("","#96ee1990-a8e2-434c-b91e-85343522c44a .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",true, this.CurrentView);
 
            StartDays = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesMethodPhaseSLView>("","#96ee1990-a8e2-434c-b91e-85343522c44a .ag-row[role='row']@ROWINDEX [col-id='cStartDays']","",true, this.CurrentView);
 
            ExecutionTime = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesMethodPhaseSLView>("","#96ee1990-a8e2-434c-b91e-85343522c44a .ag-row[role='row']@ROWINDEX [col-id='cExecutionTime']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SalesMethodPhaseSLView> IDActivityType { get; set; } 
        public IRPSGridTextBox<SalesMethodPhaseSLView> Description { get; set; } 
        public IRPSGridTextBox<SalesMethodPhaseSLView> Order { get; set; } 
        public IRPSGridTextBox<SalesMethodPhaseSLView> StartDays { get; set; } 
        public IRPSGridTextBox<SalesMethodPhaseSLView> ExecutionTime { get; set; } 
                     
    }
 
    }
  
            
    public partial class SalesMethodPhaseActivitySLView : View
    {
        public SalesMethodPhaseActivitySLView(SalesMethodSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesMethodPhaseActivitySLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesMethodPhaseActivitySLView,SalesMethodPhaseSLView>( this,Screen.SalesMethodPhaseSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesMethodPhaseActivitySLView,SalesMethodPhaseSLView>( this,Screen.SalesMethodPhaseSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SalesMethodPhaseActivitySLView,SalesMethodPhaseSLView>( this,Screen.SalesMethodPhaseSLView);
 
            IDActivityType = RPSControlFactory.CreateRPSComboBox<SalesMethodPhaseActivitySLView>("3e7b3c10-8e6e-4062-9986-76df754fa5b2","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SalesMethodPhaseActivitySLView>("689b5670-6fe6-4093-a319-ecf8065a7ad1","","",false, this);
 
            Order = RPSControlFactory.CreateRPSFormattedTextBox<SalesMethodPhaseActivitySLView>("9148caf6-d739-4e15-8d82-959f3b7a9b95","","",true, this);
 
            StartDays = RPSControlFactory.CreateRPSFormattedTextBox<SalesMethodPhaseActivitySLView>("20e3ad8e-2b4c-47c8-9161-c4c97f2a9c0e","","",true, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSFormattedTextBox<SalesMethodPhaseActivitySLView>("fed3f1e0-cbf7-4018-b940-96d6dd2110a0","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SalesMethodPhaseActivitySLView>("a4c5e38c-f308-40c9-9f57-aa1b7dcaa211","","",false, this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<SalesMethodPhaseActivitySLView>( "","ul li[rpsid='1c0eb88b-1776-4c4e-a7ca-6f843ed3f258']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<SalesMethodPhaseActivitySLView>( "","ul li[rpsid='df2ce6ab-5ba3-4e7d-9ad5-15ab9c9f0207']","",this);
 

        }
        public IRPSButton<SalesMethodPhaseActivitySLView> DeleteButton { get; set; } 
        public IRPSButton<SalesMethodPhaseActivitySLView,SalesMethodPhaseSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesMethodPhaseActivitySLView,SalesMethodPhaseSLView> BackButton { get; set; } 
        public IRPSAcceptButton<SalesMethodPhaseActivitySLView,SalesMethodPhaseSLView> AcceptButton { get; set; } 
        public IRPSComboBox<SalesMethodPhaseActivitySLView> IDActivityType { get; set; } 
        public IRPSTextBox<SalesMethodPhaseActivitySLView> Description { get; set; } 
        public IRPSTextBox<SalesMethodPhaseActivitySLView> Order { get; set; } 
        public IRPSTextBox<SalesMethodPhaseActivitySLView> StartDays { get; set; } 
        public IRPSTextBox<SalesMethodPhaseActivitySLView> ExecutionTime { get; set; } 
        public IRPSTextBox<SalesMethodPhaseActivitySLView> Comment { get; set; } 
        public IRPSSection<SalesMethodPhaseActivitySLView> GeneralDataSection { get; set; } 
        public IRPSSection<SalesMethodPhaseActivitySLView> CommentSection { get; set; } 
        public SalesMethodSL Screen { get; set; }
        public SalesMethodPhaseActivitySLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}