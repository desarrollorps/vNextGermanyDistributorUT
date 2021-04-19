    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.QuotationLotSL
{
    //RPS VERSION 1.0.0.0
    public partial class QuotationLotSL:Screen
    {
        public QuotationLotSL():base()
        {
            this.URL = "salescrm.quotationlotsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            QuotationLotSLView  = new QuotationLotSLView(this); 
            CreateNewQuotationLotDialogView  = new CreateNewQuotationLotDialogView(this); 
            DeleteQuotationLotDialogView  = new DeleteQuotationLotDialogView(this); 
            QuotationLotMaterialCostDetailViewModelDialogView  = new QuotationLotMaterialCostDetailViewModelDialogView(this); 
            QuotationLotMaterialOverchargeDetailViewModelDialogView  = new QuotationLotMaterialOverchargeDetailViewModelDialogView(this); 
            QuotationLotResourceCostDetailViewModelDialogView  = new QuotationLotResourceCostDetailViewModelDialogView(this); 
            QuotationLotResourceOverchargeDetailViewModelDialogView  = new QuotationLotResourceOverchargeDetailViewModelDialogView(this); 
            QuotationLotOtherCostCostDetailViewModelDialogView  = new QuotationLotOtherCostCostDetailViewModelDialogView(this); 
            QuotationLotOtherCostOverchargeDetailViewModelDialogView  = new QuotationLotOtherCostOverchargeDetailViewModelDialogView(this); 
            QuotationLotGeneralOverchargeDetailViewModelDialogView  = new QuotationLotGeneralOverchargeDetailViewModelDialogView(this); 
            QuotationLotSLView.InitializeControls(); 
            CreateNewQuotationLotDialogView.InitializeControls(); 
            DeleteQuotationLotDialogView.InitializeControls(); 
            QuotationLotMaterialCostDetailViewModelDialogView.InitializeControls(); 
            QuotationLotMaterialOverchargeDetailViewModelDialogView.InitializeControls(); 
            QuotationLotResourceCostDetailViewModelDialogView.InitializeControls(); 
            QuotationLotResourceOverchargeDetailViewModelDialogView.InitializeControls(); 
            QuotationLotOtherCostCostDetailViewModelDialogView.InitializeControls(); 
            QuotationLotOtherCostOverchargeDetailViewModelDialogView.InitializeControls(); 
            QuotationLotGeneralOverchargeDetailViewModelDialogView.InitializeControls(); 
           
        }
      
            public QuotationLotSLView QuotationLotSLView {get; set; } 
            public CreateNewQuotationLotDialogView CreateNewQuotationLotDialogView {get; set; } 
            public DeleteQuotationLotDialogView DeleteQuotationLotDialogView {get; set; } 
            public QuotationLotMaterialCostDetailViewModelDialogView QuotationLotMaterialCostDetailViewModelDialogView {get; set; } 
            public QuotationLotMaterialOverchargeDetailViewModelDialogView QuotationLotMaterialOverchargeDetailViewModelDialogView {get; set; } 
            public QuotationLotResourceCostDetailViewModelDialogView QuotationLotResourceCostDetailViewModelDialogView {get; set; } 
            public QuotationLotResourceOverchargeDetailViewModelDialogView QuotationLotResourceOverchargeDetailViewModelDialogView {get; set; } 
            public QuotationLotOtherCostCostDetailViewModelDialogView QuotationLotOtherCostCostDetailViewModelDialogView {get; set; } 
            public QuotationLotOtherCostOverchargeDetailViewModelDialogView QuotationLotOtherCostOverchargeDetailViewModelDialogView {get; set; } 
            public QuotationLotGeneralOverchargeDetailViewModelDialogView QuotationLotGeneralOverchargeDetailViewModelDialogView {get; set; } 
    }
            
    public partial class QuotationLotSLView : View
    {
        public QuotationLotSLView(QuotationLotSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSelectedQuotationSL = RPSControlFactory.CreateRPSComboBox<QuotationLotSLView>("b9cd66b9-7f04-4710-a50d-a4aaa128877b","","",false, this);
 
            ExecuteLoadQuotationData = RPSControlFactory.CreateRPSButton<QuotationLotSLView>( "99358a78-7f57-4799-8b4f-1c6a3bbce9a4","","",this);
 
            CreateNewQuotationLotNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<QuotationLotSLView,CreateNewQuotationLotDialogView>("a2ce244c-3688-46e7-9f97-7a451b040249","","", this,Screen.CreateNewQuotationLotDialogView);
 
            DeleteQuotationLotNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<QuotationLotSLView,DeleteQuotationLotDialogView>("6649c1d4-90ad-42ac-95d5-e5befffaf7a5","","", this,Screen.DeleteQuotationLotDialogView);
 
            NavigateToSelectedCellDetailButton = RPSControlFactory.CreateRPSButton<QuotationLotSLView>( "34a4c45d-9040-4f4a-9c91-005d789bdcd6","","",this);
 

        }
        public IRPSComboBox<QuotationLotSLView> IDSelectedQuotationSL { get; set; } 
        public IRPSButton<QuotationLotSLView> ExecuteLoadQuotationData { get; set; } 
        public IRPSButton<QuotationLotSLView,CreateNewQuotationLotDialogView> CreateNewQuotationLotNavigationCommandButton { get; set; } 
        public IRPSButton<QuotationLotSLView,DeleteQuotationLotDialogView> DeleteQuotationLotNavigationCommandButton { get; set; } 
        public IRPSButton<QuotationLotSLView> NavigateToSelectedCellDetailButton { get; set; } 
        public QuotationLotSL Screen { get; set; }
        public QuotationLotSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CreateNewQuotationLotDialogView : View
    {
        public CreateNewQuotationLotDialogView(QuotationLotSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewLotQuantity = RPSControlFactory.CreateRPSFormattedTextBox<CreateNewQuotationLotDialogView>("91cae0cd-bacb-466c-a2af-5dd0a7a0cbc5","","",false, this);
 

        }
        public IRPSTextBox<CreateNewQuotationLotDialogView> NewLotQuantity { get; set; } 
        public QuotationLotSL Screen { get; set; }
        public CreateNewQuotationLotDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeleteQuotationLotDialogView : View
    {
        public DeleteQuotationLotDialogView(QuotationLotSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            LotQuantityToDelete = RPSControlFactory.CreateRPSFormattedTextBox<DeleteQuotationLotDialogView>("65a22054-cf5c-4d6a-9819-62cacddaf50a","","",false, this);
 

        }
        public IRPSTextBox<DeleteQuotationLotDialogView> LotQuantityToDelete { get; set; } 
        public QuotationLotSL Screen { get; set; }
        public DeleteQuotationLotDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QuotationLotMaterialCostDetailViewModelDialogView : View
    {
        public QuotationLotMaterialCostDetailViewModelDialogView(QuotationLotSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSFormattedTextBox<QuotationLotMaterialCostDetailViewModelDialogView>("9ccc5f25-2122-4bd7-acf9-42e55dbbcf95","","",false, this);
 
            External = RPSControlFactory.CreateRPSCheckBox<QuotationLotMaterialCostDetailViewModelDialogView>("ea51defc-5715-4ac4-bfe0-70c1b8647187","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<QuotationLotMaterialCostDetailViewModelDialogView>("07e3c70e-059b-4cde-9db3-85ee552a8ccf","","",false, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSFormattedTextBox<QuotationLotMaterialCostDetailViewModelDialogView>("b3cc3fe4-3bee-40e8-ad6a-84e07d156083","","",false, this);
 
            PreparationTime = RPSControlFactory.CreateRPSFormattedTextBox<QuotationLotMaterialCostDetailViewModelDialogView>("da55def4-1615-4854-9253-532bab857f5e","","",false, this);
 
            RepetitionTime = RPSControlFactory.CreateRPSFormattedTextBox<QuotationLotMaterialCostDetailViewModelDialogView>("28aad1a5-88e4-45b5-8af0-be17c69e6da8","","",false, this);
 
            CollectionInit params_QuotationLotMaterialCostDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2ed3bb33-8d98-4ea0-9a70-7add520885cf",CSSSelectorGrid="",XPathGrid=""};
            QuotationLotMaterialCostDetail = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationLotMaterialCostDetailCollectionEditor<QuotationLotMaterialCostDetailViewModelDialogView>,QuotationLotMaterialCostDetailViewModelDialogView>( params_QuotationLotMaterialCostDetail,this);
 
            CollectionInit params_QuotationLotQuotationTaskCostDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="88d6bfc2-feb8-4892-bedb-08e9b8bc0e78",CSSSelectorGrid="",XPathGrid=""};
            QuotationLotQuotationTaskCostDetail = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationLotQuotationTaskCostDetailCollectionEditor<QuotationLotMaterialCostDetailViewModelDialogView>,QuotationLotMaterialCostDetailViewModelDialogView>( params_QuotationLotQuotationTaskCostDetail,this);
 
            Section = RPSControlFactory.CreateRPSSection<QuotationLotMaterialCostDetailViewModelDialogView>( "","ul li[rpsid='414c7dae-0c25-414d-82de-2e630558d3e9']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<QuotationLotMaterialCostDetailViewModelDialogView>( "","ul li[rpsid='f10f189d-beb1-41da-92aa-beb172ce5957']","",this);
 

        }
        public IRPSTextBox<QuotationLotMaterialCostDetailViewModelDialogView> Order { get; set; } 
        public IRPSCheckbox<QuotationLotMaterialCostDetailViewModelDialogView> External { get; set; } 
        public IRPSTextBox<QuotationLotMaterialCostDetailViewModelDialogView> Description { get; set; } 
        public IRPSTextBox<QuotationLotMaterialCostDetailViewModelDialogView> ExecutionTime { get; set; } 
        public IRPSTextBox<QuotationLotMaterialCostDetailViewModelDialogView> PreparationTime { get; set; } 
        public IRPSTextBox<QuotationLotMaterialCostDetailViewModelDialogView> RepetitionTime { get; set; } 
        public QuotationLotMaterialCostDetailCollectionEditor<QuotationLotMaterialCostDetailViewModelDialogView> QuotationLotMaterialCostDetail { get; set; } 
        public QuotationLotQuotationTaskCostDetailCollectionEditor<QuotationLotMaterialCostDetailViewModelDialogView> QuotationLotQuotationTaskCostDetail { get; set; } 
        public IRPSSection<QuotationLotMaterialCostDetailViewModelDialogView> Section { get; set; } 
        public IRPSSection<QuotationLotMaterialCostDetailViewModelDialogView> Section1 { get; set; } 
        public QuotationLotSL Screen { get; set; }
        public QuotationLotMaterialCostDetailViewModelDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QuotationLotMaterialCostDetailCollectionEditor<QuotationLotMaterialCostDetailViewModelDialogView>:RPSCollectionEditor<QuotationLotMaterialCostDetailViewModelDialogView> where QuotationLotMaterialCostDetailViewModelDialogView : class, IView
    {
        public  QuotationLotMaterialCostDetailGridView<QuotationLotMaterialCostDetailViewModelDialogView> GridView {get;set;}
    }
    public partial class QuotationLotMaterialCostDetailGridView <QuotationLotMaterialCostDetailViewModelDialogView> :  RPSGridView<QuotationLotMaterialCostDetailViewModelDialogView> where QuotationLotMaterialCostDetailViewModelDialogView : class, IView
    {
        public QuotationLotMaterialCostDetailGridView(QuotationLotMaterialCostDetailViewModelDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationLotMaterialCostDetailViewModelDialogView>("","#2ed3bb33-8d98-4ea0-9a70-7add520885cf .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 
            QuantityType = RPSControlFactory.CreateRPSGridTextBox<QuotationLotMaterialCostDetailViewModelDialogView>("","#2ed3bb33-8d98-4ea0-9a70-7add520885cf .ag-row[role='row']@ROWINDEX [col-id='cQuantityType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationLotMaterialCostDetailViewModelDialogView> Order { get; set; } 
        public IRPSGridTextBox<QuotationLotMaterialCostDetailViewModelDialogView> QuantityType { get; set; } 
                     
    }
 
        public partial class QuotationLotQuotationTaskCostDetailCollectionEditor<QuotationLotMaterialCostDetailViewModelDialogView>:RPSCollectionEditor<QuotationLotMaterialCostDetailViewModelDialogView> where QuotationLotMaterialCostDetailViewModelDialogView : class, IView
    {
        public  QuotationLotQuotationTaskCostDetailGridView<QuotationLotMaterialCostDetailViewModelDialogView> GridView {get;set;}
    }
    public partial class QuotationLotQuotationTaskCostDetailGridView <QuotationLotMaterialCostDetailViewModelDialogView> :  RPSGridView<QuotationLotMaterialCostDetailViewModelDialogView> where QuotationLotMaterialCostDetailViewModelDialogView : class, IView
    {
        public QuotationLotQuotationTaskCostDetailGridView(QuotationLotMaterialCostDetailViewModelDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<QuotationLotMaterialCostDetailViewModelDialogView>("","#88d6bfc2-feb8-4892-bedb-08e9b8bc0e78 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            External = RPSControlFactory.CreateRPSGridCheckBox<QuotationLotMaterialCostDetailViewModelDialogView>("","#88d6bfc2-feb8-4892-bedb-08e9b8bc0e78 .ag-row[role='row']@ROWINDEX [col-id='cExternal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationLotMaterialCostDetailViewModelDialogView> Description { get; set; } 
        public IRPSGridCheckbox<QuotationLotMaterialCostDetailViewModelDialogView> External { get; set; } 
                     
    }
 
    }
  
            
    public partial class QuotationLotMaterialOverchargeDetailViewModelDialogView : View
    {
        public QuotationLotMaterialOverchargeDetailViewModelDialogView(QuotationLotSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_QuotationLotMaterialOverchargeDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2a6f7e3f-081d-48a6-bf48-653dbbcaa933",CSSSelectorGrid="",XPathGrid=""};
            QuotationLotMaterialOverchargeDetail = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationLotMaterialOverchargeDetailCollectionEditor<QuotationLotMaterialOverchargeDetailViewModelDialogView>,QuotationLotMaterialOverchargeDetailViewModelDialogView>( params_QuotationLotMaterialOverchargeDetail,this);
 
            Section = RPSControlFactory.CreateRPSSection<QuotationLotMaterialOverchargeDetailViewModelDialogView>( "","ul li[rpsid='4ffb6227-f1d3-4351-990e-40131b03b59d']","",this);
 

        }
        public QuotationLotMaterialOverchargeDetailCollectionEditor<QuotationLotMaterialOverchargeDetailViewModelDialogView> QuotationLotMaterialOverchargeDetail { get; set; } 
        public IRPSSection<QuotationLotMaterialOverchargeDetailViewModelDialogView> Section { get; set; } 
        public QuotationLotSL Screen { get; set; }
        public QuotationLotMaterialOverchargeDetailViewModelDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QuotationLotMaterialOverchargeDetailCollectionEditor<QuotationLotMaterialOverchargeDetailViewModelDialogView>:RPSCollectionEditor<QuotationLotMaterialOverchargeDetailViewModelDialogView> where QuotationLotMaterialOverchargeDetailViewModelDialogView : class, IView
    {
        public  QuotationLotMaterialOverchargeDetailGridView<QuotationLotMaterialOverchargeDetailViewModelDialogView> GridView {get;set;}
    }
    public partial class QuotationLotMaterialOverchargeDetailGridView <QuotationLotMaterialOverchargeDetailViewModelDialogView> :  RPSGridView<QuotationLotMaterialOverchargeDetailViewModelDialogView> where QuotationLotMaterialOverchargeDetailViewModelDialogView : class, IView
    {
        public QuotationLotMaterialOverchargeDetailGridView(QuotationLotMaterialOverchargeDetailViewModelDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationLotMaterialOverchargeDetailViewModelDialogView>("","#2a6f7e3f-081d-48a6-bf48-653dbbcaa933 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<QuotationLotMaterialOverchargeDetailViewModelDialogView>("","#2a6f7e3f-081d-48a6-bf48-653dbbcaa933 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridTextBox<QuotationLotMaterialOverchargeDetailViewModelDialogView>("","#2a6f7e3f-081d-48a6-bf48-653dbbcaa933 .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            Apply = RPSControlFactory.CreateRPSGridTextBox<QuotationLotMaterialOverchargeDetailViewModelDialogView>("","#2a6f7e3f-081d-48a6-bf48-653dbbcaa933 .ag-row[role='row']@ROWINDEX [col-id='cApply']","",false, this.CurrentView);
 
            Cascade = RPSControlFactory.CreateRPSGridCheckBox<QuotationLotMaterialOverchargeDetailViewModelDialogView>("","#2a6f7e3f-081d-48a6-bf48-653dbbcaa933 .ag-row[role='row']@ROWINDEX [col-id='cCascade']","",false, this.CurrentView);
 
            Proportional = RPSControlFactory.CreateRPSGridCheckBox<QuotationLotMaterialOverchargeDetailViewModelDialogView>("","#2a6f7e3f-081d-48a6-bf48-653dbbcaa933 .ag-row[role='row']@ROWINDEX [col-id='cProportional']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationLotMaterialOverchargeDetailViewModelDialogView> Order { get; set; } 
        public IRPSGridTextBox<QuotationLotMaterialOverchargeDetailViewModelDialogView> Description { get; set; } 
        public IRPSGridTextBox<QuotationLotMaterialOverchargeDetailViewModelDialogView> Type { get; set; } 
        public IRPSGridTextBox<QuotationLotMaterialOverchargeDetailViewModelDialogView> Apply { get; set; } 
        public IRPSGridCheckbox<QuotationLotMaterialOverchargeDetailViewModelDialogView> Cascade { get; set; } 
        public IRPSGridCheckbox<QuotationLotMaterialOverchargeDetailViewModelDialogView> Proportional { get; set; } 
                     
    }
 
    }
  
            
    public partial class QuotationLotResourceCostDetailViewModelDialogView : View
    {
        public QuotationLotResourceCostDetailViewModelDialogView(QuotationLotSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSFormattedTextBox<QuotationLotResourceCostDetailViewModelDialogView>("bdfea395-9cf3-4f9d-b205-6c5cab547bf1","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<QuotationLotResourceCostDetailViewModelDialogView>("32f75f5f-3e41-4352-848d-96adcc7277af","","",false, this);
 
            Type = RPSControlFactory.CreateRPSTextBox<QuotationLotResourceCostDetailViewModelDialogView>("e693cda8-79c3-4367-a358-7ed44b509699","","",false, this);
 
            Planify = RPSControlFactory.CreateRPSCheckBox<QuotationLotResourceCostDetailViewModelDialogView>("94ff82f1-bbcf-4944-8433-bb89377a0e76","","",false, this);
 
            Duration = RPSControlFactory.CreateRPSFormattedTextBox<QuotationLotResourceCostDetailViewModelDialogView>("23da0c1a-8420-48a5-8aab-a58ee019c64a","","",false, this);
 
            CollectionInit params_QuotationLotResourceCostDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="32259dbd-6114-4342-be6a-81a66ab1db3c",CSSSelectorGrid="",XPathGrid=""};
            QuotationLotResourceCostDetail = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationLotResourceCostDetailCollectionEditor<QuotationLotResourceCostDetailViewModelDialogView>,QuotationLotResourceCostDetailViewModelDialogView>( params_QuotationLotResourceCostDetail,this);
 
            Section = RPSControlFactory.CreateRPSSection<QuotationLotResourceCostDetailViewModelDialogView>( "","ul li[rpsid='066fff5d-1c20-40d3-8511-6d4e6d47ba26']","",this);
 

        }
        public IRPSTextBox<QuotationLotResourceCostDetailViewModelDialogView> Order { get; set; } 
        public IRPSTextBox<QuotationLotResourceCostDetailViewModelDialogView> Description { get; set; } 
        public IRPSTextBox<QuotationLotResourceCostDetailViewModelDialogView> Type { get; set; } 
        public IRPSCheckbox<QuotationLotResourceCostDetailViewModelDialogView> Planify { get; set; } 
        public IRPSTextBox<QuotationLotResourceCostDetailViewModelDialogView> Duration { get; set; } 
        public QuotationLotResourceCostDetailCollectionEditor<QuotationLotResourceCostDetailViewModelDialogView> QuotationLotResourceCostDetail { get; set; } 
        public IRPSSection<QuotationLotResourceCostDetailViewModelDialogView> Section { get; set; } 
        public QuotationLotSL Screen { get; set; }
        public QuotationLotResourceCostDetailViewModelDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QuotationLotResourceCostDetailCollectionEditor<QuotationLotResourceCostDetailViewModelDialogView>:RPSCollectionEditor<QuotationLotResourceCostDetailViewModelDialogView> where QuotationLotResourceCostDetailViewModelDialogView : class, IView
    {
        public  QuotationLotResourceCostDetailGridView<QuotationLotResourceCostDetailViewModelDialogView> GridView {get;set;}
    }
    public partial class QuotationLotResourceCostDetailGridView <QuotationLotResourceCostDetailViewModelDialogView> :  RPSGridView<QuotationLotResourceCostDetailViewModelDialogView> where QuotationLotResourceCostDetailViewModelDialogView : class, IView
    {
        public QuotationLotResourceCostDetailGridView(QuotationLotResourceCostDetailViewModelDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<QuotationLotResourceCostDetailViewModelDialogView>("","#32259dbd-6114-4342-be6a-81a66ab1db3c .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridTextBox<QuotationLotResourceCostDetailViewModelDialogView>("","#32259dbd-6114-4342-be6a-81a66ab1db3c .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<QuotationLotResourceCostDetailViewModelDialogView>("","#32259dbd-6114-4342-be6a-81a66ab1db3c .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationLotResourceCostDetailViewModelDialogView>("","#32259dbd-6114-4342-be6a-81a66ab1db3c .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationLotResourceCostDetailViewModelDialogView> Description { get; set; } 
        public IRPSGridTextBox<QuotationLotResourceCostDetailViewModelDialogView> Type { get; set; } 
        public IRPSGridCheckbox<QuotationLotResourceCostDetailViewModelDialogView> Planify { get; set; } 
        public IRPSGridTextBox<QuotationLotResourceCostDetailViewModelDialogView> Duration { get; set; } 
                     
    }
 
    }
  
            
    public partial class QuotationLotResourceOverchargeDetailViewModelDialogView : View
    {
        public QuotationLotResourceOverchargeDetailViewModelDialogView(QuotationLotSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSFormattedTextBox<QuotationLotResourceOverchargeDetailViewModelDialogView>("177e4297-92eb-48e9-a3ee-57f18fbda898","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<QuotationLotResourceOverchargeDetailViewModelDialogView>("fe708305-df27-42b7-b2c6-a9810b3c63f6","","",false, this);
 
            Apply = RPSControlFactory.CreateRPSTextBox<QuotationLotResourceOverchargeDetailViewModelDialogView>("e83717cf-cece-4053-9998-723d9bb3dd9c","","",false, this);
 
            Type = RPSControlFactory.CreateRPSTextBox<QuotationLotResourceOverchargeDetailViewModelDialogView>("e09d5a6a-4852-4bce-88b4-5c90d6ce842e","","",false, this);
 
            Cascade = RPSControlFactory.CreateRPSCheckBox<QuotationLotResourceOverchargeDetailViewModelDialogView>("cf128dfa-963b-4d33-8a75-15ddbd6f2435","","",false, this);
 
            Proportional = RPSControlFactory.CreateRPSCheckBox<QuotationLotResourceOverchargeDetailViewModelDialogView>("b184f971-321e-4713-9353-f8ab428b6a9c","","",false, this);
 
            CollectionInit params_QuotationLotResourceOverchargeDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ea0b4d97-71b2-424e-a7d2-f4ec9361fd45",CSSSelectorGrid="",XPathGrid=""};
            QuotationLotResourceOverchargeDetail = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationLotResourceOverchargeDetailCollectionEditor<QuotationLotResourceOverchargeDetailViewModelDialogView>,QuotationLotResourceOverchargeDetailViewModelDialogView>( params_QuotationLotResourceOverchargeDetail,this);
 
            Section = RPSControlFactory.CreateRPSSection<QuotationLotResourceOverchargeDetailViewModelDialogView>( "","ul li[rpsid='07dd9066-ee75-4b05-9679-5ea877f84ecb']","",this);
 

        }
        public IRPSTextBox<QuotationLotResourceOverchargeDetailViewModelDialogView> Order { get; set; } 
        public IRPSTextBox<QuotationLotResourceOverchargeDetailViewModelDialogView> Description { get; set; } 
        public IRPSTextBox<QuotationLotResourceOverchargeDetailViewModelDialogView> Apply { get; set; } 
        public IRPSTextBox<QuotationLotResourceOverchargeDetailViewModelDialogView> Type { get; set; } 
        public IRPSCheckbox<QuotationLotResourceOverchargeDetailViewModelDialogView> Cascade { get; set; } 
        public IRPSCheckbox<QuotationLotResourceOverchargeDetailViewModelDialogView> Proportional { get; set; } 
        public QuotationLotResourceOverchargeDetailCollectionEditor<QuotationLotResourceOverchargeDetailViewModelDialogView> QuotationLotResourceOverchargeDetail { get; set; } 
        public IRPSSection<QuotationLotResourceOverchargeDetailViewModelDialogView> Section { get; set; } 
        public QuotationLotSL Screen { get; set; }
        public QuotationLotResourceOverchargeDetailViewModelDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QuotationLotResourceOverchargeDetailCollectionEditor<QuotationLotResourceOverchargeDetailViewModelDialogView>:RPSCollectionEditor<QuotationLotResourceOverchargeDetailViewModelDialogView> where QuotationLotResourceOverchargeDetailViewModelDialogView : class, IView
    {
        public  QuotationLotResourceOverchargeDetailGridView<QuotationLotResourceOverchargeDetailViewModelDialogView> GridView {get;set;}
    }
    public partial class QuotationLotResourceOverchargeDetailGridView <QuotationLotResourceOverchargeDetailViewModelDialogView> :  RPSGridView<QuotationLotResourceOverchargeDetailViewModelDialogView> where QuotationLotResourceOverchargeDetailViewModelDialogView : class, IView
    {
        public QuotationLotResourceOverchargeDetailGridView(QuotationLotResourceOverchargeDetailViewModelDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<QuotationLotResourceOverchargeDetailViewModelDialogView>("","#ea0b4d97-71b2-424e-a7d2-f4ec9361fd45 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Apply = RPSControlFactory.CreateRPSGridTextBox<QuotationLotResourceOverchargeDetailViewModelDialogView>("","#ea0b4d97-71b2-424e-a7d2-f4ec9361fd45 .ag-row[role='row']@ROWINDEX [col-id='cApply']","",false, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridTextBox<QuotationLotResourceOverchargeDetailViewModelDialogView>("","#ea0b4d97-71b2-424e-a7d2-f4ec9361fd45 .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            Cascade = RPSControlFactory.CreateRPSGridCheckBox<QuotationLotResourceOverchargeDetailViewModelDialogView>("","#ea0b4d97-71b2-424e-a7d2-f4ec9361fd45 .ag-row[role='row']@ROWINDEX [col-id='cCascade']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationLotResourceOverchargeDetailViewModelDialogView> Description { get; set; } 
        public IRPSGridTextBox<QuotationLotResourceOverchargeDetailViewModelDialogView> Apply { get; set; } 
        public IRPSGridTextBox<QuotationLotResourceOverchargeDetailViewModelDialogView> Type { get; set; } 
        public IRPSGridCheckbox<QuotationLotResourceOverchargeDetailViewModelDialogView> Cascade { get; set; } 
                     
    }
 
    }
  
            
    public partial class QuotationLotOtherCostCostDetailViewModelDialogView : View
    {
        public QuotationLotOtherCostCostDetailViewModelDialogView(QuotationLotSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_QuotationLotOtherCostCostDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bcccdc2a-e299-412d-8c8e-05d968b49449",CSSSelectorGrid="",XPathGrid=""};
            QuotationLotOtherCostCostDetail = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationLotOtherCostCostDetailCollectionEditor<QuotationLotOtherCostCostDetailViewModelDialogView>,QuotationLotOtherCostCostDetailViewModelDialogView>( params_QuotationLotOtherCostCostDetail,this);
 
            Section = RPSControlFactory.CreateRPSSection<QuotationLotOtherCostCostDetailViewModelDialogView>( "","ul li[rpsid='d58ce139-488f-4dbc-a9e3-f9e95bae9785']","",this);
 

        }
        public QuotationLotOtherCostCostDetailCollectionEditor<QuotationLotOtherCostCostDetailViewModelDialogView> QuotationLotOtherCostCostDetail { get; set; } 
        public IRPSSection<QuotationLotOtherCostCostDetailViewModelDialogView> Section { get; set; } 
        public QuotationLotSL Screen { get; set; }
        public QuotationLotOtherCostCostDetailViewModelDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QuotationLotOtherCostCostDetailCollectionEditor<QuotationLotOtherCostCostDetailViewModelDialogView>:RPSCollectionEditor<QuotationLotOtherCostCostDetailViewModelDialogView> where QuotationLotOtherCostCostDetailViewModelDialogView : class, IView
    {
        public  QuotationLotOtherCostCostDetailGridView<QuotationLotOtherCostCostDetailViewModelDialogView> GridView {get;set;}
    }
    public partial class QuotationLotOtherCostCostDetailGridView <QuotationLotOtherCostCostDetailViewModelDialogView> :  RPSGridView<QuotationLotOtherCostCostDetailViewModelDialogView> where QuotationLotOtherCostCostDetailViewModelDialogView : class, IView
    {
        public QuotationLotOtherCostCostDetailGridView(QuotationLotOtherCostCostDetailViewModelDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<QuotationLotOtherCostCostDetailViewModelDialogView>("","#bcccdc2a-e299-412d-8c8e-05d968b49449 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationLotOtherCostCostDetailViewModelDialogView>("","#bcccdc2a-e299-412d-8c8e-05d968b49449 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationLotOtherCostCostDetailViewModelDialogView> Description { get; set; } 
        public IRPSGridTextBox<QuotationLotOtherCostCostDetailViewModelDialogView> Order { get; set; } 
                     
    }
 
    }
  
            
    public partial class QuotationLotOtherCostOverchargeDetailViewModelDialogView : View
    {
        public QuotationLotOtherCostOverchargeDetailViewModelDialogView(QuotationLotSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSFormattedTextBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView>("f6c470c3-4dde-45b4-81be-bcc12a57f956","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView>("ada67375-c4b8-488c-a695-d36931a8716d","","",false, this);
 
            Apply = RPSControlFactory.CreateRPSTextBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView>("42eb41ef-1c56-405f-9764-c7a27748ce4f","","",false, this);
 
            Type = RPSControlFactory.CreateRPSTextBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView>("69ca134f-38e0-49a2-84f2-4c8b05dfd414","","",false, this);
 
            Cascade = RPSControlFactory.CreateRPSCheckBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView>("d869c123-f0bf-4df2-a000-8167e4242c3e","","",false, this);
 
            Proportional = RPSControlFactory.CreateRPSCheckBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView>("061abe33-5273-4119-9a88-55c04d2b18d4","","",false, this);
 
            CollectionInit params_QuotationLotOtherCostOverchargeDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f9755ce7-91d4-42ec-bc3b-573c062ca2f4",CSSSelectorGrid="",XPathGrid=""};
            QuotationLotOtherCostOverchargeDetail = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationLotOtherCostOverchargeDetailCollectionEditor<QuotationLotOtherCostOverchargeDetailViewModelDialogView>,QuotationLotOtherCostOverchargeDetailViewModelDialogView>( params_QuotationLotOtherCostOverchargeDetail,this);
 
            Section = RPSControlFactory.CreateRPSSection<QuotationLotOtherCostOverchargeDetailViewModelDialogView>( "","ul li[rpsid='1250be93-3413-4e69-83f9-df43eab040e9']","",this);
 

        }
        public IRPSTextBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView> Order { get; set; } 
        public IRPSTextBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView> Description { get; set; } 
        public IRPSTextBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView> Apply { get; set; } 
        public IRPSTextBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView> Type { get; set; } 
        public IRPSCheckbox<QuotationLotOtherCostOverchargeDetailViewModelDialogView> Cascade { get; set; } 
        public IRPSCheckbox<QuotationLotOtherCostOverchargeDetailViewModelDialogView> Proportional { get; set; } 
        public QuotationLotOtherCostOverchargeDetailCollectionEditor<QuotationLotOtherCostOverchargeDetailViewModelDialogView> QuotationLotOtherCostOverchargeDetail { get; set; } 
        public IRPSSection<QuotationLotOtherCostOverchargeDetailViewModelDialogView> Section { get; set; } 
        public QuotationLotSL Screen { get; set; }
        public QuotationLotOtherCostOverchargeDetailViewModelDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QuotationLotOtherCostOverchargeDetailCollectionEditor<QuotationLotOtherCostOverchargeDetailViewModelDialogView>:RPSCollectionEditor<QuotationLotOtherCostOverchargeDetailViewModelDialogView> where QuotationLotOtherCostOverchargeDetailViewModelDialogView : class, IView
    {
        public  QuotationLotOtherCostOverchargeDetailGridView<QuotationLotOtherCostOverchargeDetailViewModelDialogView> GridView {get;set;}
    }
    public partial class QuotationLotOtherCostOverchargeDetailGridView <QuotationLotOtherCostOverchargeDetailViewModelDialogView> :  RPSGridView<QuotationLotOtherCostOverchargeDetailViewModelDialogView> where QuotationLotOtherCostOverchargeDetailViewModelDialogView : class, IView
    {
        public QuotationLotOtherCostOverchargeDetailGridView(QuotationLotOtherCostOverchargeDetailViewModelDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView>("","#f9755ce7-91d4-42ec-bc3b-573c062ca2f4 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Apply = RPSControlFactory.CreateRPSGridTextBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView>("","#f9755ce7-91d4-42ec-bc3b-573c062ca2f4 .ag-row[role='row']@ROWINDEX [col-id='cApply']","",false, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridTextBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView>("","#f9755ce7-91d4-42ec-bc3b-573c062ca2f4 .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            Cascade = RPSControlFactory.CreateRPSGridCheckBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView>("","#f9755ce7-91d4-42ec-bc3b-573c062ca2f4 .ag-row[role='row']@ROWINDEX [col-id='cCascade']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView> Description { get; set; } 
        public IRPSGridTextBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView> Apply { get; set; } 
        public IRPSGridTextBox<QuotationLotOtherCostOverchargeDetailViewModelDialogView> Type { get; set; } 
        public IRPSGridCheckbox<QuotationLotOtherCostOverchargeDetailViewModelDialogView> Cascade { get; set; } 
                     
    }
 
    }
  
            
    public partial class QuotationLotGeneralOverchargeDetailViewModelDialogView : View
    {
        public QuotationLotGeneralOverchargeDetailViewModelDialogView(QuotationLotSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSFormattedTextBox<QuotationLotGeneralOverchargeDetailViewModelDialogView>("cc9c9fbb-99a5-4a3e-bad0-0b4ae89dcc32","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<QuotationLotGeneralOverchargeDetailViewModelDialogView>("deba2cd0-d00a-4ad6-b284-b6f1c910f1d0","","",false, this);
 
            Apply = RPSControlFactory.CreateRPSTextBox<QuotationLotGeneralOverchargeDetailViewModelDialogView>("48dafa87-f1a3-494b-ae04-96af8c8d2608","","",false, this);
 
            Type = RPSControlFactory.CreateRPSTextBox<QuotationLotGeneralOverchargeDetailViewModelDialogView>("a2122cbf-450e-4d97-bd11-c7da7f642350","","",false, this);
 
            Cascade = RPSControlFactory.CreateRPSCheckBox<QuotationLotGeneralOverchargeDetailViewModelDialogView>("45e3e774-70e3-4f74-a87f-5ef2cac3ef98","","",false, this);
 
            Proportional = RPSControlFactory.CreateRPSCheckBox<QuotationLotGeneralOverchargeDetailViewModelDialogView>("b3dec049-9b2c-402d-a314-709aa0370509","","",false, this);
 
            CollectionInit params_QuotationLotGeneralOverchargeDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f4494887-1bf6-41a4-b044-79bd3bb93aec",CSSSelectorGrid="",XPathGrid=""};
            QuotationLotGeneralOverchargeDetail = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationLotGeneralOverchargeDetailCollectionEditor<QuotationLotGeneralOverchargeDetailViewModelDialogView>,QuotationLotGeneralOverchargeDetailViewModelDialogView>( params_QuotationLotGeneralOverchargeDetail,this);
 
            Section = RPSControlFactory.CreateRPSSection<QuotationLotGeneralOverchargeDetailViewModelDialogView>( "","ul li[rpsid='ace0d863-fea7-4561-be28-330f35b38f5a']","",this);
 

        }
        public IRPSTextBox<QuotationLotGeneralOverchargeDetailViewModelDialogView> Order { get; set; } 
        public IRPSTextBox<QuotationLotGeneralOverchargeDetailViewModelDialogView> Description { get; set; } 
        public IRPSTextBox<QuotationLotGeneralOverchargeDetailViewModelDialogView> Apply { get; set; } 
        public IRPSTextBox<QuotationLotGeneralOverchargeDetailViewModelDialogView> Type { get; set; } 
        public IRPSCheckbox<QuotationLotGeneralOverchargeDetailViewModelDialogView> Cascade { get; set; } 
        public IRPSCheckbox<QuotationLotGeneralOverchargeDetailViewModelDialogView> Proportional { get; set; } 
        public QuotationLotGeneralOverchargeDetailCollectionEditor<QuotationLotGeneralOverchargeDetailViewModelDialogView> QuotationLotGeneralOverchargeDetail { get; set; } 
        public IRPSSection<QuotationLotGeneralOverchargeDetailViewModelDialogView> Section { get; set; } 
        public QuotationLotSL Screen { get; set; }
        public QuotationLotGeneralOverchargeDetailViewModelDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QuotationLotGeneralOverchargeDetailCollectionEditor<QuotationLotGeneralOverchargeDetailViewModelDialogView>:RPSCollectionEditor<QuotationLotGeneralOverchargeDetailViewModelDialogView> where QuotationLotGeneralOverchargeDetailViewModelDialogView : class, IView
    {
        public  QuotationLotGeneralOverchargeDetailGridView<QuotationLotGeneralOverchargeDetailViewModelDialogView> GridView {get;set;}
    }
    public partial class QuotationLotGeneralOverchargeDetailGridView <QuotationLotGeneralOverchargeDetailViewModelDialogView> :  RPSGridView<QuotationLotGeneralOverchargeDetailViewModelDialogView> where QuotationLotGeneralOverchargeDetailViewModelDialogView : class, IView
    {
        public QuotationLotGeneralOverchargeDetailGridView(QuotationLotGeneralOverchargeDetailViewModelDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<QuotationLotGeneralOverchargeDetailViewModelDialogView>("","#f4494887-1bf6-41a4-b044-79bd3bb93aec .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Apply = RPSControlFactory.CreateRPSGridTextBox<QuotationLotGeneralOverchargeDetailViewModelDialogView>("","#f4494887-1bf6-41a4-b044-79bd3bb93aec .ag-row[role='row']@ROWINDEX [col-id='cApply']","",false, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridTextBox<QuotationLotGeneralOverchargeDetailViewModelDialogView>("","#f4494887-1bf6-41a4-b044-79bd3bb93aec .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            Cascade = RPSControlFactory.CreateRPSGridCheckBox<QuotationLotGeneralOverchargeDetailViewModelDialogView>("","#f4494887-1bf6-41a4-b044-79bd3bb93aec .ag-row[role='row']@ROWINDEX [col-id='cCascade']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationLotGeneralOverchargeDetailViewModelDialogView> Description { get; set; } 
        public IRPSGridTextBox<QuotationLotGeneralOverchargeDetailViewModelDialogView> Apply { get; set; } 
        public IRPSGridTextBox<QuotationLotGeneralOverchargeDetailViewModelDialogView> Type { get; set; } 
        public IRPSGridCheckbox<QuotationLotGeneralOverchargeDetailViewModelDialogView> Cascade { get; set; } 
                     
    }
 
    }
  
    

}