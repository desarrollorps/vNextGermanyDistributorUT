    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.CustomizeOrderProject
{
    //RPS VERSION 1.0.0.0
    public partial class CustomizeOrderProject:Screen
    {
        public CustomizeOrderProject():base()
        {
            this.URL = "project.customizeorderproject";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomizeOrderProjectView  = new CustomizeOrderProjectView(this); 
            GenerateViewModelDialogView  = new GenerateViewModelDialogView(this); 
            OrderSLView  = new OrderSLView(this); 
            SalesQuoteSLView  = new SalesQuoteSLView(this); 
            NoOrderOrSalesQuoteView  = new NoOrderOrSalesQuoteView(this); 
            OrderLineSLView  = new OrderLineSLView(this); 
            SalesQuoteLineSLView  = new SalesQuoteLineSLView(this); 
            CustomizeOrderProjectView.InitializeControls(); 
            GenerateViewModelDialogView.InitializeControls(); 
            OrderSLView.InitializeControls(); 
            SalesQuoteSLView.InitializeControls(); 
            NoOrderOrSalesQuoteView.InitializeControls(); 
            OrderLineSLView.InitializeControls(); 
            SalesQuoteLineSLView.InitializeControls(); 
           
        }
      
            public CustomizeOrderProjectView CustomizeOrderProjectView {get; set; } 
            public GenerateViewModelDialogView GenerateViewModelDialogView {get; set; } 
            public OrderSLView OrderSLView {get; set; } 
            public SalesQuoteSLView SalesQuoteSLView {get; set; } 
            public NoOrderOrSalesQuoteView NoOrderOrSalesQuoteView {get; set; } 
            public OrderLineSLView OrderLineSLView {get; set; } 
            public SalesQuoteLineSLView SalesQuoteLineSLView {get; set; } 
    }
            
    public partial class CustomizeOrderProjectView : View
    {
        public CustomizeOrderProjectView(CustomizeOrderProject screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Project = RPSControlFactory.CreateRPSComboBox<CustomizeOrderProjectView>("e590b816-1af8-4833-89f2-d07a6aefc795","","",false, this);
 
            GenerateViewModelNavigationCommand = RPSControlFactory.CreateRPSButtonToView<CustomizeOrderProjectView,GenerateViewModelDialogView>("c37897cc-31fc-41af-8c9e-4fb7bb5c1eff","","", this,Screen.GenerateViewModelDialogView);
 
            Customer = RPSControlFactory.CreateRPSComboBox<CustomizeOrderProjectView>("d5a4edd0-b9dc-4f8f-949d-281ec67b9f7b","","",false, this);
 
            ProjectAmount = RPSControlFactory.CreateRPSFormattedTextBox<CustomizeOrderProjectView>("37e61065-7679-4379-b7f3-d91d39777edd","","",false, this);
 
            SalesQuoteSL = RPSControlFactory.CreateRPSComboBox<CustomizeOrderProjectView>("e03fa0d4-09ef-43ab-b08a-94933cec7273","","",false, this);
 
            SalesQuoteAmount = RPSControlFactory.CreateRPSFormattedTextBox<CustomizeOrderProjectView>("d5ef0c25-1a0d-443e-a89d-b11cc821784f","","",false, this);
 
            OrderSL = RPSControlFactory.CreateRPSComboBox<CustomizeOrderProjectView>("9206e259-093e-4414-a9f3-326a6ac98049","","",false, this);
 
            OrderAmount = RPSControlFactory.CreateRPSFormattedTextBox<CustomizeOrderProjectView>("5d197978-2337-4875-840b-c88a26404f4c","","",false, this);
 

        }
        public IRPSComboBox<CustomizeOrderProjectView> Project { get; set; } 
        public IRPSButton<CustomizeOrderProjectView,GenerateViewModelDialogView> GenerateViewModelNavigationCommand { get; set; } 
        public IRPSComboBox<CustomizeOrderProjectView> Customer { get; set; } 
        public IRPSTextBox<CustomizeOrderProjectView> ProjectAmount { get; set; } 
        public IRPSComboBox<CustomizeOrderProjectView> SalesQuoteSL { get; set; } 
        public IRPSTextBox<CustomizeOrderProjectView> SalesQuoteAmount { get; set; } 
        public IRPSComboBox<CustomizeOrderProjectView> OrderSL { get; set; } 
        public IRPSTextBox<CustomizeOrderProjectView> OrderAmount { get; set; } 
        public CustomizeOrderProject Screen { get; set; }
        public CustomizeOrderProjectView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateViewModelDialogView : View
    {
        public GenerateViewModelDialogView(CustomizeOrderProject screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSOption<GenerateViewModelDialogView>( "29183563-de80-4539-a705-812d9b25fed3","","",this);
 
            SalesQuote = RPSControlFactory.CreateRPSOption<GenerateViewModelDialogView>( "6bbf3394-0e13-4796-8dac-0cad32d42971","","",this);
 
            LineForProject = RPSControlFactory.CreateRPSCheckBox<GenerateViewModelDialogView>("c6b9a923-c2fd-4265-a83a-6bf4cb37ba9c","","",false, this);
 
            LineForTask = RPSControlFactory.CreateRPSCheckBox<GenerateViewModelDialogView>("b220fc88-bd27-4c08-ab86-407464254673","","",false, this);
 
            ResourceBreakdown = RPSControlFactory.CreateRPSCheckBox<GenerateViewModelDialogView>("66110e95-3748-4d25-8a78-0b7eabde4727","","",false, this);
 
            LaborAndMachines = RPSControlFactory.CreateRPSCheckBox<GenerateViewModelDialogView>("f32166e1-6f7e-4577-b5d7-29fd9b58d908","","",false, this);
 
            Materials = RPSControlFactory.CreateRPSCheckBox<GenerateViewModelDialogView>("b023a7b9-e8cc-4a7c-ba58-0bf58579658d","","",false, this);
 
            CostComponents = RPSControlFactory.CreateRPSCheckBox<GenerateViewModelDialogView>("45c05b50-43f2-4188-bbe4-5eba2315e67f","","",false, this);
 
            InProject = RPSControlFactory.CreateRPSOption<GenerateViewModelDialogView>( "3498c9d8-68bf-48c2-823b-550c6632dbb6","","",this);
 
            InTasks = RPSControlFactory.CreateRPSOption<GenerateViewModelDialogView>( "a94af168-0ebd-4720-86a0-2d744af2c953","","",this);
 
            InResources = RPSControlFactory.CreateRPSOption<GenerateViewModelDialogView>( "9ec66965-028a-41a4-96a5-abcb295ef347","","",this);
 
            None = RPSControlFactory.CreateRPSOption<GenerateViewModelDialogView>( "bb22125a-8974-46fa-ac8b-cdab0f45f15d","","",this);
 
            Consumption = RPSControlFactory.CreateRPSOption<GenerateViewModelDialogView>( "6892b888-f27a-432f-b463-70ecf75125fa","","",this);
 
            Milestone = RPSControlFactory.CreateRPSOption<GenerateViewModelDialogView>( "e2270269-944f-4c64-947b-5f7a3722944c","","",this);
 
            ByAmount = RPSControlFactory.CreateRPSOption<GenerateViewModelDialogView>( "5276ef76-41f7-4968-9112-05642d9961f9","","",this);
 
            ByQuantity = RPSControlFactory.CreateRPSOption<GenerateViewModelDialogView>( "9f6f5846-61aa-4a3e-95bf-a1af01ee7c22","","",this);
 
            SalesAmount = RPSControlFactory.CreateRPSOption<GenerateViewModelDialogView>( "4287ff44-8d2b-42ee-9872-9303c92558bc","","",this);
 
            BudgetAmount = RPSControlFactory.CreateRPSOption<GenerateViewModelDialogView>( "349236d1-f669-4198-a2d7-00985c3d5b5b","","",this);
 
            CostArticle = RPSControlFactory.CreateRPSOption<GenerateViewModelDialogView>( "0729a9e3-b2c9-4ea6-976b-8c9d73f5708b","","",this);
 
            CostProject = RPSControlFactory.CreateRPSOption<GenerateViewModelDialogView>( "6cac8397-877a-4e48-bc99-7d01ab020e54","","",this);
 
            OptionValue = RPSControlFactory.CreateRPSOption<GenerateViewModelDialogView>( "f3896736-cf26-4f69-8784-5681f16ee7a1","","",this);
 
            CollectionInit params_ProjectTaskMilestoneInvoicingDataCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="76457a3e-b993-41eb-8afa-7db4d777389c",CSSSelectorGrid="",XPathGrid=""};
            ProjectTaskMilestoneInvoicingDataCollection = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectTaskMilestoneInvoicingDataCollectionCollectionEditor<GenerateViewModelDialogView>,GenerateViewModelDialogView>( params_ProjectTaskMilestoneInvoicingDataCollection,this);
 

        }
        public IRPSOption<GenerateViewModelDialogView> Order { get; set; } 
        public IRPSOption<GenerateViewModelDialogView> SalesQuote { get; set; } 
        public IRPSCheckbox<GenerateViewModelDialogView> LineForProject { get; set; } 
        public IRPSCheckbox<GenerateViewModelDialogView> LineForTask { get; set; } 
        public IRPSCheckbox<GenerateViewModelDialogView> ResourceBreakdown { get; set; } 
        public IRPSCheckbox<GenerateViewModelDialogView> LaborAndMachines { get; set; } 
        public IRPSCheckbox<GenerateViewModelDialogView> Materials { get; set; } 
        public IRPSCheckbox<GenerateViewModelDialogView> CostComponents { get; set; } 
        public IRPSOption<GenerateViewModelDialogView> InProject { get; set; } 
        public IRPSOption<GenerateViewModelDialogView> InTasks { get; set; } 
        public IRPSOption<GenerateViewModelDialogView> InResources { get; set; } 
        public IRPSOption<GenerateViewModelDialogView> None { get; set; } 
        public IRPSOption<GenerateViewModelDialogView> Consumption { get; set; } 
        public IRPSOption<GenerateViewModelDialogView> Milestone { get; set; } 
        public IRPSOption<GenerateViewModelDialogView> ByAmount { get; set; } 
        public IRPSOption<GenerateViewModelDialogView> ByQuantity { get; set; } 
        public IRPSOption<GenerateViewModelDialogView> SalesAmount { get; set; } 
        public IRPSOption<GenerateViewModelDialogView> BudgetAmount { get; set; } 
        public IRPSOption<GenerateViewModelDialogView> CostArticle { get; set; } 
        public IRPSOption<GenerateViewModelDialogView> CostProject { get; set; } 
        public IRPSOption<GenerateViewModelDialogView> OptionValue { get; set; } 
        public ProjectTaskMilestoneInvoicingDataCollectionCollectionEditor<GenerateViewModelDialogView> ProjectTaskMilestoneInvoicingDataCollection { get; set; } 
        public CustomizeOrderProject Screen { get; set; }
        public GenerateViewModelDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProjectTaskMilestoneInvoicingDataCollectionCollectionEditor<GenerateViewModelDialogView>:RPSCollectionEditor<GenerateViewModelDialogView> where GenerateViewModelDialogView : class, IView
    {
        public  ProjectTaskMilestoneInvoicingDataCollectionGridView<GenerateViewModelDialogView> GridView {get;set;}
    }
    public partial class ProjectTaskMilestoneInvoicingDataCollectionGridView <GenerateViewModelDialogView> :  RPSGridView<GenerateViewModelDialogView> where GenerateViewModelDialogView : class, IView
    {
        public ProjectTaskMilestoneInvoicingDataCollectionGridView(GenerateViewModelDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ProjectTask = RPSControlFactory.CreateRPSGridComboBox<GenerateViewModelDialogView>("","#76457a3e-b993-41eb-8afa-7db4d777389c .ag-row[role='row']@ROWINDEX [col-id='cProjectTask']","",false, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<GenerateViewModelDialogView>("","#76457a3e-b993-41eb-8afa-7db4d777389c .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",false, this.CurrentView);
 
            Prepayment = RPSControlFactory.CreateRPSGridCheckBox<GenerateViewModelDialogView>("","#76457a3e-b993-41eb-8afa-7db4d777389c .ag-row[role='row']@ROWINDEX [col-id='cPrepayment']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<GenerateViewModelDialogView> ProjectTask { get; set; } 
        public IRPSGridTextBox<GenerateViewModelDialogView> Percentage { get; set; } 
        public IRPSGridCheckbox<GenerateViewModelDialogView> Prepayment { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderSLView : View
    {
        public OrderSLView(CustomizeOrderProject screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<OrderSLView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderSLView,CustomizeOrderProjectView>( this,Screen.CustomizeOrderProjectView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderSLView,CustomizeOrderProjectView>( this,Screen.CustomizeOrderProjectView);
 
            ProjectAmount = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLView>("156d552a-e4c5-44e8-870e-b8162d672d44","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSComboBox<OrderSLView>("92b46cb4-f041-4048-bd0b-476ff1a16dcf","","",true, this);
 
            SalesQuoteAmount = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLView>("a8d7ef22-a188-4b9a-a04f-2827e4c1525c","","",false, this);
 
            SalesQuoteSL = RPSControlFactory.CreateRPSComboBox<OrderSLView>("11050a37-1e0a-4ee1-bf0c-0ddbd79abb55","","",false, this);
 
            OrderAmount = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLView>("99014629-2c37-4bbe-bbc0-d36918040af3","","",false, this);
 
            OrderSL = RPSControlFactory.CreateRPSComboBox<OrderSLView>("79e62fe3-fd37-444b-a3e5-3d5f05402254","","",false, this);
 
            CollectionInit params_OrderLineSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3f778242-f8a8-456e-b2b8-584ed867aa8e",CSSSelectorGrid="",XPathGrid=""};
            OrderLineSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineSLsCollectionEditor<OrderSLView,OrderLineSLView>,OrderSLView,OrderLineSLView>( params_OrderLineSLs,this,Screen.OrderLineSLView);
 
            CollectionInit params_OrderMilestoneSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9326465d-bc64-47ea-a3e6-12932265b5eb",CSSSelectorGrid="",XPathGrid=""};
            OrderMilestoneSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderMilestoneSLsCollectionEditor<OrderSLView,OrderLineSLView>,OrderSLView,OrderLineSLView>( params_OrderMilestoneSLs,this,Screen.OrderLineSLView);
 
            OrderLines = RPSControlFactory.CreateRPSSection<OrderSLView>( "","ul li[rpsid='13c61fb4-22fd-4ab5-bb45-fd66378f1aac']","",this);
 
            Milestone = RPSControlFactory.CreateRPSSection<OrderSLView>( "","ul li[rpsid='4a5cf30b-cae6-4361-9720-ba738ae2e2ad']","",this);
 

        }
        public IRPSSaveButton<OrderSLView> SaveButton { get; set; } 
        public IRPSButton<OrderSLView> DeleteButton { get; set; } 
        public IRPSButton<OrderSLView,CustomizeOrderProjectView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderSLView,CustomizeOrderProjectView> BackButton { get; set; } 
        public IRPSTextBox<OrderSLView> ProjectAmount { get; set; } 
        public IRPSComboBox<OrderSLView> Customer { get; set; } 
        public IRPSTextBox<OrderSLView> SalesQuoteAmount { get; set; } 
        public IRPSComboBox<OrderSLView> SalesQuoteSL { get; set; } 
        public IRPSTextBox<OrderSLView> OrderAmount { get; set; } 
        public IRPSComboBox<OrderSLView> OrderSL { get; set; } 
        public OrderLineSLsCollectionEditor<OrderSLView,OrderLineSLView> OrderLineSLs { get; set; } 
        public OrderMilestoneSLsCollectionEditor<OrderSLView,OrderLineSLView> OrderMilestoneSLs { get; set; } 
        public IRPSSection<OrderSLView> OrderLines { get; set; } 
        public IRPSSection<OrderSLView> Milestone { get; set; } 
        public CustomizeOrderProject Screen { get; set; }
        public OrderSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderLineSLsCollectionEditor<OrderSLView,OrderLineSLView>:RPSCollectionEditor<OrderSLView,OrderLineSLView> where OrderSLView : class, IView where OrderLineSLView : class, IView
    {
        public  OrderLineSLsGridView<OrderSLView,OrderLineSLView> GridView {get;set;}
    }
    public partial class OrderLineSLsGridView <OrderSLView,OrderLineSLView> :  RPSGridView<OrderSLView,OrderLineSLView> where OrderSLView : class, IView where OrderLineSLView : class, IView
    {
        public OrderLineSLsGridView(OrderSLView currentView,OrderLineSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<OrderSLView>("","#3f778242-f8a8-456e-b2b8-584ed867aa8e .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSGridComboBox<OrderSLView>("","#3f778242-f8a8-456e-b2b8-584ed867aa8e .ag-row[role='row']@ROWINDEX [col-id='cIDDeliveryNoteType']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLView>("","#3f778242-f8a8-456e-b2b8-584ed867aa8e .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLView>("","#3f778242-f8a8-456e-b2b8-584ed867aa8e .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLView>("","#3f778242-f8a8-456e-b2b8-584ed867aa8e .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            TypeInvoiceProject = RPSControlFactory.CreateRPSGridEnumComboBox<OrderSLView>("","#3f778242-f8a8-456e-b2b8-584ed867aa8e .ag-row[role='row']@ROWINDEX [col-id='cTypeInvoiceProject']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderSLView> IDArticle { get; set; } 
        public IRPSGridComboBox<OrderSLView> IDDeliveryNoteType { get; set; } 
        public IRPSGridTextBox<OrderSLView> Quantity { get; set; } 
        public IRPSGridTextBox<OrderSLView> Price { get; set; } 
        public IRPSGridTextBox<OrderSLView> Amount { get; set; } 
        public IRPSGridComboBox<OrderSLView> TypeInvoiceProject { get; set; } 
                     
    }
 
        public partial class OrderMilestoneSLsCollectionEditor<OrderSLView,OrderLineSLView>:RPSCollectionEditor<OrderSLView,OrderLineSLView> where OrderSLView : class, IView where OrderLineSLView : class, IView
    {
        public  OrderMilestoneSLsGridView<OrderSLView,OrderLineSLView> GridView {get;set;}
    }
    public partial class OrderMilestoneSLsGridView <OrderSLView,OrderLineSLView> :  RPSGridView<OrderSLView,OrderLineSLView> where OrderSLView : class, IView where OrderLineSLView : class, IView
    {
        public OrderMilestoneSLsGridView(OrderSLView currentView,OrderLineSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTask = RPSControlFactory.CreateRPSGridComboBox<OrderSLView>("","#9326465d-bc64-47ea-a3e6-12932265b5eb .ag-row[role='row']@ROWINDEX [col-id='cIDTask']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLView>("","#9326465d-bc64-47ea-a3e6-12932265b5eb .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            UIFinal = RPSControlFactory.CreateRPSGridCheckBox<OrderSLView>("","#9326465d-bc64-47ea-a3e6-12932265b5eb .ag-row[role='row']@ROWINDEX [col-id='cUIFinal']","",false, this.CurrentView);
 
            GenerateAdvance = RPSControlFactory.CreateRPSGridCheckBox<OrderSLView>("","#9326465d-bc64-47ea-a3e6-12932265b5eb .ag-row[role='row']@ROWINDEX [col-id='cGenerateAdvance']","",true, this.CurrentView);
 
            Invoiced = RPSControlFactory.CreateRPSGridCheckBox<OrderSLView>("","#9326465d-bc64-47ea-a3e6-12932265b5eb .ag-row[role='row']@ROWINDEX [col-id='cInvoiced']","",true, this.CurrentView);
 
            UIPlannedDate = RPSControlFactory.CreateRPSGridTextBox<OrderSLView>("","#9326465d-bc64-47ea-a3e6-12932265b5eb .ag-row[role='row']@ROWINDEX [col-id='cUIPlannedDate']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderSLView> IDTask { get; set; } 
        public IRPSGridTextBox<OrderSLView> Percentage { get; set; } 
        public IRPSGridCheckbox<OrderSLView> UIFinal { get; set; } 
        public IRPSGridCheckbox<OrderSLView> GenerateAdvance { get; set; } 
        public IRPSGridCheckbox<OrderSLView> Invoiced { get; set; } 
        public IRPSGridTextBox<OrderSLView> UIPlannedDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class SalesQuoteSLView : View
    {
        public SalesQuoteSLView(CustomizeOrderProject screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SalesQuoteSLView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesQuoteSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesQuoteSLView,CustomizeOrderProjectView>( this,Screen.CustomizeOrderProjectView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesQuoteSLView,CustomizeOrderProjectView>( this,Screen.CustomizeOrderProjectView);
 
            ProjectAmount = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLView>("ad2366e1-4a64-4e6e-800c-3f92e4c5a153","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLView>("5f8648a4-b77f-47d4-af45-ec509eff75e0","","",false, this);
 
            IDPotentialCustomer = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLView>("f5d94a8c-9ab6-4be1-9e0e-4a827efb330d","","",false, this);
 
            SalesQuoteAmount = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLView>("4850aa74-831c-4487-8871-98a11f07e545","","",false, this);
 
            SalesQuoteSL = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLView>("7b6788f8-8c37-4770-a3c6-3376112f295c","","",false, this);
 
            CollectionInit params_SalesQuoteLineSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8017b276-52cf-4d88-ac56-adf8abadee6f",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteLineSLs = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteLineSLsCollectionEditor<SalesQuoteSLView,SalesQuoteLineSLView>,SalesQuoteSLView,SalesQuoteLineSLView>( params_SalesQuoteLineSLs,this,Screen.SalesQuoteLineSLView);
 
            CollectionInit params_SalesQuoteMilestoneSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="34cc58c3-12c1-4fd9-9b05-051ae7461f25",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteMilestoneSLs = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteMilestoneSLsCollectionEditor<SalesQuoteSLView,SalesQuoteLineSLView>,SalesQuoteSLView,SalesQuoteLineSLView>( params_SalesQuoteMilestoneSLs,this,Screen.SalesQuoteLineSLView);
 
            SalesQuoteLines = RPSControlFactory.CreateRPSSection<SalesQuoteSLView>( "","ul li[rpsid='fd3c3184-cc18-4d35-b88f-1959cf4d2acb']","",this);
 
            Milestone = RPSControlFactory.CreateRPSSection<SalesQuoteSLView>( "","ul li[rpsid='59075883-c0ad-4081-a9d8-4f24f1cf8d33']","",this);
 

        }
        public IRPSSaveButton<SalesQuoteSLView> SaveButton { get; set; } 
        public IRPSButton<SalesQuoteSLView> DeleteButton { get; set; } 
        public IRPSButton<SalesQuoteSLView,CustomizeOrderProjectView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesQuoteSLView,CustomizeOrderProjectView> BackButton { get; set; } 
        public IRPSTextBox<SalesQuoteSLView> ProjectAmount { get; set; } 
        public IRPSComboBox<SalesQuoteSLView> Customer { get; set; } 
        public IRPSComboBox<SalesQuoteSLView> IDPotentialCustomer { get; set; } 
        public IRPSTextBox<SalesQuoteSLView> SalesQuoteAmount { get; set; } 
        public IRPSComboBox<SalesQuoteSLView> SalesQuoteSL { get; set; } 
        public SalesQuoteLineSLsCollectionEditor<SalesQuoteSLView,SalesQuoteLineSLView> SalesQuoteLineSLs { get; set; } 
        public SalesQuoteMilestoneSLsCollectionEditor<SalesQuoteSLView,SalesQuoteLineSLView> SalesQuoteMilestoneSLs { get; set; } 
        public IRPSSection<SalesQuoteSLView> SalesQuoteLines { get; set; } 
        public IRPSSection<SalesQuoteSLView> Milestone { get; set; } 
        public CustomizeOrderProject Screen { get; set; }
        public SalesQuoteSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SalesQuoteLineSLsCollectionEditor<SalesQuoteSLView,SalesQuoteLineSLView>:RPSCollectionEditor<SalesQuoteSLView,SalesQuoteLineSLView> where SalesQuoteSLView : class, IView where SalesQuoteLineSLView : class, IView
    {
        public  SalesQuoteLineSLsGridView<SalesQuoteSLView,SalesQuoteLineSLView> GridView {get;set;}
    }
    public partial class SalesQuoteLineSLsGridView <SalesQuoteSLView,SalesQuoteLineSLView> :  RPSGridView<SalesQuoteSLView,SalesQuoteLineSLView> where SalesQuoteSLView : class, IView where SalesQuoteLineSLView : class, IView
    {
        public SalesQuoteLineSLsGridView(SalesQuoteSLView currentView,SalesQuoteLineSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<SalesQuoteSLView>("","#8017b276-52cf-4d88-ac56-adf8abadee6f .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLView>("","#8017b276-52cf-4d88-ac56-adf8abadee6f .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLView>("","#8017b276-52cf-4d88-ac56-adf8abadee6f .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLView>("","#8017b276-52cf-4d88-ac56-adf8abadee6f .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            TypeInvoiceProject = RPSControlFactory.CreateRPSGridEnumComboBox<SalesQuoteSLView>("","#8017b276-52cf-4d88-ac56-adf8abadee6f .ag-row[role='row']@ROWINDEX [col-id='cTypeInvoiceProject']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SalesQuoteSLView> IDArticle { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLView> Quantity { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLView> Price { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLView> Amount { get; set; } 
        public IRPSGridComboBox<SalesQuoteSLView> TypeInvoiceProject { get; set; } 
                     
    }
 
        public partial class SalesQuoteMilestoneSLsCollectionEditor<SalesQuoteSLView,SalesQuoteLineSLView>:RPSCollectionEditor<SalesQuoteSLView,SalesQuoteLineSLView> where SalesQuoteSLView : class, IView where SalesQuoteLineSLView : class, IView
    {
        public  SalesQuoteMilestoneSLsGridView<SalesQuoteSLView,SalesQuoteLineSLView> GridView {get;set;}
    }
    public partial class SalesQuoteMilestoneSLsGridView <SalesQuoteSLView,SalesQuoteLineSLView> :  RPSGridView<SalesQuoteSLView,SalesQuoteLineSLView> where SalesQuoteSLView : class, IView where SalesQuoteLineSLView : class, IView
    {
        public SalesQuoteMilestoneSLsGridView(SalesQuoteSLView currentView,SalesQuoteLineSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTask = RPSControlFactory.CreateRPSGridComboBox<SalesQuoteSLView>("","#34cc58c3-12c1-4fd9-9b05-051ae7461f25 .ag-row[role='row']@ROWINDEX [col-id='cIDTask']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLView>("","#34cc58c3-12c1-4fd9-9b05-051ae7461f25 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            UIFinal = RPSControlFactory.CreateRPSGridCheckBox<SalesQuoteSLView>("","#34cc58c3-12c1-4fd9-9b05-051ae7461f25 .ag-row[role='row']@ROWINDEX [col-id='cUIFinal']","",false, this.CurrentView);
 
            GenerateAdvance = RPSControlFactory.CreateRPSGridCheckBox<SalesQuoteSLView>("","#34cc58c3-12c1-4fd9-9b05-051ae7461f25 .ag-row[role='row']@ROWINDEX [col-id='cGenerateAdvance']","",true, this.CurrentView);
 
            UIPlannedDate = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLView>("","#34cc58c3-12c1-4fd9-9b05-051ae7461f25 .ag-row[role='row']@ROWINDEX [col-id='cUIPlannedDate']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SalesQuoteSLView> IDTask { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLView> Percentage { get; set; } 
        public IRPSGridCheckbox<SalesQuoteSLView> UIFinal { get; set; } 
        public IRPSGridCheckbox<SalesQuoteSLView> GenerateAdvance { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLView> UIPlannedDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class NoOrderOrSalesQuoteView : View
    {
        public NoOrderOrSalesQuoteView(CustomizeOrderProject screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public CustomizeOrderProject Screen { get; set; }
        public NoOrderOrSalesQuoteView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderLineSLView : View
    {
        public OrderLineSLView(CustomizeOrderProject screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderLineSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderLineSLView,OrderSLView>( this,Screen.OrderSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderLineSLView,OrderSLView>( this,Screen.OrderSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderLineSLView,OrderSLView>( this,Screen.OrderSLView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("8f7939b7-5e88-4495-9207-9be8bd556e4e","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("b7965dc6-b114-42c7-999c-81b6c6a562f7","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("451975f2-f82b-4d3f-8f26-e2454367496b","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("f506b5c6-3560-47a7-b161-2231cb23f3a0","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("7faf7bbe-80ba-41b9-84bb-1ac02a110b4c","","",true, this);
 
            TypeInvoiceProject = RPSControlFactory.CreateRPSEnumComboBox<OrderLineSLView>("bfe4e711-a9e2-4ce8-be1f-35c5b8e562d9","","",true, this);
 
            CollectionInit params_GetOrderCertificationResources = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="85daedf7-d0da-4f12-87ad-5a26a05f7507",CSSSelectorGrid="",XPathGrid=""};
            GetOrderCertificationResources = RPSControlFactory.RPSCreateCollectionWithGrid<GetOrderCertificationResourcesCollectionEditor<OrderLineSLView>,OrderLineSLView>( params_GetOrderCertificationResources,this);
 

        }
        public IRPSButton<OrderLineSLView> DeleteButton { get; set; } 
        public IRPSButton<OrderLineSLView,OrderSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderLineSLView,OrderSLView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderLineSLView,OrderSLView> AcceptButton { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDArticle { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDDeliveryNoteType { get; set; } 
        public IRPSTextBox<OrderLineSLView> Quantity { get; set; } 
        public IRPSTextBox<OrderLineSLView> Price { get; set; } 
        public IRPSTextBox<OrderLineSLView> Amount { get; set; } 
        public IRPSComboBox<OrderLineSLView> TypeInvoiceProject { get; set; } 
        public GetOrderCertificationResourcesCollectionEditor<OrderLineSLView> GetOrderCertificationResources { get; set; } 
        public CustomizeOrderProject Screen { get; set; }
        public OrderLineSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetOrderCertificationResourcesCollectionEditor<OrderLineSLView>:RPSCollectionEditor<OrderLineSLView> where OrderLineSLView : class, IView
    {
        public  GetOrderCertificationResourcesGridView<OrderLineSLView> GridView {get;set;}
    }
    public partial class GetOrderCertificationResourcesGridView <OrderLineSLView> :  RPSGridView<OrderLineSLView> where OrderLineSLView : class, IView
    {
        public GetOrderCertificationResourcesGridView(OrderLineSLView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Linked = RPSControlFactory.CreateRPSGridCheckBox<OrderLineSLView>("","#85daedf7-d0da-4f12-87ad-5a26a05f7507 .ag-row[role='row']@ROWINDEX [col-id='cLinked']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<OrderLineSLView> Linked { get; set; } 
                     
    }
 
    }
  
            
    public partial class SalesQuoteLineSLView : View
    {
        public SalesQuoteLineSLView(CustomizeOrderProject screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesQuoteLineSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesQuoteLineSLView,SalesQuoteSLView>( this,Screen.SalesQuoteSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesQuoteLineSLView,SalesQuoteSLView>( this,Screen.SalesQuoteSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SalesQuoteLineSLView,SalesQuoteSLView>( this,Screen.SalesQuoteSLView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineSLView>("b1a435cf-32d0-4e29-8910-16094eb0177f","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("cde26ed6-d41b-434b-8527-d0414ce46126","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("6ec9332a-0bfc-40a8-b3c5-3db2aca53ffd","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("8417cbeb-fc2c-4762-9d20-dae814a3d6e7","","",true, this);
 
            TypeInvoiceProject = RPSControlFactory.CreateRPSEnumComboBox<SalesQuoteLineSLView>("4bbb4fd6-cb0d-4e75-8369-86daf7509460","","",true, this);
 
            CollectionInit params_GetSalesQuoteCertificationResources = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4ff8b952-772f-49bd-9839-d09b982c38f1",CSSSelectorGrid="",XPathGrid=""};
            GetSalesQuoteCertificationResources = RPSControlFactory.RPSCreateCollectionWithGrid<GetSalesQuoteCertificationResourcesCollectionEditor<SalesQuoteLineSLView>,SalesQuoteLineSLView>( params_GetSalesQuoteCertificationResources,this);
 

        }
        public IRPSButton<SalesQuoteLineSLView> DeleteButton { get; set; } 
        public IRPSButton<SalesQuoteLineSLView,SalesQuoteSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesQuoteLineSLView,SalesQuoteSLView> BackButton { get; set; } 
        public IRPSAcceptButton<SalesQuoteLineSLView,SalesQuoteSLView> AcceptButton { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> IDArticle { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Quantity { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Price { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Amount { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> TypeInvoiceProject { get; set; } 
        public GetSalesQuoteCertificationResourcesCollectionEditor<SalesQuoteLineSLView> GetSalesQuoteCertificationResources { get; set; } 
        public CustomizeOrderProject Screen { get; set; }
        public SalesQuoteLineSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetSalesQuoteCertificationResourcesCollectionEditor<SalesQuoteLineSLView>:RPSCollectionEditor<SalesQuoteLineSLView> where SalesQuoteLineSLView : class, IView
    {
        public  GetSalesQuoteCertificationResourcesGridView<SalesQuoteLineSLView> GridView {get;set;}
    }
    public partial class GetSalesQuoteCertificationResourcesGridView <SalesQuoteLineSLView> :  RPSGridView<SalesQuoteLineSLView> where SalesQuoteLineSLView : class, IView
    {
        public GetSalesQuoteCertificationResourcesGridView(SalesQuoteLineSLView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Linked = RPSControlFactory.CreateRPSGridCheckBox<SalesQuoteLineSLView>("","#4ff8b952-772f-49bd-9839-d09b982c38f1 .ag-row[role='row']@ROWINDEX [col-id='cLinked']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<SalesQuoteLineSLView> Linked { get; set; } 
                     
    }
 
    }
  
    

}